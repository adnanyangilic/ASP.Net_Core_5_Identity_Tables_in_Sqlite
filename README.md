# ASP.Net_Core_5_Identity_in_Sqlite
1-Create ASP.Net core mvc project with personal accounts (Identity) option.
2-Install nuget package Microsoft.EntityFrameworkCore.Sqlite
3-Modify Startup.cs services with Usesqlite instruction.
4-Modify connection string in appsettings.json.
5-SQLite app.db is created by Visual Studio by update-database migration command thanks to nuget package Microsoft.EntityFrameworkCore.Sqlite 
6-If Visual Studio created app.db file but identity tables migration errored then delete migrations folder and renew migrations by add-migration and update-database commands.
7-Put sqlite db file in a folder and modify connection string accordingly. 
8-Putting Sqlite db in folder is optional to easily arrange and upgrade folder read write permissions in remote plesk hosting. 
9-Db browser for Sqlite is management studio for Sqlite. Download and install it to work with internal structures and tables in Sqlite.
