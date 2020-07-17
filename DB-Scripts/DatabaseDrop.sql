-- drop database

-- Datenbank löschen, wenn diese Bereits existiert. 

-- erstellt am 11.06.2020
-- Jennifer Mentner & Sven Gehring

-- geändert am xx.xx.xxxx
-------------------------------------------------

USE casestudy;
GO;

ALTER ROLE casestudy_role_development DROP MEMBER casestudy;
DROP ROLE IF EXISTS casestudy_role_development;

ALTER ROLE casestudy_role_administration DROP MEMBER casestudy_administration;
DROP ROLE IF EXISTS casestudy_role_administration;

ALTER ROLE casestudy_role_mitgliedsverwaltung DROP MEMBER casestudy_mitgliederverwalter;
DROP ROLE IF EXISTS casestudy_role_mitgliedsverwaltung;

ALTER ROLE casestudy_role_standplatzverwaltung DROP MEMBER casestudy_standplatzverwalter;
DROP ROLE IF EXISTS casestudy_role_standplatzverwaltung;

ALTER ROLE casestudy_role_qualitaetspruefung DROP MEMBER casestudy_qualitaetsverantwortlicher;
DROP ROLE IF EXISTS casestudy_role_qualitaetspruefung;

DROP TABLE qualitaetsbewertung;
DROP TABLE bewertung;
DROP TABLE nachfrager;
DROP TABLE rechnung;
DROP TABLE termin;
DROP TABLE qualitaetspruefer;
DROP TABLE abo;
DROP TABLE aboart;
DROP TABLE anbieter;
DROP TABLE person;
DROP TABLE standplatz;
DROP TABLE standort;
DROP TABLE adresse;
DROP TABLE ort;
DROP TABLE anrede;
