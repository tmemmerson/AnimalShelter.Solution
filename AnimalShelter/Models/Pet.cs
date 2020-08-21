using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AnimalShelter.Models
{
  public class Pet
  {
    public int PetId { get; set; }
    public string PetName { get; set; }
    public string PetAdmissionDate { get; set; }
    public string PetTaxonomy { get; set; }
    public string PetBreed { get; set; }
    public string PetDescription { get; set; }

  }
}
