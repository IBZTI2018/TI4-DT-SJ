---------------------------------------------------------------------------------------------------
-- IBZ TI4-ZH Datenbanktechnologie 3 Case-Study                   Jennifer Mentner, Sven Gehring --
--                                                                                               --
-- SQL-Skript zur Löschung der Datenbank für das Konzept "Freier Markt im Kleinen"               --
--                                                                                               --
-- Dieses Skript lösch sämtliche Tabellen, Views und Indizes                                     --
---------------------------------------------------------------------------------------------------

-- Gemäss Dokumentation soll immer die Datenbank "casestudy" verwendet werden.
USE casestudy;

---------------------------------------------------------------------------------------------------
-- Löschung von Rollen und Entzug von Berechtungen                                               --
---------------------------------------------------------------------------------------------------
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

---------------------------------------------------------------------------------------------------
-- Löschung der Tabellenstruktur                                                                 --
---------------------------------------------------------------------------------------------------

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

---------------------------------------------------------------------------------------------------
-- Löschung von Views                                                                            --
---------------------------------------------------------------------------------------------------

DROP VIEW view_anbieter;
DROP VIEW view_nachfrager;
DROP VIEW view_qualitaetspruefer;
DROP VIEW view_adresse;
DROP VIEW view_person;
