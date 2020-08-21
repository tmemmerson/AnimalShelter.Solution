using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetsController : ControllerBase
    {
        private AnimalShelterContext _db;

        public PetsController(AnimalShelterContext db)
        {
            _db = db;
        }
        
    
   // GET api/pets
    [HttpGet]
    public ActionResult<IEnumerable<Pet>> Get(string petName, string petAdmissionDate, string petTaxonomy, string petBreed, string petDescription)
    {
        var query = _db.Pets.AsQueryable(); //standard

        if (petName != null)
        {
            query = query.Where(entry => entry.PetName == petName);
        }

        if (petAdmissionDate != null)
        {
            query = query.Where(entry => entry.PetAdmissionDate == petAdmissionDate);
        }

        if (petTaxonomy != null)
        {
            query = query.Where(entry => entry.PetTaxonomy == petTaxonomy);
        }
        
        if (petBreed != null)
        {
            query = query.Where(entry => entry.PetBreed == petBreed);
        }
        
        if (petDescription != null)
        {
            query = query.Where(entry => entry.PetDescription == petDescription);
        }

        return query.ToList();
    }


        [HttpPost]
        public void Post([FromBody] Pet pet)
        {
            _db.Pets.Add(pet);
            _db.SaveChanges();
        }

        [HttpGet ("{id}")]
        public ActionResult<Pet> Get(int id)
        {
        return _db.Pets.FirstOrDefault(entry => entry.PetId == id);
        }
        
        //Pagination
        [HttpGet("page")]
        public ActionResult GetPage([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.Pets
                .OrderBy(pet => pet.PetId)
                .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
        }

        // PUT api/pets/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Pet pet)
        {
            pet.PetId = id;
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var petToDelete = _db.Pets.FirstOrDefault(entry => entry.PetId == id);
            _db.Pets.Remove(petToDelete);
            _db.SaveChanges();
        }
    }
}