---------------------------------------------------------------------------------------------------
-- IBZ TI4-ZH Datenbanktechnologie 3 Case-Study                   Jennifer Mentner, Sven Gehring --
--                                                                                               --
-- SQL-Skript zur Erstellung der Datenbank für das Konzept "Freier Markt im Kleinen"             --
--                                                                                               --
-- Dieses Skript erstellt sämtliche Tabellen, welche notwendig sind, um das Projekt in dem       --
-- dokumentierten Umfang abzubilden, sowie deren Beziehungen. Es erstellt zudem die vorab auf-   --
-- geteilten Benutzerrollen, nach welchen das Interface gruppiert ist, sowie sämtliche Views und --
-- Indizes, um Abfragen von der UI einfacher und effizienter zu gestalten.                       --
---------------------------------------------------------------------------------------------------


-- Gemäss Dokumentation soll immer die Datenbank "casestudy" verwendet werden.
USE casestudy;


---------------------------------------------------------------------------------------------------
-- Erstellung der Tabellenstruktur                                                               --
---------------------------------------------------------------------------------------------------

-- In der Anrede Tabellen werden Anreden mit einer ID und einer Bezeichnung gespeichert.
-- Es soll eine fixe Auswahl an Anreden für Personen zur Verfügung stehen
CREATE TABLE anrede (
  id INT PRIMARY KEY,
  bezeichnung VARCHAR(20) NULL
);

-- In der Ort Tabelle werden Orte mit ihrer Postleitzahl, sowie ihrem Ortsnamen gespeichert.
-- Die ID eines Orts wird mittels Identity automatisch inkrementiert.
CREATE TABLE ort(
  id INT PRIMARY KEY IDENTITY(1, 1),
  plz INT NOT NULL,
  ort VARCHAR(255) NOT NULL,

  CONSTRAINT uq_ort_plz UNIQUE(plz),
  CONSTRAINT c_plz_range CHECK(plz > 0 AND plz < 10000)
);

-- In der Adress-Tabelle werden Adressen, zugehörig zu einem Ort, mit ihrem Strassennamen sowie
-- einer Hausnummer gespeichert. Die ID einer Adresse wird mittels Identity automatisch inkrementiert.
CREATE TABLE adresse(
  id INT PRIMARY KEY IDENTITY(1, 1),
  ort_id INT FOREIGN KEY REFERENCES ort(id) NOT NULL,
  strassenname VARCHAR(255) NOT NULL,
  hausnummer INT NOT NULL
);

-- In der Personen-Tabelle werden Personen mit einer zugehörigen Anrede und einer zugehörigen Adresse
-- gespeichert. Desweiteren werden ihr Vor- und Nachname, die E-Mail Adresse, sowie optional auch das
-- Geburtsdatum gespeichert. Die ID einer Person wird mittels Identity automatisch inkrementiert.
CREATE TABLE person (
  id INT PRIMARY KEY IDENTITY(1, 1),
  anrede_id INT FOREIGN KEY REFERENCES anrede(id) NOT NULL,
  adresse_id INT FOREIGN KEY REFERENCES adresse(id) NOT NULL,
  vorname VARCHAR(255) NOT NULL,
  nachname VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  geburtsdatum DATE NOT NULL,

  CONSTRAINT u_person_email UNIQUE(email)
);

-- In der Anbieter-Tabelle werden sämtliche Anbieter mit ihren zugehörigen Personendaten gespeichert.
-- Es werden Aufnahmedatum, Provisorisches Aufnahmedatum, sowie die Vollständigkeit der Bonitäts-
-- prüfung und der Unterschrift gespeichert. Die ID eines Anbieters wird mittels Identity
-- automatisch inkrementiert.
CREATE TABLE anbieter (
  id INT PRIMARY KEY IDENTITY(1, 1),
  person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL,
  aufnahmedatum DATE NULL ,
  prov_aufnahmedatum DATE NULL,
  bonitaetspruefung BIT NOT NULL DEFAULT 0,
  unterschrift BIT NOT NULL DEFAULT 0,
  mitarbeiterbesuch BIT NOT NULL DEFAULT 0,

  -- Provisorisches Aufnahmedatum und Aufnahmedatum müssen 2 Monate auseinander liegen
  CONSTRAINT ck_anbieter_daten CHECK (DATEDIFF(month, prov_aufnahmedatum, aufnahmedatum) >= 2)

  -- Check constraint für Aufnahmebedingungen wird am Ende der Tabellenerstellung definiert.
);

-- In der Abo-Art-Tabelle werden alle möglichen Arten von Abonnements, welche an Anbieter verkauft
-- werden können mit ihrer Bezeichnung, sowie ihrer Gebür, gepsichert. Die ID einer Abo-Art wird
-- mittels Identity automatisch inkrementiert.
CREATE TABLE aboart (
  id INT PRIMARY KEY IDENTITY(1, 1),
  bezeichnung VARCHAR(255) NOT NULL,
  gebuehr FLOAT NOT NULL,
  monate INT NOT NULL,
  standorte INT NOT NULL

  CONSTRAINT u_bezeichnung UNIQUE(bezeichnung)
);

-- In der Abo-Tabelle werden von Anbietern abgeschlossene Abonnemente gespeichert. Sie verbindet die
-- Kosten einer Abo-Art mit dem Anbieter, welche dieses Abo bezogen hat. Die ID eines Abos wird
-- mittels Identity automatisch inkrementiert.
CREATE TABLE abo (
  id INT PRIMARY KEY IDENTITY(1, 1),
  anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
  aboart_id INT FOREIGN KEY REFERENCES aboart(id) NOT NULL,
  abschlussdatum DATE NOT NULL,
);

-- In der Standorte-Tabelle werden sämtliche vom Team verwalteten Standorte mit einer Bezeichnung
-- gespeichert. Die ID eines Standorts wird mittels Identity automatisch inkrementiert.
CREATE TABLE standort (
  id INT PRIMARY KEY IDENTITY(1, 1),
  bezeichnung VARCHAR(255) NOT NULL
);

-- In der Standplatz-Tabelle werden sämtliche vom Team verwalteten Standplätze mit einem zugehörigen
-- Standort, sowie einer Standplatz-Nummer gespeichert. Die ID eines Standplatzes wird mittels
-- Identity automatisch inkrementiert.
CREATE TABLE standplatz (
  id INT PRIMARY KEY IDENTITY(1, 1),
  standort_id INT FOREIGN KEY REFERENCES standort(id) NOT NULL,
  standplatz_nr INT NOT NULL,

  CONSTRAINT uq_ort_nr UNIQUE(standort_id, standplatz_nr)
);

-- In der Termin-Tabelle werden sämtliche Termine eines Anbieters bzw. eines Standplatzes mit dem
-- einem entsprechenden Datum gespeichert. Die ID eines Termins wird mittels Identity automatisch
-- inkrementiert.
CREATE TABLE termin (
  id INT PRIMARY KEY IDENTITY(1, 1),
  standplatz_id INT FOREIGN KEY REFERENCES standplatz(id) NOT NULL,
  anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
  datum DATE NOT NULL
);

-- In der Rechnungs-Tabelle werden sämtliche Rechnungen eines Anbieters für entweder Abonnemente
-- oder Termine mit der entsprechenden Rechnungs-Nummer, sowie dem Betrag gespeichert. Der Betrag
-- wird hier auch für Abos sepparat vermerkt, damit Mitarbeiter Anbietern ggf. Rabatte auf die
-- üblichen Abo-Preise geben können. Die ID einer Rechnung wird mittels Identity automatisch
-- inkrementiert.
CREATE TABLE rechnung (
  id INT PRIMARY KEY IDENTITY(1, 1),
  abo_id INT FOREIGN KEY REFERENCES abo(id) NULL,
  anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
  termin_id INT FOREIGN KEY REFERENCES termin(id) NULL,
  rechnungs_nr VARCHAR(50) NOT NULL,
  betrag FLOAT NOT NULL,

  -- Rechnungen müssen entweder einem Termin oder einem Abo zugewiesen sein
  CONSTRAINT ck_rechnung_fuer CHECK (
  (abo_id IS NULL AND termin_id IS NOT NULL) OR
  (abo_id IS NOT NULL AND termin_id IS NULL)
  )
);

-- In der Nachfrager-Tabelle werden sämtliche Nachfrager mit ihren zugehörigen Personendaten
-- abgelegt. Im Moment hat dies keine weitere Funktion, ausser das sammeln von interessierten
-- Personen für Informations-Rundmails. Die ID eines Nachfragers wird mittels Identity automatisch
-- inkrementiert.
CREATE TABLE nachfrager(
  id INT PRIMARY KEY IDENTITY(1, 1),
  person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL
);

-- In der Bewertungstabelle werden Kundenbewertungen von Anbietern durch Nachfrager gespeichert.
-- Dabei kann stets ein text sowie ein score abgegeben werden. Der Score muss zwischen 0 und 10
-- liegen. Die ID einer Bewertung wird mittels Identity automatisch inkrementiert.
CREATE TABLE bewertung (
  id INT PRIMARY KEY IDENTITY(1, 1),
  anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
  nachfrager_id INT FOREIGN KEY REFERENCES nachfrager(id) NOT NULL,
  bezeichnung TEXT NULL,
  score FLOAT NULL,

  -- Score muss zwischen 0 und 10 liegen
  CONSTRAINT c_score_range CHECK ((score > 0.0) AND (score < 10.0))
);

-- In der Qualitätsprüfer-Tabelle werden sämtliche Qualitätsprüfer, welche für das Projekt tätig
-- sind, mit deren Personendaten abgelegt. Die ID eines Qualitätsprüfers wird mittels Identity
-- automatisch inkrementiert.
CREATE TABLE qualitaetspruefer (
  id INT PRIMARY KEY IDENTITY(1, 1),
  person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL,
  lohn FLOAT NULL
);

-- In der Qualitätsbewertungs-Tabelle werden Qualitätsberichte von Prüfern für entsprechende
-- Anbieter abgelegt. So wird entschieden, ob ein Anbieter gewisse Bedingungen erfüllt.
-- Die ID einer Qualitätsbewertung wird mittels Identity automatisch inkrementiert.
CREATE TABLE qualitaetsbewertung (
  id INT PRIMARY KEY IDENTITY(1, 1),
  anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
  qualitaetspruefer_id INT FOREIGN KEY REFERENCES qualitaetspruefer(id) NOT NULL,
  bezeichnung TEXT NULL,
  datum DATE NOT NULL,
  stunden FLOAT NOT NULL
);

GO

---------------------------------------------------------------------------------------------------
-- Erstellung von UDFs für komplexere CHECK queries                                              --
---------------------------------------------------------------------------------------------------

-- Gibt das "Level" eines Anbieters zurück
-- 0 = In Abklärung
-- 1 = Provisorisch aufgenommen
-- 2 = Aufgenommenes Mitglied
CREATE FUNCTION dbo.levelVonAnbieter(@anbieterId int) RETURNS int AS
  BEGIN
    DECLARE @level int;
    SELECT @level = (
      (CASE WHEN aufnahmedatum IS NOT NULL THEN 1 ELSE 0 END) +
      (CASE WHEN prov_aufnahmedatum IS NOT NULL THEN 1 ELSE 0 END)
    ) FROM anbieter WHERE id = @anbieterId;
    RETURN @level;
  END;

GO

-- Gibt die Anzahl vergangene Qualitätsbewertungen für einen Anbieter zurück
CREATE FUNCTION dbo.anzahlChecksFuerAnbieter(@anbieterId int) RETURNS int AS
  BEGIN
    DECLARE @nqbew int;
    SELECT @nqbew = COUNT(*) FROM qualitaetsbewertung
      WHERE anbieter_id = @anbieterId AND datum < GETDATE();
    RETURN @nqbew;
  END;

GO

-- Gibt die Standort-IDs aus, welche momentan von einem bestimmten Anbieter gemietet werden
CREATE FUNCTION dbo.standorteVonAnbieter(@anbieterId int) RETURNS table AS
  RETURN (
    SELECT standort.id FROM termin
      INNER JOIN standplatz
        ON standplatz.id = termin.standplatz_id
      INNER JOIN standort
        ON standort.id = standplatz.standort_id
      WHERE anbieter_id = @anbieterId
  );

GO

-- Gibt das Standort-Kontingent eines Anbieters basierend auf seinen laufenden Abos aus
CREATE FUNCTION dbo.standorteFuerAnbieter(@anbieterId int, @terminDatum date) RETURNS int AS
  BEGIN
    DECLARE @nstaa int;
    SELECT @nstaa = kontingent.standorte FROM (
      SELECT
        MAX(standorte) as standorte,
        DATEADD(month, MAX(monate), MAX(abschlussdatum)) as bis
        FROM abo
          INNER JOIN aboart
            ON aboart.id = abo.aboart_id
          WHERE anbieter_id = @anbieterId
      ) kontingent WHERE kontingent.bis >= @terminDatum;
    RETURN @nstaa;
  END;

GO

---------------------------------------------------------------------------------------------------
-- Erstellung von komplexeren CHECK queries mit UDF Unterstützung                                --
---------------------------------------------------------------------------------------------------

-- Fortschritt des Aufnahmeprozesses eines Anbieters
ALTER TABLE anbieter ADD CONSTRAINT ck_anbieter CHECK (
  -- Noch nicht aufgenommenes Mitglied hat keine Daten hinterlegt
  (
    aufnahmedatum IS NULL AND
    prov_aufnahmedatum IS NULL
  ) OR

  -- Provisorische Aufnahme kann nur eingetragen werden, wenn die
  -- Bonitätsprüfung und Unterschrift OK sind
  (
    aufnahmedatum IS NULL AND
    prov_aufnahmedatum IS NOT NULL AND
    bonitaetspruefung = 1 AND
    unterschrift = 1 AND
    mitarbeiterbesuch = 1
  ) OR

  -- Finale Aufnahme kann nur eingetragen sein, wenn das Mitglied
  -- bereits provisorisch aufgenommen ist und mindestens 2 Q-Bewertungen hat.
  (
    aufnahmedatum IS NOT NULL AND
    prov_aufnahmedatum IS NOT NULL AND
    bonitaetspruefung = 1 AND
    unterschrift = 1 AND
    mitarbeiterbesuch = 1 AND
    dbo.anzahlChecksFuerAnbieter(id) >= 2
  )
);

-- Erstellung eines Termins abhängig von der Aufnahme eines Anbieters
ALTER TABLE termin ADD CONSTRAINT ck_termin_anbieter_datum CHECK(
  -- Entweder Anbieter ist provisorisch aufgenommen und bucht 2 Monate im voraus
  (
    dbo.levelVonAnbieter(anbieter_id) = 1 AND
    DATEDIFF(month, GETDATE(), datum) >= 2
  ) OR

  -- Oder Anbieter ist bereits Mitglied und kann buchen wann immer er will
  (
    dbo.levelVonAnbieter(anbieter_id) = 2
  )
);

GO

---------------------------------------------------------------------------------------------------
-- Erstellung von Indizes für schnellere Abfragen                                                --
---------------------------------------------------------------------------------------------------

CREATE INDEX i_fk_adresse_ort ON adresse(ort_id);
CREATE INDEX i_fk_person_andrede ON person(anrede_id);
CREATE INDEX i_fk_person_adresse ON person(adresse_id);
CREATE INDEX i_fk_anbieter_person ON anbieter(person_id);
CREATE INDEX i_fk_abo_anbieter ON abo(anbieter_id);
CREATE INDEX i_fk_abo_aboart ON abo(aboart_id);
CREATE INDEX i_fk_standplatz_standort ON standplatz(standort_id);
CREATE INDEX i_fk_termin_standplatz ON termin(standplatz_id);
CREATE INDEX i_fk_termin_anbieter ON termin(anbieter_id);
CREATE INDEX i_fk_rechnung_anbieter ON rechnung(anbieter_id);
CREATE INDEX i_fk_rechnung_termin ON rechnung(termin_id);
CREATE INDEX i_fk_rechnung_abo ON rechnung(abo_id);
CREATE INDEX i_fk_nachfrager_person ON nachfrager(person_id);
CREATE INDEX i_fk_bewertung_anbieter ON bewertung(anbieter_id);
CREATE INDEX i_fk_bewertung_nachfrager ON bewertung(nachfrager_id);
CREATE INDEX i_fk_qualitaetspruefer_person ON qualitaetspruefer(person_id);
CREATE INDEX i_fk_qualitaetsbewertung_anbieter ON qualitaetsbewertung(anbieter_id);
CREATE INDEX i_fk_qualitaetsbewertung_qualitaetspruefer ON qualitaetsbewertung(qualitaetspruefer_id);

GO

---------------------------------------------------------------------------------------------------
-- Erstellung von Views für einfachere UI-Abfragen                                               --
---------------------------------------------------------------------------------------------------

-- Das Anbieter View wird verwendet um einen Anbieter mitsamt seinen Personendaten, sowie seinen
-- Metadaten des Anmeldungsprozesses abzubilden. Auch die Anzahl Q-Bewertungen wird ausgegeben.
CREATE VIEW view_anbieter AS
  SELECT 
    anbieter.id,
    anrede.bezeichnung AS anrede,
    person.vorname,
    person.nachname,
    adresse.strassenname,
    adresse.hausnummer,
    ort.plz,
    ort.ort,
    person.geburtsdatum,
    person.email,
    anbieter.aufnahmedatum,
    anbieter.prov_aufnahmedatum,
    anbieter.bonitaetspruefung,
    anbieter.mitarbeiterbesuch,
    anbieter.unterschrift,
    (SELECT COUNT(*) FROM qualitaetsbewertung 
      WHERE qualitaetsbewertung.anbieter_id = anbieter.id
    ) AS qbewertungen
  FROM anbieter
    INNER JOIN person
      ON person.id = anbieter.person_id
    INNER JOIN adresse
      ON adresse.id = person.adresse_id
    INNER JOIN ort
      ON ort.id = adresse.ort_id
    INNER JOIN anrede
      ON anrede.id = person.anrede_id;

GO

-- Das Nachfragen View wird verwendet um einen Nachfragen mitsamt seinen Personendaten abzubilden.
CREATE VIEW view_nachfrager AS
  SELECT 
    nachfrager.id,
    anrede.bezeichnung AS anrede,
    person.vorname,
    person.nachname,
    adresse.strassenname,
    adresse.hausnummer,
    ort.plz,
    ort.ort,
    person.geburtsdatum,
    person.email
  FROM nachfrager
    INNER JOIN person
      ON person.id = nachfrager.person_id
    INNER JOIN adresse
      ON adresse.id = person.adresse_id
    INNER JOIN ort
      ON ort.id = adresse.ort_id
    INNER JOIN anrede
      ON anrede.id = person.anrede_id;

GO

-- Das Q-Prüfer View wird verwendet um einen Q-Prüfer mitsamt seinen Personendaten, sowie seinem
-- Lohn abzubilden. Momentan wird immer der gesamte erwirtschaftete Betrag ausgegeben, je nach
-- zukünftiger Vorgabe des Auftraggebers, könnte dies aber noch angepasst werden.
CREATE VIEW view_qualitaetspruefer AS
  SELECT 
    qualitaetspruefer.id,
    anrede.bezeichnung AS anrede,
    person.vorname,
    person.nachname,
    qualitaetspruefer.lohn,
    adresse.strassenname,
    adresse.hausnummer,
    ort.plz,
    ort.ort,
    person.geburtsdatum,
    person.email,
    (
      qualitaetspruefer.lohn *
      (
        SELECT SUM(stunden) FROM qualitaetsbewertung
          WHERE qualitaetspruefer_id = qualitaetspruefer.id
      )
    ) AS gesamtlohn
  FROM qualitaetspruefer
    INNER JOIN person
      ON person.id = qualitaetspruefer.person_id
    INNER JOIN adresse
      ON adresse.id = person.adresse_id
    INNER JOIN ort
      ON ort.id = adresse.ort_id
    INNER JOIN anrede
      ON anrede.id = person.anrede_id;

GO


-- Das Person View wird verwendet um einen Person mitsamt Anrede und Adresse auszugeben.
CREATE VIEW view_person AS
  SELECT 
    person.id,
    anrede.bezeichnung AS anrede,
    person.vorname,
    person.nachname,
    adresse.strassenname,
    adresse.hausnummer,
    ort.plz,
    ort.ort,
    person.geburtsdatum,
    person.email
  FROM person
    INNER JOIN adresse
      ON adresse.id = person.adresse_id
    INNER JOIN ort
      ON ort.id = adresse.ort_id
    INNER JOIN anrede
      ON anrede.id = person.anrede_id;

GO

-- Das Adresse View wird verwendet um einen Adresse mitsamt Ortsinformationen auszugeben.
CREATE VIEW view_adresse AS
  SELECT 
    adresse.id,
    adresse.strassenname,
    adresse.hausnummer,
    ort.plz,
    ort.ort
  FROM adresse
    INNER JOIN ort
      ON ort.id = adresse.ort_id;

GO

-- Das Q-Bewertung View wird verwendet um einen Q-Bewertung mitsamt Personendaten der
-- zugehörigen Anbieter und Q-Prüfer auszugeben.
CREATE VIEW view_qbewertung AS
  SELECT
    qualitaetsbewertung.id,
    aperson.vorname,
    aperson.nachname,
    qperson.nachname AS pruefer,
    qualitaetsbewertung.datum,
    qualitaetsbewertung.stunden,
    qualitaetsbewertung.bezeichnung
  FROM qualitaetsbewertung
    INNER JOIN qualitaetspruefer
      ON qualitaetspruefer.id = qualitaetsbewertung.qualitaetspruefer_id
    INNER JOIN person AS qperson
      ON qperson.id = qualitaetspruefer.person_id
    INNER JOIN anbieter
      ON anbieter.id = qualitaetsbewertung.anbieter_id
    INNER JOIN person AS aperson
      ON aperson.id = anbieter.person_id 

GO

-- Das Abo View wird verwendet um ein Abo mitsamt Personendaten des Anbieters und Abo-Art auszugeben.
CREATE VIEW view_abo AS
  SELECT
    abo.id,
    aperson.vorname,
    aperson.nachname,
    aboart.bezeichnung AS abotyp,
    abo.abschlussdatum
  FROM abo
    INNER JOIN anbieter
      ON anbieter.id = abo.anbieter_id
    INNER JOIN person AS aperson
      ON aperson.id = anbieter.person_id 
    INNER JOIN aboart
      ON aboart.id = abo.aboart_id;
GO

-- Das Rechnung View wird verwendet um einen Rechnung mitsamt den Personendaten des zugehörigen
-- Anbieters sowie entwerder der zugehörigen Abo-Art oder dem Zugehörigen Termindatum auszugeben.
CREATE VIEW view_rechnung AS
  SELECT 
    rechnung.id,
    rechnung.rechnungs_nr,
    rechnung.betrag,
    aperson.vorname,
    aperson.nachname,
    aboart.bezeichnung AS abo,
    termin.datum AS termin
  FROM rechnung
    LEFT OUTER JOIN anbieter
      ON anbieter.id = rechnung.anbieter_id
    LEFT OUTER JOIN person AS aperson
      ON aperson.id = anbieter.person_id
    LEFT OUTER JOIN abo
      ON abo.id = rechnung.abo_id
    LEFT OUTER JOIN aboart
      ON aboart.id = abo.aboart_id
    LEFT OUTER JOIN termin
      ON termin.id = rechnung.termin_id;

GO

-- Das Standplatz View wird verwendet um einen Standplatz mit zugehörigem Standortnamen anzuzeigen
CREATE VIEW view_standplatz AS
  SELECT
    standplatz.id,
    standplatz.standplatz_nr,
    standort.bezeichnung AS standort
  FROM standplatz
    INNER JOIN standort
      ON standort.id = standplatz.standort_id;

GO

-- Das Termin View wird verwendet um einen Termin samt Anbieter und Standplatz-Infos anzuzeigen
CREATE VIEW view_termin AS
  SELECT
    termin.id,
    termin.datum,
    aperson.vorname,
    aperson.nachname,
    standort.bezeichnung AS standort,
    standplatz.standplatz_nr
  FROM termin
    INNER JOIN anbieter
      ON anbieter.id = termin.anbieter_id
    INNER JOIN person AS aperson
      ON aperson.id = anbieter.person_id
    INNER JOIN standplatz
      ON standplatz.id = termin.standplatz_id
    INNER JOIN standort
      ON standort.id = standplatz.standort_id;

GO

---------------------------------------------------------------------------------------------------
-- Erstellung von Rollen und Vergabe von Berechtungen                                            --
---------------------------------------------------------------------------------------------------

-- Der Benutzer Case-Study soll gemäss Dokumentation vor der Erstellung der Tabellen erstellt werden.
-- In der Entwicklungs-Umgebung wird dies für einfache Änderungen an der Datenbank verwendet.
-- Im Produktiven Einsatz sollte dieser Abschnitt nicht verwendt werden!
CREATE ROLE casestudy_role_development;

GRANT SELECT, INSERT, UPDATE, DELETE ON anrede TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON ort TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON adresse TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON person TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON anbieter TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON aboart TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON abo TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON standort TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON standplatz TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON termin TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON rechnung TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON nachfrager TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON bewertung TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON qualitaetspruefer TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON qualitaetsbewertung TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_anbieter TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_nachfrager TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_qualitaetspruefer TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_qbewertung TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_adresse TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_person TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_rechnung TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_abo TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_standplatz TO casestudy_role_development;
GRANT SELECT, INSERT, UPDATE, DELETE ON view_termin TO casestudy_role_development;

ALTER ROLE casestudy_role_development ADD MEMBER casestudy;

-- Der Benutzer der Administration kann gemäss Dokumentation Orte, Adressen, Abo-Arten, Abos und
-- Personendaten bearbeiten. Die Administration hat so die Möglichkeit sämtliche Daten, welche von
-- Mitarbeitenden erfasst und bearbeitet werden zu bearbeiten und zu berichtigen.
CREATE ROLE casestudy_role_administration;

GRANT SELECT ON anrede TO casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON ort TO casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON adresse to casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON abo TO casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON aboart TO casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON person TO casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON rechnung TO casestudy_role_administration;
GRANT SELECT, INSERT, UPDATE, DELETE ON qualitaetspruefer TO casestudy_role_administration;
GRANT SELECT ON anbieter TO casestudy_role_administration;
GRANT SELECT ON nachfrager TO casestudy_role_administration;
GRANT SELECT ON termin TO casestudy_role_administration;
GRANT SELECT ON standplatz TO casestudy_role_administration;
GRANT SELECT ON standort TO casestudy_role_administration;
GRANT SELECT ON view_anbieter TO casestudy_role_administration;
GRANT SELECT ON view_nachfrager TO casestudy_role_administration;
GRANT SELECT ON view_person TO casestudy_role_administration;
GRANT SELECT ON view_adresse TO casestudy_role_administration;
GRANT SELECT ON view_qualitaetspruefer TO casestudy_role_administration;
GRANT SELECT ON view_rechnung TO casestudy_role_administration;
GRANT SELECT ON view_abo TO casestudy_role_administration;

ALTER ROLE casestudy_role_administration ADD MEMBER casestudy_administration;

-- Der Benutzer der Mitgliederverwaltung kann Orte, Adressen und Personen, sowie entsprechend
-- Anbieter und Nachfrager erfassen. Er kann Anbieter und Nachfrager verändern, um deren Fort-
-- schritt im Anmeldungsprozess anzupassen. Zudem kann er Rechnungen und Abonnemente erfassen.

CREATE ROLE casestudy_role_mitgliedsverwaltung;

GRANT SELECT ON anrede TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT ON ort TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT ON person TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT ON adresse TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT, UPDATE ON anbieter TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT, UPDATE ON nachfrager TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT ON rechnung TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT, INSERT ON abo TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON aboart TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON qualitaetsbewertung TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON view_anbieter TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON view_adresse TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON view_nachfrager TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON view_abo TO casestudy_role_mitgliedsverwaltung;
GRANT SELECT ON view_rechnung TO casestudy_role_mitgliedsverwaltung;

ALTER ROLE casestudy_role_mitgliedsverwaltung ADD MEMBER casestudy_mitgliederverwalter;

-- Der Benutzer für die Standplatzverwaltung kann Standorte und Standplätze erfassen, sowie
-- Termine erfassen und bearbeiten. Sie können ebenfalls Rechnungen erstellen.

CREATE ROLE casestudy_role_standplatzverwaltung;

GRANT SELECT, INSERT, UPDATE, DELETE ON standort TO casestudy_role_standplatzverwaltung;
GRANT SELECT, INSERT, UPDATE, DELETE ON standplatz TO casestudy_role_standplatzverwaltung;
GRANT SELECT, INSERT, UPDATE, DELETE ON termin TO casestudy_role_standplatzverwaltung;
GRANT SELECT, INSERT  ON rechnung TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON view_standplatz TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON view_rechnung TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON view_termin TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON view_anbieter TO casestudy_role_standplatzverwaltung;
GRANT EXECUTE ON dbo.levelVonAnbieter TO casestudy_role_standplatzverwaltung;
GRANT EXECUTE ON dbo.standorteFuerAnbieter TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON dbo.standorteVonAnbieter TO casestudy_role_standplatzverwaltung;

ALTER ROLE casestudy_role_standplatzverwaltung ADD MEMBER casestudy_standplatzverwalter;

-- Der Benutzer für die Qualitätsprüfung kann Qualitätsbewertungen erstellen und bearbeiten.

CREATE ROLE casestudy_role_qualitaetspruefung;

GRANT SELECT, INSERT, UPDATE, DELETE ON qualitaetsbewertung TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON view_qualitaetspruefer TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON view_anbieter TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON view_qbewertung TO casestudy_role_qualitaetspruefung;

ALTER ROLE casestudy_role_qualitaetspruefung ADD MEMBER casestudy_qualitaetsverantwortlicher;


---------------------------------------------------------------------------------------------------
-- NOTIZ: Dies sollte eigentlich nicht notwendig sein. Durch den Aufbau des Frameworks auf
--        Seiten der UI, ist es allerdings momentan notwendig, auch die unterliegenden
--        Tabellen eines Views zugreifbar zu machen!
GRANT SELECT ON anbieter TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON person TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON anrede TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON adresse TO casestudy_role_standplatzverwaltung;
GRANT SELECT ON ort TO casestudy_role_standplatzverwaltung;

GRANT SELECT ON anbieter TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON qualitaetspruefer TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON aboart TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON person TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON anrede TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON adresse TO casestudy_role_qualitaetspruefung;
GRANT SELECT ON ort TO casestudy_role_qualitaetspruefung;