// provide the information about .NETT
dotnet --info

// for help
dotnet -h

// list of types of solutions
dotnew new list

//create empty solution
dotnet new sln -n WD.DailyNeeds 

//show dot new projects
dotnet new list

//select webapi create api project
dotnet new webapi -o WD.DailyNeeds.API -

//create class library (Core)
dotnet new classlib -o WD.DailyNeeds.Core

//create class library (Infrastructure)
dotnet new classlib -o WD.DailyNeeds.Infrastructure

//add sln inside API (WD.DailyNeeds.API) ,Core and Infrastructure
dotnet sln add WD.DailyNeeds.API 
dotnet sln add WD.DailyNeeds.Core 
dotnet sln add WD.DailyNeeds.Infrastructure 

// Provide the list of all the solutions
dotnet sln list

API ---> Infrastructure ---> Core (Dependency of API over Infrastructure and Infrastructure over Core)

// add references of Infrasturcture to API (move to API folder) 
cd WD.DailyNeeds.API
dotnet add reference ../WD.DailyNeeds.Infrastructure

// add references of Core to Infrasturcture (move to Infrasturcture folder)  
cd WD.DailyNeeds.Infrasturcture
dotnet add reference ../WD.DailyNeeds.Core 

//Determine projects to restore
dotnet restore

//Build projects 
dotnet build


//download docker desktop for windows
https://docs.docker.com/desktop/install/windows-install/


//create docker-compose file
docker-compose.yml

// run the below command to run docker
docker compose up -d

//install nuget package in API
https://www.nuget.org/packages/dotnet-ef
dotnet tool install --global dotnet-ef --version 8.0.8

//dotnet ef commands
            database    Commands to manage the database.
            dbcontext   Commands to manage DbContext types.
            migrations  Commands to manage migrations.


dotnet ef migrations add InitialCreate -s WD.DailyNeeds.API -p WD.DailyNeeds.Infrastructure   
-s for switch and -p for       

//remove the migration and mark <InvariantGlobalization>false</InvariantGlobalization> in .csproj file of API
dotnet ef migrations remove -s WD.DailyNeeds.API -p WD.DailyNeeds.Infrastructure 



//create database
dotnet ef database update -s WD.DailyNeeds.API -p WD.DailyNeeds.Infrastructure

//add connection with database extension
click on SQLSERVER extension Ctrl+Alt D 
and fill the required information and stop the existing instance of sql server 

// add gitignore file

dotnet new gitignore

