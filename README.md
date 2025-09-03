# 📌 Aufgabenbeschreibung – ToDoApp Projekt

## 🎯 Ziel
Das Ziel des Projekts war die Entwicklung einer **To-Do-Webanwendung**, bei der moderne Technologien aus den Bereichen **Webentwicklung, Programmierung, Datenbanken und Containerisierung** zusammenspielen.  

Die Anwendung sollte es ermöglichen, Aufgaben zu **erstellen, anzuzeigen, zu bearbeiten, den Status zu ändern und zu löschen**.  

---

## ✅ Anforderungen

### 1. Frontend (Blazor)
- Umsetzung mit **Blazor Server**.  
- Darstellung der Aufgaben in einer Liste.  
- Buttons zum:
  - Erstellen neuer Aufgaben  
  - Bearbeiten bestehender Aufgaben  
  - Ändern des Status (*Offen / Erledigt*)  
  - Löschen von Aufgaben  

### 2. Backend (C#)
- Entwicklung der Geschäftslogik in **C# / .NET**.  
- Erstellung eines Services zur Verwaltung von Aufgaben (CRUD-Operationen).  
- Nutzung von **Dependency Injection**, um den Service in Razor-Komponenten einzubinden.  

### 3. Datenbank (MariaDB)
- Speicherung aller Aufgaben in einer **MariaDB-Datenbank**.  
- Tabellenstruktur mit Feldern:
  - `Id` (Primärschlüssel)  
  - `Title` (Titel der Aufgabe)  
  - `Description` (Beschreibung)  
  - `Status` (pending, in_progress, completed)  
- Einrichtung und Verwaltung über **Docker** und **phpMyAdmin**.  

### 4. Containerisierung (Docker)
- Bereitstellung von MariaDB und phpMyAdmin per `docker-compose.yml`.  
- Isolierte und reproduzierbare Entwicklungsumgebung.  

### 5. Versionskontrolle (GitHub)
- Verwaltung des Codes mit **Git** und **GitHub**.  
- Möglichkeit zur Nachverfolgung von Änderungen und gemeinsamer Arbeit.  

---

## 📝 Ergebnis

In **phpMyAdmin** wurde eine Datenbank mit einer Tabelle namens **Tasks** erstellt:  

<img width="553" height="107" alt="image" src="https://github.com/user-attachments/assets/43b8979d-a21c-4300-ab00-2c89ae20f9ce" />

---

Nach der Verbindung mit der **Blazor Web App** werden die gespeicherten Aufgaben korrekt angezeigt:  

<img width="407" height="177" alt="image" src="https://github.com/user-attachments/assets/bef88680-ed99-4b83-8f82-f85204745294" />

---

Wenn in der Anwendung eine neue Aufgabe erstellt wird, erscheint diese auch direkt in der Datenbank:  

<img width="467" height="198" alt="image" src="https://github.com/user-attachments/assets/5f3c316d-dab6-4a76-b15f-9e3d699771d3" />

Und umgekehrt: Änderungen in der **App** spiegeln sich ebenfalls in der **Datenbank** wider.  

<img width="601" height="117" alt="image" src="https://github.com/user-attachments/assets/7a255c06-016e-493c-a2aa-83a4fa64f087" />



