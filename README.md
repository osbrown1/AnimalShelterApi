# Animal Shelter API

#### By Owen Brown

## Technologies Used

* C#
* VS Code
* .Net 6
* MySQL
* Entity Framework Core 6
 
## Description
An API with Versioning that allows access and search of data for the Cats and Dogs of the Animal Shelter, such as their name, breed, and age.

## Versioning
##### I used API versioning in my project. What is API versioning?

* API versioning is a remedy for not breaking things when API's are changed.

##### how is this done?

* This is done by making a new version, hence the name.

##### In other words:

* Versioning is the practice of creating and managing different versions of a software or codebase. It allows developers to keep track of changes made to their code over time, and ensures that they can easily roll back to a previous version if necessary. Versioning is particularly important when working on large-scale projects or collaborating with other developers, as it helps to prevent conflicts and ensure that everyone is working on the same version of the code. There are many different version control systems available, but one of the most popular is Git, which is what I used.


## The Following Endpoints are Used: 
### CatsController:

* GET /api/v1.0/cats

Returns a list of all cats in the database.

Parameters:

breed: Filters the cats by breed.

name: Filters the cats by name.

minimumAge: Filters the cats by minimum age.

* GET /api/v1.0/cats/{id}

Returns a cat with the specified ID.

Parameters:

id: The ID of the cat to retrieve.

* POST /api/v1.0/cats

Creates a new cat in the database.

* PUT /api/v1.0/cats/{id}

Updates a cat with the specified ID.

Parameters:

id: The ID of the cat to update.

* DELETE /api/v1.0/cats/{id}

Deletes a cat with the specified ID.

Parameters:

id: The ID of the cat to delete.

//////////////////////////////////

### DogsController:

* GET /api/v1.0/dogs

Returns a list of all dogs in the database.

Parameters:

breed: Filters the dogs by breed.

name: Filters the dogs by name.

minimumAge: Filters the dogs by minimum age.

* GET /api/v1.0/dogs/{id}

Returns a dog with the specified ID.

Parameters:

id: The ID of the dog to retrieve.

* POST /api/v1.0/dogs

Creates a new dog in the database.

* PUT /api/v1.0/dogs/{id}

Updates a dog with the specified ID.

Parameters:

id: The ID of the dog to update.

* DELETE /api/v1.0/dogs/{id}

Deletes a dog with the specified ID.

Parameters:

id: The ID of the dog to delete.


### Setup Instructions...

#### You Will Need: 

* A code editor, like VS Code
* Git installed
* .Net6 SDK installed
* MySql Workbench installed

#### Database Migrations:
* Install dotnet-ef 
* Install Microsoft.EntityFrameworkCore.Design package in production directory
* Create migration
* Update database with the migration

#### Preliminary Project Set-up:
1. Clone or download this repository to your machine.
2. Navigate to the local directory (YourPath/ProjectName.Solution/ProjectName) and create a new file "appsettings.json".
3. Open the file in VS Code and add:
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```

**IMPORTANT:** Be sure to replace your username, password, and name of your database for the fields [YOUR-USER-HERE], [YOUR-PASSWORD-HERE], AND [YOUR-DB-NAME].

4. Create a .gitignore file and add "appsettings.json", "bin", and "obj" to the ignored file list.  
5. Open your shell (e.g., Terminal or GitBash) and add your .gitignore file and commit it before adding any other files. 
6. Navigate to this project's production directory called "AnimalShelterApi". 
3. In the command line, run the command `dotnet run` to compile and execute the console application. Optionally, you can run `dotnet build` to compile this console app without running it. 
6. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
7. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

None that I noticed so far

## License
Enjoy the site! If you have questions or suggestions for fixing the code, please contact me!

MIT License Copyright (c) 2023 Owen Brown, Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.