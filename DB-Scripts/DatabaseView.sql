-- view database

-- 

-- erstellt am 01.07.2020
-- Jennifer Mentner & Sven Gehring

-- geändert am xx.xx.xxxx
-------------------------------------------------

use casestudy;
GO


CREATE VIEW administration AS
    SELECT * FROM abo, aboart, qualitaetspruefer, anbieter, nachfrager;
GO

CREATE VIEW verwaltungmitglieder AS
    SELECT * FROM anbieter, nachfrager, person, rechnung
    GROUP BY person_id;
GO

CREATE VIEW qualitaetsverantwortlich AS
    SELECT * FROM qualitaetsbewertung;
GO
--no kein plan öb das so funktioniert
CREATE VIEW anbieterview AS
    SELECT  person.vorname, person.nachname, person.email,
            adresse.strassenname, 
            ort.plz, 
            termin.datum, 
            standplatz.standplatz_nr, standort.bezeichnung, 
            anbieter.bonitaetspruefung, anbieter.aufnahmedatum, 
            bewertung.bezeichnung, bewertung.score, 
            qualitaetsbewertung.bezeichnung 
    FROM person, adresse, ort, anbieter, termin, standort, standplatz, bewertung, qualitaetsbewertung;
GO

CREATE VIEW nachfragerview AS
    SELECT  person.vorname, person.nachname, person.email, 
            adresse.strassenname, 
            ort.plz, 
            bewertung.bezeichnung, bewertung.score 
    FROM person, adresse, ort, bewertung;
GO

CREATE VIEW standplatzview AS
    SELECT  standort.bezeichnung,
            standplatz.standplatz_nr,
            termin.datum,
            rechnung.betrag,
            rechnung.rechnungs_nr
    FROM standort, standplatz, termin, rechnung;
GO









    





