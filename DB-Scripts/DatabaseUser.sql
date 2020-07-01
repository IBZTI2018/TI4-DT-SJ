-- user database

-- Datenbank User erstellen und zugriffsrechte verwalten 

-- erstellt am 01.07.2020
-- Jennifer Mentner & Sven Gehring

-- geändert am xx.xx.xxxx
-------------------------------------------------

use casestudy;
GO

CREATE LOGIN casestudy WITH PASSWORD = 'master',
Check_POLICY = OFF;
GO


CREATE USER administration FOR LOGIN casestudy WITH PASSWORD = 'administ'; 

CREATE ROLE adminrole;
GRANT UPDATE, ALTER, DROP ON abo TO adminrole;
GRANT UPDATE, ALTER, DROP ON aboart TO adminrole;
GRANT UPDATE,  DROP ON person TO adminrole;
GRANT adminrole to administration;


CREATE USER Mitgliedsverwaltung FOR LOGIN casestudy WITH PASSWORD = 'mitgli';

CREATE USER Standplatzverwalter FOR LOGIN casestudy WITH PASSWORD = 'standpl';

CREATE USER qualitaetsverantworliche FOR LOGIN casestudy WITH PASSWORD = 'quali';


