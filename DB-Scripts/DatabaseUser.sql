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
GRANT UPDATE, ALTER, DROP ON [abo, aboart] TO adminrole;
GRANT UPDATE,  DROP ON person TO adminrole;
GRANT adminrole to administration;


CREATE USER mitgliedsverwaltung FOR LOGIN casestudy WITH PASSWORD = 'mitgli';

CREATE ROLE mitglrole;
GRANT UPDATE, ALTER, DROP ON [person, anrede, ort, strasse, anbieter, nachfrager, rechnung, abo, aboart] TO mitglrole;
GRANT mitglrole TO mietgliederverwaltung

CREATE USER standplatzverwalter FOR LOGIN casestudy WITH PASSWORD = 'standpl';

CREATE ROLE standplrole;
GRANT UPDATE, ALTER ON [standort, standplatz, termin, rechnung] TO standplrole;
GRANT standplrole TO standplatzverwalter;

CREATE USER qualitaetsverantworlicher FOR LOGIN casestudy WITH PASSWORD = 'quali';

CREATE ROLE qualirole;
GRANT UPDATE, ALTER ON qualitaetsbewertung TO qualirole;
GRANT qualirole TO qualitaetsverantwortlischer;


