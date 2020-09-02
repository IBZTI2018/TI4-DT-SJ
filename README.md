# TI4-DT-SJ Case-Study
The following preparations need to be done manually on the system before working with this project.

#### 1. Creating the database
```sql
CREATE DATABASE casestudy;
```

#### 2. Create a user for development
Use the SQL Server management studio to create a user and password for yourself and give it all permissions on the `casestudy` database. The credentials must then be configured in `TI4-DT-SJ/App.config`.

You can use `git update-index --assume-unchanged TI4-DT-SJ/App.config` to prevent commiting changes to that file (e.g. your personal credentials).

#### 3. Creating database users
The following SQL script will create all users required for running the case study database demonstration. It must be run with a user that has the permission to create and modify login/user information, such as the windows administrator.
```sql
-- Make sure this is run on the casestudy database!
USE casestudy;

-- Create a master user and login for development and testing of the database
CREATE LOGIN casestudy WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy FOR LOGIN casestudy WITH DEFAULT_SCHEMA=casestudy; 

-- Create users and logins for all different roles defined in the documentation
CREATE LOGIN casestudy_administration WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_administration FOR LOGIN casestudy_administration WITH DEFAULT_SCHEMA=casestudy;

CREATE LOGIN casestudy_mitgliederverwalter WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_mitgliederverwalter FOR LOGIN casestudy_mitgliederverwalter WITH DEFAULT_SCHEMA=casestudy;

CREATE LOGIN casestudy_standplatzverwalter WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_standplatzverwalter FOR LOGIN casestudy_standplatzverwalter WITH DEFAULT_SCHEMA=casestudy;

CREATE LOGIN casestudy_qualitaetsverantwortlicher WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_qualitaetsverantwortlicher FOR LOGIN casestudy_qualitaetsverantwortlicher WITH DEFAULT_SCHEMA=casestudy;
```

#### 4. Run and Test
You may now run the application. Since the application is built for a proof-of-concept case study, there is no intention for it to ever run as a properly compiled application. It is currently only intended to run from Visual Studio.

The following command line options are supported for launching:
* `create` - Run the `DatabaseCreate.sql` script.
* `drop` - Run the `DatabaseDrop.sql` script.
* `seed` - Run the `DatabaseSeed.sql` script.
* `test` - Run `DatabaseCreate.sql`, all four different database test classes and `DatabaseDrop.sql`.
* `testonly` - Run just the database test classees
* _none_ - Run the UI. (Run `create` and `seed` first!)

When the program crashes between properly creating and dropping the database, there might be leftovers that prevent future runs from succeeding. After a crash, make sure to use SQL management studio to remove all tables and roles!

#### 5. Clean up
After testing, the following commands can be run to drop all the users and logins that have been created by the section above for properly testing the database and its permission limits.
```sql
-- Make sure this is run on the casestudy database!
USE casestudy;

-- Drop all created users and logins
DROP USER casestudy;
DROP LOGIN casestudy;
DROP USER casestudy_administration;
DROP LOGIN casestudy_administration;
DROP USER casestudy_mitgliederverwalter;
DROP LOGIN casestudy_mitgliederverwalter;
DROP USER casestudy_standplatzverwalter;
DROP LOGIN casestudy_standplatzverwalter;
DROP USER casestudy_qualitaetsverantwortlicher;
DROP LOGIN casestudy_qualitaetsverantwortlicher;

-- Drop the database itself
GO
DROP DATABASE casestudy;
```
