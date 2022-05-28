# ASP.Net_Core_5_Identity_in_Sqlite
--Create ASP.Net core mvc project with personal accounts (Identity) option.
--Install nuget package Microsoft.EntityFrameworkCore.Sqlite
--Modify Startup.cs services with Usesqlite instruction.
--Modify connection string in appsettings.json.
--SQLite db is created by Visual Studio by update-database migration command thanks to nuget package Microsoft.EntityFrameworkCore.Sqlite 
--If VS created Db.sqlite but migrations errored then delete migrations and renew migrations.
--Put sqlite db file in a folder and modify connection string accordingly. 
--Putting Sqlite db in folder is optional to easily arrange and upgrade folder read write permissions in remote plesk hosting. 
