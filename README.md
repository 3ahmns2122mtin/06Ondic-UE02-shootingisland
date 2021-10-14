# Shooting island

### Projektbeschreibung: 
Einführung in / Zusammenfassung des Projektes. 

### Entwicklungsplattform: 
(Betriebsystem, Unity Version, Visual Studio Version, verwendete SDKs)

### Zielplattform: 
WebGL Referenzauflösung (960x600) 

### Visuelle Einblicke in das Projekt: 
![Übung02](https://user-images.githubusercontent.com/91017666/136345141-e7e89a4e-49e5-430f-819d-019c12708be4.png)
Screenshots (Konzept, Spielabschnitte), Video (< 100MB, < 3 min)

### Notwendiges für die Ausführung: 
z.B.: Installationsprozess, Schritt für Schritt Anweisung, spezielles Packages welches geladen werden muss, etc.  

### Drittmaterial: 
Falls verwendet Fonts, Sounds, Music, Graphics, Materials, Code etc. welches nicht von mir stammt muss hier referenziert werden. 

### Anforderungsliste:  
- [x] WebGL export/upload lauffähig/spielbar
 - [x] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
 - [x] In Assets Folder MyGame anlegen.
 - [x] Den Ordner Scenes in Assets > MyGame ziehen
 - [x] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
 - [ ] Ein Canvas GameObject anlegen.
 - [ ] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
 - [ ] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
 - [ ] In Asstets > MyGame den Folder Sprites anlegen.
 - [ ] Ein Hintergrund Sprite reinladen.
 - [ ] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
 - [ ] Das Image ggf. positionieren und größentechnisch anpassen.
 - [ ] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen.
 - [ ] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag.
 - [ ] Das empty GameObject umbenennen in ParentTargets.
 - [ ] in Assets > MyGame > Prefabs Folder anlegen.
 - [ ] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
 - [ ] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen.
 - [ ] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die
 - [ ] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen.
 - [ ] In Assets > MyGame einen neuen Ordner anlegen Scripts
 - [ ] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio (https://github.com/HTL-SBG/FAQIssuesUnityVSGitGitHub/issues/2).
 - [ ] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop).
 - [ ] Einen 2D Collider als Komponente dem Target hinzufügen.
 - [ ] Dem Script Target eine Methode OnMouseDown() hinzufügen.
 - [ ] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
 - [ ] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen.
 - [ ] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen.
 - [ ] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
 - [ ] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.
- [ ] Mercury
- [x] Venus
- [x] Earth (Orbit/Moon)
- [x] Mars

### Limitationen:
Bitte hier nicht, ich kann nicht programmieren, sondern was wurde im Projekt von den Anforderungen nicht umgesetz. Wo waren die Probleme. 

### Lessons Learned:
- [ ] Saturn
- [ ] Uranus
- [ ] Neptune
- [ ] Comet Haley

Copyright by Ondic
