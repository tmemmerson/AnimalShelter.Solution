

<h1 align="center">
  <img width="900" height="450" src="https://coding-assets.s3-us-west-2.amazonaws.com/hero_images/AnimalShelter.Solution.jpg">

  
**<h1 align = "center">Animal Shelter**


</h1>
     
<br>

<h4 align = "center">
  <a href="#requirements">Requirements</a> •
  <a href="#technologies-used">Technologies</a> •
  <a href="#known-bugs">Known Bugs</a> •  
  <a href="#contributors">Contributors</a> •
  <a href="#license">License</a>•
  <a href='#cloning'>Cloning</a>
  </h4>


<br>

# **ABOUT**

You've completed a few projects at the dev agency where you work and you've been given more autonomy to choose which project you'd like to work on next. The agency currently has three new back-end contracts to build APIs for their clients. Since this is the first time you've been given free rein on a project, take this opportunity to showcase your versatility for the project manager.

* Animal Shelter: API for a local animal shelter. The API will list the available cats and dogs at the shelter
* Application includes CRUD functionality and successfully returns responses to API calls.
* Application includes pagination


# **REQUIREMENTS** 

* Install [Git v2.62.2+](https://git-scm.com/downloads/)
* Install [.NET version 3.1 SDK v2.2+](https://dotnet.microsoft.com/download/dotnet-core/2.2)
* Install [Visual Studio Code](https://code.visualstudio.com/)
* Install [MySql Workbench](https://www.mysql.com/products/workbench/)
* Install [Postman]](https://www.postman.com/)




# **CLONING**
copy this url to clone this project to your local system:
```html
https://github.com/tmemmerson/AnimalShelter.Solution.git
```

<br>

Once copied, select "Clone Repository" from within VSCode & paste the copied link as shown in the image below.

![cloning](https://coding-assets.s3-us-west-2.amazonaws.com/img/clone-github2.gif "Cloning from Github within VSCode")

<br>

# **APP SETTINGS**
**You need to update your username and password in the appsettings.json file.**

_By default these are set to user:root and an empty password. If you are unsure, refer to the settings for your MySqlWorkbench._

![appsettings](https://coding-assets.s3-us-west-2.amazonaws.com/img/app-settings.png)


# **INSTALLATION** 

open and sign-in to MySql to start database services (these credentials are the same as in your app settings)

``
cd AnimalShelter
``

``
dotnet restore
``

``
dotnet build
``

``
dotnet ef database update
``

``
dotnet watch run
``



## TO GET AN ITEM
* Open Postman
* Set your request to type "GET" 
* http://localhost:5000/api/pets/ (for index of all)
* http://localhost:5000/api/pets/id (for specific pet details)
* Hit Send

## TO ADD AN ITEM
* Open Postman
* Set your request to type "POST"
* http://localhost:5000/api/pets/ 
* Select Body Tab
* Select Raw Radio Button
* Select JSON from dropdown
* Write your addition to the database in the following format

<br>

``
{
    "petId": 1,
    "petName": "Mark",
    "petAdmissionDate": "8/13/2020",
    "petTaxonomy": "Cat",
    "petBreed": "Calico",
    "petDescription": "Don't look Mark straight in the eyes. He likes to get scratchy."
}
``
* Hit Send

## TO EDIT AN ITEM
* Open Postman
* Make a GET request for the id you wish to edit
* http://localhost:5000/api/pets/id
* You can select the returned item data and paste that into your request body section for editing. 
* Once you have completed your edits. 
* Set your request to Put
* Hit Send

## TO DELETE AN ITEM
* Open Postman
* Set your route in Postman to the id you wish to delete
* Set your request to Delete
* Hit Send


## USING PAGINATION
* you can use routing in this structure when making your requests to limit the return data
* adjust the PageNumber and PageSize values in your request to do so
* http://localhost:5000/api/pets/page?PageNumber=2&PageSize=5

<br>

# **TECHNOLOGIES USED**

_**Written in:** [Visual Studio Code](https://code.visualstudio.com/)_

_**Image work:** [Adobe Photoshop](https://www.adobe.com/products/photoshop.html/)_

_**Database Mgmt:** [MySql Workbench](https://www.mysql.com/products/workbench/)_

_**API Interfacing:** [Postman](https://www.postman.com/)_

<br>

# **KNOWN BUGS**

_**None as of:** 8/21/2020_

<br>

# **CONTRIBUTORS**



| [<img src='https://coding-assets.s3-us-west-2.amazonaws.com/img/tristan_emmerson.jpg' width='160px;'/><br /><sub><b>Tristan Emmerson</b></sub>](https://www.linkedin.com/in/tristan-emmerson/)<br />


# **LICENSE**
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

Copyright (c) 2020 **_Tristan Emmerson, Stickerslug Inc._**