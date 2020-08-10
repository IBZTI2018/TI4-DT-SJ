-- seed database

-- Datenbank mit Beispielsdaten füllen. 

-- erstellt am 01.07.2020
-- Jennifer Mentner & Sven Gehring

-- geändert am xx.xx.xxxx
-------------------------------------------------
use casestudy;
GO

insert into anrede (id, bezeichnung)
    VALUES  (1, 'Herr'),
            (2, 'Frau');
GO

insert into ort (id, plz, ort)
    VALUES  (1, 8047, 'Zürich'),
            (2, 8902, 'Urdorf'),
            (3, 8804, 'Au');
GO

insert into adresse (id, ort_id, strassenname, hausnummer)
    VALUES  (1, (SELECT id FROM ort WHERE plz = '8804'), 'seestrasse', '241'),
            (2, (SELECT id FROM ort WHERE plz = '8047'), 'untermoosstrasse', '17'),
            (3, (SELECt id FROM ort WHERE plz = '8902'), 'Weihermattstrasse', '2');
GO

insert into person (id, anrede_id, strasse_id, vorname, nachname, geburtsdatum, email)
    VALUES  (1, (SELECT id FROM anrede WHERE bezeichnung = 'Herr'), (SELECT id FROM adresse WHERE strassenname = 'seestrasse'), 'Fritz', 'Meyer', '01.03.1975', 'fritz.meyer@hotmail.com'),
            (2, (SELECT id FROM anrede WHERE bezeichnung = 'Frau'), (SELECT id FROM adresse WHERE strassenname = 'untermoosstrasse'), 'Jennifer', 'Mentner', '01.10.1997', 'jennifermentner@hotmail.com'),
            (3, (SELECT id FROm anrede WHERE bezeichnung = 'Herr'), (SELECT id FROM adresse WHERE strassenname = 'Weihermattstrasse'), 'Sven', 'Gehring', '04.01.1997', 'sven.gehring@hotmail.com');
GO

insert into anbieter (id, person_id, aufnahmedatum, prov_aufnahmedatum, bonitaetspruefung, unterschrift)
    VALUES  (1, (SELECT id FROM person WHERE vorname = 'Jennifer'), '20.5.2020', '01.02.2020', 'bestanden', 'eingereicht');
GO

insert into nachfrager (id, person_id)
    VALUES  (1, (SELECT id FROM person WHERE vorname = 'Fritz'));
GO

insert into qualitaetspruefer (id, person_id, lohn)
    VALUES  (1, (SELECT id FROM person WHERE vorname = 'Sven'), 5000);
GO

insert into bewertung (id, anbieter_id, nachfrager_id, bezeichnung, score)
    VALUES  (1, (SELECT id FROM anbieter WHERE person_id = '2'), (SELECT id FROM nachfrager WHERE person_id = '1'), 'preis ok, aussehen sehr gut', 5);
GO

insert into aboart (id, bezeichnung, gebuehr)
    VALUES  (1, 'small', 400),
            (2, 'big', 800),
            (3, 'luxussmall', 1000);
GO

insert into abo (id, anbieter_id, aboart_id)
    VALUES  (1, (SELECT id FROM anbieter WHERE person_id = '2'), (SELECT id FROM aboart WHERE bezeichnung = 'big'));
GO

insert into standort (id, bezeichnung)
    VALUES  (1, 'Zuerich'),
            (2, 'Aarau'),
            (3, 'Bern'),
            (4, 'Basel');
GO

insert into standplatz (id, standort_id, standplatz_nr)
    VALUES  (1, (SELECT id FROM standort WHERE bezeichnung = 'Zuerich'), 20),
            (2, (SELECT id FROM standort WHERE bezeichnung = 'Aarau'), 10);
GO

insert into termin (id, standplatz_id, anbieter_id, datum)
    VALUES  (1, (SELECT id FROM standplatz WHERE standort_id = '1'), (SELECT id FROM anbieter WHERE person_id = '2'), '22.08.2020');
GO

insert into rechnung (id, abo_id, anbieter_id, termin_id, rechnungs_nr, betrag)
    VALUES  (1, (SELECT id FROM abo WHERE aboart_id = '2'), (SELECT id FROM anbieter WHERE person_id = '2'), (SELECT id FROM termin WHERE datum = '22.08.2020'), 123456789, 420);
GO

insert into qualitaetsbewertung (id, anbieter_id, qualitaetspruefer_id, bezeichnung)
    VALUES (1, (SELECT id FROM anbieter WHERE person_id = '2'), (SELECT id FROM qualitaetspruefer WHERE person_id = '3'), 'prüfungen bestanden');
GO









