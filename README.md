# API for conscious choice 

[View in Azure](https://panakota.azurewebsites.net/OpenAPI/index.html)

## About product 

It helps voters to get all information about deputies. Information consists of voting results on bills. 
Product consists of three parts: API, Frontend (Angular), Telegram-bot. 

- API - parses kenesh.kg to get information about bills, connects to database and gives requested information 
- Frontend - Shows statistics of deputies and proposed bills
- Telegram-bot - gets information about deputies and shows their activity with a short message

### What does this project have? 
- .Net 5 - Asp.net core 
- Onion architecture
- Swagger 
- Api versioning 
- CI/CD

### Getting started via visual studio and local DB
 - Download Visual studio
 - Open .sln file
 - Wait until VS restores packages
 - Choose Conscious.Choice.OnionApi as a Startup project
 - Open Package Manager Console, select << ProjectName >>.Persistence as Default Project
 - Run these commands:
 - Restore database using SSMS (bkp files in additional links)
```
PM> add-migration Initial-commit-Application -Context ApplicationDbContext -o Migrations/Application
PM> add-migration Identity-commit -Context IdentityContext -o Migrations/Identity

PM> update-database -Context ApplicationDbContext 
PM> update-database -Context IdentityContext 
```
 - Build and Run application

--- 
### Additional links 
- [Telegram-bot](https://github.com/SsamansS/consciousvote) repository that uses this API 
- [Frontend](https://kinsta.com/wp-content/uploads/2017/10/501-not-implemented-error-social-1.png)
- [DataBase](https://github.com/Zhantai-Nuradinovich/PanakotaDb) repository for Database and some scripts
