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
    id INT PRIMARY KEY IDENTITY,
    plz INT NOT NULL,
    ort VARCHAR(255) NOT NULL
);

CREATE TABLE adresse(
    id INT PRIMARY KEY IDENTITY,
    ort_id INT FOREIGN KEY REFERENCES ort(id) NOT NULL,
    stassenname VARCHAR(255) NOT NULL,
    hausnummer INT NOT NULL
);

CREATE TABLE person (
    id INT PRIMARY KEY IDENTITY,
    anrede_id INT FOREIGN KEY REFERENCES anrede(id) NOT NULL,
    adresse_id INT FOREIGN KEY REFERENCES adresse(id) NOT NULL,
    vorname VARCHAR(255) NOT NULL,
    nachname VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    geburtsdatum DATE NULL
);

CREATE TABLE anbieter (
    id INT PRIMARY KEY IDENTITY,
    person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL,
    aufnahmedatum DATE NULL ,
    prov_aufnahmedatum DATE NULL,
    bonitaetspruefung BIT NOT NULL,
    unterschrift BIT NOT NULL
);

CREATE TABLE aboart (
    id INT PRIMARY KEY IDENTITY,
    bezeichnung TEXT NOT NULL,
    gebuehr FLOAT NOT NULL
);

CREATE TABLE abo (
    id INT PRIMARY KEY IDENTITY,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    aboart_id INT FOREIGN KEY REFERENCES aboart(id) NOT NULL,
);

CREATE TABLE standort (
    id INT PRIMARY KEY IDENTITY,
    bezeichnung VARCHAR(255) NOT NULL
);

CREATE TABLE standplatz (
    id INT PRIMARY KEY IDENTITY,
    standort_id INT FOREIGN KEY REFERENCES standort(id) NOT NULL,
    standplatz_nr INT NOT NULL
);

CREATE TABLE termin (
    id INT PRIMARY KEY IDENTITY,
    standplatz_id INT FOREIGN KEY REFERENCES standplatz(id) NOT NULL,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    datum DATE NOT NULL
);

CREATE TABLE rechnung (
    id INT PRIMARY KEY IDENTITY,
    abo_id INT FOREIGN KEY REFERENCES abo(id) NULL,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    termin_id INT FOREIGN KEY REFERENCES termin(id) NULL,
    rechnungs_nr VARCHAR(50) NOT NULL,
    betrag FLOAT NOT NULL
);

CREATE TABLE nachfrager(
    id INT PRIMARY KEY IDENTITY,
    person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL
);

CREATE TABLE bewertung (
    id INT PRIMARY KEY IDENTITY,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    nachfrager_id INT FOREIGN KEY REFERENCES nachfrager(id) NOT NULL,
    bezeichnung TEXT NULL,
    score FLOAT NULL
);

CREATE TABLE qualitaetspruefer (
    id INT PRIMARY KEY IDENTITY,
    person_id INT FOREIGN KEY REFERENCES person(id) NOT NULL,
    lohn FLOAT NULL
);

CREATE TABLE qualitaetsbewertung (
    id INT PRIMARY KEY IDENTITY,
    anbieter_id INT FOREIGN KEY REFERENCES anbieter(id) NOT NULL,
    qualitaetspruefer_id INT FOREIGN KEY REFERENCES qualitaetspruefer(id) NOT NULL,
    bezeichnung TEXT NULL
);
