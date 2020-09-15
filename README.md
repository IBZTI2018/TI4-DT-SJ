# TI4-DT-SJ Case-Study
Das nachfolgende Dokument erklärt die Verwendung der Case-Study Datenbank und ihrer Beispielssoftware. Einige Aktionen wurden hier bewusst auf den Systemadministrator ausgelagert und nicht automatisiert, da die Gegebenheiten auf jedem System anders sind und es keine "One-size-fits-all" Lösung gibt.

---

### 1. Erstellung der Datenbank
Die Case-Study Datenbank muss vor der Verwendung manuell mit erstellt werden. (z.B mit `CREATE DATABASE casestudy;`)

### 2. Erstellung der Benutzer und Logins
Wir mussten feststellen, dass sich dieser Prozess je nach Setup und aktueller Einrichtung des SQL-Servers stark unterscheidet. Deshalb haben wir diesen Schritt nicht in das Create script eingebunden.

Der Datenbankadministrator muss für jede Benutzerrolle - und falls gewünscht für die Entwcklung zusätzlich - Logins und User erstellen und ihnen Zugriff auf die `casestudy` Datenbank zuweisen.

Die Beispielskonfiguration in der `App.config` verwendet folgendes User/Login Setup. Bei Bedarf muss dies vom Administrator angepasst werden.

```sql
-- Make sure this is run on the casestudy database!
USE casestudy;

-- Create a master user and login for development and testing of the database
CREATE LOGIN casestudy WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy FOR LOGIN casestudy WITH DEFAULT_SCHEMA=casestudy; 

-- Create users and logins for all different roles defined in the documentation
CREATE LOGIN casestudy_administration WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_administration FOR LOGIN casestudy_administration WITH DEFAULT_SCHEMA=casestudy;

CREATE LOGIN casestudy_mitgliederverwalter WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_mitgliederverwalter FOR LOGIN casestudy_mitgliederverwalter WITH DEFAULT_SCHEMA=casestudy;

CREATE LOGIN casestudy_standplatzverwalter WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_standplatzverwalter FOR LOGIN casestudy_standplatzverwalter WITH DEFAULT_SCHEMA=casestudy;

CREATE LOGIN casestudy_qualitaetsverantwortlicher WITH PASSWORD = 'password', CHECK_POLICY = OFF, DEFAULT_DATABASE=casestudy;
CREATE USER casestudy_qualitaetsverantwortlicher FOR LOGIN casestudy_qualitaetsverantwortlicher WITH DEFAULT_SCHEMA=casestudy;
```

### 3. Applikation in Betrieb nehmen
Nach dem Start der Demo-Applikation werden 4 Buttons angezeigt. Diese repräsentieren die implementierten Benutzerrollen (siehe Doku). Durch einen Klick auf einen der Buttons wird eine Verbidung zur Datenbank mit den entsprechenden Zugangsdaten aufgebaut und die UI des entsprechenden Nutzers angezeigt.

---

### 4. (Clean up)
Das folgende Snippet macht die Nutzer/Login Erstellung rückgängig. Dies ist nur ein Template, es wird davon ausgegangen, dass der Datenbankadministrator dieses entsprechend anpasst!

```sql
-- Make sure this is run on the casestudy database!
USE casestudy;

-- Drop all created users and logins
DROP USER casestudy;
DROP LOGIN casestudy;
DROP USER casestudy_administration;
DROP LOGIN casestudy_administration;
DROP USER casestudy_mitgliederverwalter;
DROP LOGIN casestudy_mitgliederverwalter;
DROP USER casestudy_standplatzverwalter;
DROP LOGIN casestudy_standplatzverwalter;
DROP USER casestudy_qualitaetsverantwortlicher;
DROP LOGIN casestudy_qualitaetsverantwortlicher;

-- Drop the database itself
GO
DROP DATABASE casestudy;
```
