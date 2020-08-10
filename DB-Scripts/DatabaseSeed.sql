-- seed database

-- Datenbank mit Beispielsdaten füllen. 

-- erstellt am 20200701
-- Jennifer Mentner & Sven Gehring

-- geändert am xx.xx.xxxx
-------------------------------------------------
USE casestudy;
GO;

INSERT INTO anrede (id, bezeichnung)
    VALUES  (1, 'Herr'),
            (2, 'Frau');

INSERT INTO ort (plz, ort)
    VALUES  (8047, 'Zürich'),
            (8902, 'Urdorf'),
            (8804, 'Au');

INSERT INTO adresse (ort_id, strassenname, hausnummer)
    VALUES  ((SELECT id FROM ort WHERE plz = '8804'), 'seestrasse', '241'),
            ((SELECT id FROM ort WHERE plz = '8047'), 'untermoosstrasse', '17'),
            ((SELECt id FROM ort WHERE plz = '8902'), 'Weihermattstrasse', '2');

INSERT INTO person (anrede_id, adresse_id, vorname, nachname, geburtsdatum, email)
    VALUES  ((SELECT id FROM anrede WHERE bezeichnung = 'Herr'), (SELECT id FROM adresse WHERE strassenname = 'seestrasse'), 'Fritz', 'Meyer', '19750301', 'fritz.meyer@hotmail.com'),
            ((SELECT id FROM anrede WHERE bezeichnung = 'Frau'), (SELECT id FROM adresse WHERE strassenname = 'untermoosstrasse'), 'Jennifer', 'Mentner', '19971001', 'jennifermentner@hotmail.com'),
            ((SELECT id FROm anrede WHERE bezeichnung = 'Herr'), (SELECT id FROM adresse WHERE strassenname = 'Weihermattstrasse'), 'Sven', 'Gehring', '19970104', 'sven.gehring@hotmail.com');

INSERT INTO anbieter (person_id, aufnahmedatum, prov_aufnahmedatum, bonitaetspruefung, unterschrift)
    VALUES  ((SELECT id FROM person WHERE vorname = 'Jennifer'), '20200520', '20200201', 1, 1);

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

INSERT INTO qualitaetspruefer (person_id, lohn)
    VALUES  ((SELECT id FROM person WHERE vorname = 'Jennifer'), 5000);

INSERT INTO bewertung (anbieter_id, nachfrager_id, bezeichnung, score)
    VALUES  ((SELECT TOP 1 id FROM anbieter), (SELECT TOP 1 id FROM nachfrager), 'preis ok, aussehen sehr gut', 5);

INSERT INTO aboart (bezeichnung, gebuehr)
    VALUES  ('small', 400),
            ('big', 800),
            ('luxussmall', 1000);

INSERT INTO abo (anbieter_id, aboart_id)
    VALUES  ((SELECT TOP 1 id FROM anbieter), (SELECT id FROM aboart WHERE bezeichnung = CONVERT(VARCHAR, 'small')));

INSERT INTO standort (bezeichnung)
    VALUES  ('Zürich'),
            ('Aarau'),
            ('Bern'),
            ('Basel');

INSERT INTO standplatz (standort_id, standplatz_nr)
    VALUES  ((SELECT id FROM standort WHERE bezeichnung = 'Zürich'), 20),
            ((SELECT id FROM standort WHERE bezeichnung = 'Aarau'), 10);

INSERT INTO termin (standplatz_id, anbieter_id, datum)
    VALUES  ((SELECT id FROM standplatz WHERE standplatz_nr = 10), (SELECT TOP 1 id FROM anbieter), '20200822');

INSERT INTO rechnung (abo_id, anbieter_id, termin_id, rechnungs_nr, betrag)
    VALUES  ((SELECT TOP 1 id FROM abo), (SELECT TOP 1 id FROM anbieter), (SELECT TOP 1 id FROM termin), 123456789, 420);

INSERT INTO qualitaetsbewertung (anbieter_id, qualitaetspruefer_id, bezeichnung)
    VALUES ((SELECT TOP 1 id FROM anbieter), (SELECT TOP 1 id FROM qualitaetspruefer), 'prüfungen bestanden');
