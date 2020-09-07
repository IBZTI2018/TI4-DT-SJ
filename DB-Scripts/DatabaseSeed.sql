---------------------------------------------------------------------------------------------------
-- IBZ TI4-ZH Datenbanktechnologie 3 Case-Study                   Jennifer Mentner, Sven Gehring --
--                                                                                               --
-- SQL-Skript zum Füllen der Datenbank mit Beispielsdaten für die UI-Demo                        --
---------------------------------------------------------------------------------------------------

-- Gemäss Dokumentation soll immer die Datenbank "casestudy" verwendet werden.
USE casestudy;


INSERT INTO anrede (id, bezeichnung) VALUES 
  (1, 'Herr'),
  (2, 'Frau'),
  (3, 'Divers'),
  (4, 'Non-Binär'),
  (5, 'Kampfhubschrauber');

INSERT INTO ort (plz, ort) VALUES
  (8047, 'Zürich'),
  (8902, 'Urdorf'),
  (8804, 'Au'),
  (8820, 'Wädenswil'),
  (8840, 'Einsiedeln');

INSERT INTO adresse (ort_id, strassenname, hausnummer) VALUES
  ((SELECT id FROM ort WHERE plz = 8804), 'Seestrasse', 241),
  ((SELECT id FROM ort WHERE plz = 8047), 'Untermoosstrasse', 17),
  ((SELECt id FROM ort WHERE plz = 8902), 'Weihermattstrasse', 2),
  ((SELECT id FROM ort WHERE plz = 8804), 'Rietliaustrasse', 4),
  ((SELECT id FROM ort WHERE plz = 8804), 'Seegüetli', 88),
  ((SELECT id FROM ort WHERE plz = 8047), 'Langstrasse', 217),
  ((SELECT id FROM ort WHERE plz = 8820), 'Bahnhofsgasse', 19),
  ((SELECT id FROM ort WHERE plz = 8820), 'Strehlgasse', 29);

INSERT INTO person (anrede_id, adresse_id, vorname, nachname, geburtsdatum, email) VALUES
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Herr'),
    (SELECT id FROM adresse WHERE strassenname = 'Seestrasse' AND hausnummer = 241),
    'Fritz',
    'Meyer',
    '19750301',
    'fritz.meyer@hotmail.com'
  ),
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Frau'),
    (SELECT id FROM adresse WHERE strassenname = 'Untermoosstrasse' AND hausnummer = 17),
    'Jennifer',
    'Mentner',
    '19971001',
    'jennifermentner@hotmail.com'
  ),
  (
    (SELECT id FROm anrede WHERE bezeichnung = 'Herr'),
    (SELECT id FROM adresse WHERE strassenname = 'Weihermattstrasse' AND hausnummer = 2),
    'Sven',
    'Gehring',
    '19970101',
    'sven.gehring@hotmail.com'
  ),
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Herr'),
    (SELECT id FROM adresse WHERE strassenname = 'Langstrasse' AND hausnummer = 217),
    'Günther',
    'Kusch',
    '19650827',
    'guterguenther@mail.de'
  ),
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Divers'),
    (SELECT id FROM adresse WHERE strassenname = 'Bahnhofsgasse'),
    'Jaqueline',
    'Müller',
    '20061001',
    'xxrawrxoxo20@msn.de'
  ),
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Herr'),
    (SELECT id FROM adresse WHERE strassenname = 'Strehlgasse' AND hausnummer = 29),
    'Diego',
    'Alto',
    '19720616',
    'eldiego@alto.ch'
  ),
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Herr'),
    (SELECT id FROM adresse WHERE strassenname = 'Seegüetli' AND hausnummer = 88),
    'Franz',
    'Becker',
    '19880718',
    'franzkanns@stromerbude.ch'
  ),
  (
    (SELECT id FROM anrede WHERE bezeichnung = 'Frau'),
    (SELECT id FROM adresse WHERE strassenname = 'Seestrasse' AND hausnummer = 241),
    'Tulpi',
    'Jäger',
    '19460808',
    'tulpi.jaeger@mail.de'
  );

INSERT INTO anbieter (person_id, aufnahmedatum, prov_aufnahmedatum, bonitaetspruefung, unterschrift, mitarbeiterbesuch) VALUES 
  ((SELECT id FROM person WHERE vorname = 'Jennifer' AND nachname = 'Mentner'), '20200520', '20200201', 1, 1, 1),
  ((SELECT id FROM person WHERE vorname = 'Sven' AND nachname = 'Gehring'), NULL, '20200521', 1, 1, 1),
  ((SELECT id FROM person WHERE vorname = 'Fritz' AND nachname = 'Meyer'), NULL, NULL, 1, 1, 0),
  ((SELECT id FROM person WHERE vorname = 'Günther' AND nachname = 'Kusch'), NULL, NULL, 0, 0, 0);

INSERT INTO nachfrager (person_id) VALUES
  ((SELECT id FROM person WHERE vorname = 'Jaqueline' AND nachname = 'Müller')),
  ((SELECT id FROM person WHERE vorname = 'Diego' AND nachname = 'Alto'));

INSERT INTO qualitaetspruefer (person_id, lohn) VALUES
  ((SELECT id FROM person WHERE vorname = 'Franz' AND nachname = 'Becker'), 20.50),
  ((SELECT id FROM person WHERE vorname = 'Tulpi' AND nachname = 'Jäger'), 25.50);

INSERT INTO bewertung (anbieter_id, nachfrager_id, bezeichnung, score) VALUES
  ((SELECT TOP 1 id FROM anbieter), (SELECT TOP 1 id FROM nachfrager), 'Preis ok, Aussehen sehr gut', 5.0);

INSERT INTO aboart (bezeichnung, gebuehr) VALUES
  ('Small', 40.0),
  ('Medium', 60.0),
  ('Large', 80.0),
  ('X-Large', 100.0);

INSERT INTO abo (anbieter_id, aboart_id, abschlussdatum) VALUES
  (
    (SELECT TOP 1 id FROM anbieter),
    (SELECT id FROM aboart WHERE bezeichnung = CONVERT(VARCHAR, 'Large')),
    GETDATE()
  );

INSERT INTO standort (bezeichnung) VALUES
  ('Hallenstadion Zürich'),
  ('Marktplatz Aarau'),
  ('Auäplatz Bern'),
  ('Bünzligasse Basel');

INSERT INTO standplatz (standort_id, standplatz_nr) VALUES
  ((SELECT id FROM standort WHERE bezeichnung = 'Hallenstadion Zürich'), 20),
  ((SELECT id FROM standort WHERE bezeichnung = 'Bünzligasse Basel'), 10);

INSERT INTO termin (standplatz_id, anbieter_id, datum) VALUES
  (
    (SELECT id FROM standplatz WHERE standplatz_nr = 10),
    (SELECT TOP 1 id FROM anbieter),
    '20200822'
  );

INSERT INTO rechnung (abo_id, anbieter_id, termin_id, rechnungs_nr, betrag) VALUES
  (
    NULL,
    (SELECT TOP 1 id FROM anbieter),
    (SELECT TOP 1 id FROM termin),
    123456789,
    10.0
  ),
  (
    (SELECT TOP 1 id FROM abo),
    (SELECT TOP 1 id FROM anbieter),
    NULL,
    123456789,
    80.0
  );

INSERT INTO qualitaetsbewertung (anbieter_id, qualitaetspruefer_id, bezeichnung) VALUES
  (
    (SELECT TOP 1 id FROM anbieter),
    (SELECT TOP 1 id FROM qualitaetspruefer),
    'Prüfungen bestanden!'
  ),
  (
    (SELECT TOP 1 id FROM anbieter),
    (SELECT TOP 1 id FROM qualitaetspruefer),
    'Sieht immer noch alles gut aus!'
  );
