-- create Table

-- erstellen aller Tabellen
-- erstellt am 11.06.2020
-- Jennifer Mentner & Sven Gehring

-- geändert am xx.xx.xxxx

-----------------------------------------------------

CREATE DATABASE casestudy;
GO;

USE casestudy;

CREATE TABLE anrede (
    id INT PRIMARY KEY,
    bezeichnung VARCHAR(20) NULL
);

CREATE TABLE ort(
    id INT PRIMARY KEY,
    plz INT NOT NULL,
    ort VARCHAR(255) NOT NULL
);

CREATE TABLE strasse(
    id INT PRIMARY KEY,
    ort_id INT FOREIGN KEY REFERENCES ort(id) NOT NULL,
    stassenname VARCHAR(255) NOT NULL,
    hausnummer INT NOT NULL
);

CREATE TABLE person (
    id INT PRIMARY KEY,
    anrede_id INT FOREIGN KEY REFERENCES anrede(id) NOT NULL,
    strasse_id INT FOREIGN KEY REFERENCES strasse(id) NOT NULL,
    vorname VARCHAR(255) NOT NULL,
    nachname VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    geburtsdatum DATE NULL
);

CREATE TABLE anbieter (
    id INT PRIMARY KEY,
    person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL,
    aufnahmedatum DATE NOT NULL,
    prov_aufnahmedatum DATE,
    bonitaetspruefung BOOLEAN NOT NULL,
    unterschrift BOOLEAN NOT NULL
);

CREATE TABLE aboart (
    id INT PRIMARY KEY,
    bezeichnung TEXT NOT NULL,
    gebuehr INT NOT NULL
);

CREATE TABLE abo (
    id INT PRIMARY KEY,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    aboart_id INT FOREIGN KEY REFERENCES aboart(id) NOT NULL,
);

CREATE TABLE standort (
    id INT PRIMARY KEY,
    bezeichnung VARCHAR(255) NOT NULL
);

CREATE TABLE standplatz (
    id INT PRIMARY KEY,
    standort_id INT FOREIGN KEY REFERENCES standort(id) NOT NULL,
    standplatz_nr INT NOT NULL
);

CREATE TABLE termin (
    id INT PRIMARY KEY,
    standplatz_id INT FOREIGN KEY REFERENCES standplatz(id) NOT NULL,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    datum DATE NOT NULL
);

CREATE TABLE rechnung (
    id INT PRIMARY KEY,
    abo_id INT FOREIGN KEY REFERENCES abo(id) NULL,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    termin_id INT FOREIGN KEY REFERENCES termin(id) NULL,
    rechnungs_nr INT NOT NULL,
    betrag INT NOT NULL
);

CREATE TABLE nachfrager(
    id INT PRIMARY KEY,
    person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL
);

CREATE TABLE bewertung (
    id INT PRIMARY KEY,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    nachfrager_id INT FOREIGN KEY REFERENCES nachfrager(id) NOT NULL,
    bezeichnung TEXT NULL,
    score INT NULL
);

CREATE TABLE qualitaetspruefer (
    id INT PRIMARY KEY,
    person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL,
    lohn INT NULL
);

CREATE TABLE qualitaetsbewertung (
    id INT PRIMARY KEY,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    qualitaetspruefer_id INT FOREIGN KEY REFERENCES qualitaetspruefer(id) NOT NULL,
    bezeichnung TEXT NULL
);
