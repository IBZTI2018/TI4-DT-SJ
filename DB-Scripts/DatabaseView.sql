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

CREATE VIEW anbieterview AS
    SELECT * FROM person, adresse, anbieter, termin, standort, standplatz, bewertung, qualitaetsbewertung;
GO

CREATE VIEW nachfragerview AS
    SELECT * FROM nachfrager, adresse, berwertung;
GO

CREATE VIEW standplatzview AS
    SELECT * FROM standort, standplatz, termin, rechnung;
GO









    





