# dotnetcore-angular-seed-advanced
##Asp.Net Core MVC 6 Implementation of angular-seed-advanced
Beginning of a seed based off the [angular-seed-advanced](https://github.com/NathanWalker/angular-seed-advanced) 

<p>In its current state this is a proof of concept, to be tailored and refactored as needed to give a pleasent development workflow with 
separation of concerns in mind while leveraging all that the angular-seed-advanced seed provides already.</p>

### Usage

<p>clone the repository.</p>
```bash
cd Seed.Client
npm install
gulp build.mvc.dev
cd ../Seed.Api
dotnet restore
#Set your environemnt variable relative to your OS for ASPNETCORE_ENVIRONMENT="Developement"
dotnet run
```
open your browser and browse to [localhost:5000](http://localhost:5000)
