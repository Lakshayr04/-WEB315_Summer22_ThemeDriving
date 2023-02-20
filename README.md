# -WEB315_Summer22_ThemeDriving

1. Created a PRIVATE github repository that incorporates the course number      WEB315_Summer22_ThemeDriving and Readme.md file created.

2. Invited you as a collaborator to the repository (username is Majid1292).

3. Created webapp and now commiting.

4. Theme, Name, Date and time.

5. Models folder created with file name as ThemeDriving.cs

6.  In that file, I defined the class model. A minimum of 6
properties in this class. One is ID, and DataType.

7. dotnet tool install --global dotnet-ef --version 5
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

8. Use the Scaffolding terminal commands to build out your CRUD pages for model.
Document the commands in the Readme.md.



dotnet-aspnet-codegenerator razorpage -m ThemeDriving -dc ThemeDrivingContext -udl -outDir Pages/ThemeDriving --referenceScriptLibraries -sqlite

installing
dotnet ef migrations add InitialCreate
dotnet ef database update

9. I add the class name of SeedDataThemeName.


ASSIGNMEN