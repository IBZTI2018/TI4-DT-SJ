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
    VALUES  (1, (SELECT ort_id FROM ort WHERE plz = '8804'), 'seestrasse', '241'),
            (2, (SELECT ort_id FROM ort WHERE plz = '8047'), 'untermoosstrasse', '17'),
            (3, (SELECt ort_id FROM ort WHERE plz = '8902'), 'Weihermattstrasse', '2');
GO

insert into person (id, anrede_id, strasse_id, vorname, nachname, geburtsdatum, email)
    VALUES  (1, (SELECT anrede_id FROM anrede WHERE id = '1'), (SELECT adresse_id FROM strasse WHERE id= '1'), 'Fritz', 'Meyer', '01.03.1975', 'fritz.meyer@hotmail.com'),
            (2, (SELECT anrede_id FROM anrede WHERE id = '2'), (SELECT adresse_id FROM strasse WHERE id= '3'), 'Jennifer', 'Mentner', '01.10.1997', 'jennifermentner@hotmail.com'),
            (3, (SELECT anrede_id FROm anrede WHERE id = '1'), (SELECT adresse_id FROM strasse WHERE id= '2'), 'Sven', 'Gehring', '04.01.1997', 'sven.gehring@hotmail.com');
GO

insert into anbieter (id, person_id, aufnahmedatum, prov_aufnahmedatum, bonitaetspruefung, unterschrift)
    VALUES  (1, (SELECT person_id FROM person WHERE id = '2'), '20.5.2020', '01.02.2020', 'bestanden', 'eingereicht');
GO

insert into nachfrager (id, person_id)
    VALUES  (1, (SELECT person_id FROM person WHERE id = '1'));
GO

insert into qualitaetspruefer (id, person_id, lohn)
    VALUES  (1, (SELECT person_id FROM person WHERE id = '3'), 5000);
GO

insert into bewertung (id, anbieter_id, nachfrager_id, bezeichnung, score)
    VALUES  (1, (SELECT anbieter_id FROM anbieter WHERE id = '1'), (SELECT nachfrager_id FROM nachfrager WHERE id = '1'), 'preis ok, aussehen sehr gut', 5);
GO

insert into aboart (id, bezeichnung, gebuehr)
    VALUES  (1, 'small', 400),
            (2, 'big', 800),
            (3, 'luxussmall', 1000);
GO

insert into abo (id, anbieter_id, aboart_id)
    VALUES  (1, (SELECT anbieter_id FROM anbieter WHERE id = '1'), (SELECT aboart_id FROM aboart WHERE id = '2'));
GO

insert into standort (id, bezeichnung)
    VALUES  (1, 'Zürich'),
            (2, 'Aarau'),
            (3, 'Bern'),
            (4, 'Basel');
GO

insert into standplatz (id, standort_id, standplatz_nr)
    VALUES  (1, (SELECT standort_id FROM standort WHERE id = '1'), 20),
            (2, (SELECT standort_id FROM standort WHERE id = '2'), 10);
GO

insert into termin (id, standplatz_id, anbieter_id, datum)
    VALUES  (1, (SELECT standplatz_id FROM standplatz WHERE id = '1'), (SELECT anbieter_id FROM anbieter WHERE id = '1'), '22.08.2020');
GO

insert into rechnung (id, abo_id, anbieter_id, termin_id, rechnungs_nr, betrag)
    VALUES  (1, (SELECT abo_id FROM abo WHERE id = '1'), (SELECT anbieter_id FROM anbieter WHERE id = '1'), (SELECT termin_id FROM termin WHERE id = '1'), 123456789, 420);
GO

insert into qualitaetsbewertung (id, anbieter_id, qualitaetspruefer_id, bezeichnung)
    VALUES (1, (SELECT anbieter_id FROM anbieter WHERE id = '1'), (SELECT qualitaetspruefer_id FROM qualitaetspruefer WHERE id = '1'), 'prüfungen bestanden');
GO









