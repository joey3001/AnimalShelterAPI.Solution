# Joe's Animal Shelter - .NET Web API & MVC
#### 1/22/2021

#### 1/18/2021

### 📖 Description

This application is a custom .NET Web API that stores dogs & cats available for adoption at an animal shelter. The app also utilizes the Entity framework to setup and manipulate an SQL database. User's can create, edit, and delete database entries through the .NET MVC client side of the project. Swagger was used to auto-generate documentation on the API. You can also interact with the API using the swagger UI interface. 

#### By Joseph Nero 

## 🔧 Setup/Installation Requirements
#### If you have difficulty following any of the steps/instructions listed below, please contact me at josephnero111@gmail.com 

1. Git Bash (or another terminal program) & Git.  
    - To clone the repository from Github using git commands in the terminal, you need a terminal program & Git. For Windows OS, I recommend the Git Bash terminal program. Installing Git Bash will also install Git. 

2. VSCode (or another code editor)
    - To view/edit this code, you need a code editor. I recommend VSCode. 

3. For Detailed instructions on how to install Git Bash & VSCode, visit the Setup/Installation Requirements section of the README for [this repo.](https://github.com/joey3001/first-friday-project)

4. C# & .NetCore
    - To run this project you will need C# & .NET Core. You can check if you have these installed by entering the following command into your terminal program :

            dotnet --version 

    - if C# & .NET Core are downloaded, the .NET Core version number will be presented. An example of this is as follows : 

            2.2.203

    - If no version number is presented, visit [this website](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) to download C# & .NET Core. Once the download is complete, you can execute "dotnet --version" in your terminal again to verify its successful installation. 

5. dotnet script REPL
    - The dotnet script REPL allows you to run compiled code one line at a time. To install dotnet script enter the following command into your terminal program (only do this after completing the above step) : 

            dotnet tool install -g dotnet-script

6. MySQL & MySQL Workbench
    - MySQL is an open-source relational database management system. MySQL Workbench is a visual database design tool for the MySQL database system.You can download them both [here.](https://dev.mysql.com/downloads/file/?id=484919)

#### To clone this project using git commands in the terminal : 

1. Use the following command in your terminal program to clone the repo :

            git clone https://github.com/joey3001/AnimalShelterAPI.Solution

#### To set up the Database/API and run the project using terminal commands, follow the instructions below : 

1. In the "AnimalShelterAPI" directory, update the text in the appsettings.json file to include your MySQL password. You should have made this password when you downloaded/setup MySQL & MySQL workbench. An example is included below : 

            {
              "ConnectionStrings": {
                  "DefaultConnection": "Server=localhost;Port=3306;database=joseph_nero;uid=root;pwd=Your_Password_Here;"
              }
            }
<br/>
**Terminal commands listed in the following steps should be executed in the AnimalShelterAPI Directory**

<br/>  
2. Use the following command in your terminal program to restore the dependencies and tools of the project : 

            dotnet restore

3. Use the following command in your terminal program to setup the Database : 

            dotnet ef database update

4. Use the following command in your terminal program to compile the code : 

            dotnet build 

5. Next, use the following command in your terminal program to execute the compiled code : 

            dotnet run 

6. If you update the structure of the database, use the following command in your terminal program to add a migration : 

            dotnet ef migrations add "The title of your migration"

7. Open a new terminal window to execute further commands while running the API. **Do not close the API.**
<br/>
**Terminal commands listed in the following steps should be executed in the AnimalShelterClient directory**
<br/>
8. Use the following command in your terminal program to restore the dependencies and tools of the project : 

            dotnet restore

9. Use the following command in your terminal program to compile the code : 

            dotnet build 

10. Next, use the following command in your terminal program to execute the compiled code. **This step will only work correctly if the API is also running in a separate terminal window :** 

            dotnet run 

#### To view/interact with the API through the Swagger UI & Swagger documentation follow these steps :  

1. Navigate to "http://localhost:5000/swagger" in your browser to access the Swagger UI. From here, you can execute commands to the API with the Swagger interface. 

2. Navigate to "http://localhost:5000/swagger/v1/swagger.json" to view the raw json documentation. 

#### To view the code in the VSCode editor using commands in the terminal :  

1. Navigate to the project's root directory with the cd command. 

2. Once you are within the project's root directory, enter the following command into your terminal program to view all of the project's code in VSCode : 

            code . 

#### To download a file containing the contents of this repository to a location of your choice :  

1. Use a web browser to go to the repository webpage at [this link.](https://github.com/joey3001/AnimalShelterAPI.Solution)
2. Click on the green button labeled "code" towards the right side of the page's center. In the drop-down menu that opens, click on the button labeled "Download Zip."
3. Once your download is complete, open the zipped file. Click on the button labeled "Extract All" at the top of your file explorer. 
4. Choose the location in which you want to extract the files, and navigate to that location once this process is complete. 

## 🐛 Known Bugs

No known bugs are present at this time. 

## 📫 Support and contact details

If you have an issue, reach out to me at josephnero111@gmail.com

## 🛠️ Technologies Used

  * C# V7.3
  * MySQL & MySQL Workbench 
  * Swagger - Swashbuckle.AspNetCore
  * Entity Framework
  * Identity Framework
  * .NET Core V2.2
  * dotnet script REPL
  * VSCode 
  * Git
  * Github 
  * Git Bash

### 📘 License

[MIT License](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 Joseph Nero 
