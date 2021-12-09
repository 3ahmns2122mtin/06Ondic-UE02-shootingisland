https://3ahmns2122mtin.github.io/06Ondic-UE02-shootingisland/

# Shooting island

### Projektbeschreibung: 
Einführung in / Zusammenfassung des Projektes. 

### Entwicklungsplattform: 
(Betriebsystem, Unity Version, Visual Studio Version, verwendete SDKs)

### Zielplattform: 
WebGL Referenzauflösung (960x600). 

### Visuelle Einblicke in das Projekt: 
![Übung02](https://user-images.githubusercontent.com/91017666/136345141-e7e89a4e-49e5-430f-819d-019c12708be4.png)
Screenshots (Konzept, Spielabschnitte), Video (< 100MB, < 3 min)
![Einschnitt](https://user-images.githubusercontent.com/91017666/143686625-e86f3a8a-acc5-4cb8-947d-fdb2a6bc0e8d.JPG)


### Notwendiges für die Ausführung: 
z.B.: Installationsprozess, Schritt für Schritt Anweisung, spezielles Packages welches geladen werden muss, etc.  

### Drittmaterial: 
Falls verwendet Fonts, Sounds, Music, Graphics, Materials, Code etc. welches nicht von mir stammt muss hier referenziert werden. 
![1511216217133](https://user-images.githubusercontent.com/91017666/143686311-9a2cfbe8-f6cb-40b8-a730-b17b8cec03f3.jpg)
![d5bf468bc88fe2ccf0adb7915d6f0c8c](https://user-images.githubusercontent.com/91017666/143686321-153034c2-1772-475b-bc27-89f737a60f0b.png)
![dsgshshwh](https://user-images.githubusercontent.com/91017666/143686324-ca41347a-14b4-482d-9bb1-02fadb23cf87.jpg)
![sgwgwg](https://user-images.githubusercontent.com/91017666/143686327-55931150-754b-497a-90b0-070cfb91a284.png)
![ss_97129db23116879c7e07329aff3f9146c4ad15b5 1920x1080](https://user-images.githubusercontent.com/91017666/143686329-180d3d49-91fd-4eec-b105-55c2b8a7127e.jpg)
Shotgun shooting sound

### Anforderungsliste:  
- [x] WebGL export/upload lauffähig/spielbar
 - [x] 2D Untiyprojekt Version 2020.3.18f1 LTS öffnen
 - [x] In Assets Folder MyGame anlegen.
 - [x] Den Ordner Scenes in Assets > MyGame ziehen
 - [x] Die Szene SampleScene im Ornder Scenes umbenennen in ShootingScene
 - [x] Ein Canvas GameObject anlegen.
 - [x] Das Canvas auf screenindependent einstellen: Komponente Canvas --> Render Mode --> Screen Space - Camera, das GameObject Main Camera per Drag & Drop auf Render Camera ziehen in der Komponente Canvas.
 - [x] In der Komponente Canvas Scaler unter UI Scale Mode --> Scale with Screen Size einstellen und als Reference Resolution 960x600 einstellen.
 - [x] In Asstets > MyGame den Folder Sprites anlegen.
 - [x] Ein Hintergrund Sprite reinladen.
 - [x] In der Hierarchy dem Canvas GameObject ein Kind GameObject vom Typ Image hinzufügen und in Background umbenennen.
 - [x] Das Image ggf. positionieren und größentechnisch anpassen.
 - [x] Dem Canvas Eltern GameObject ein empty GameObject (Create Empty) hinzufügen.
 - [x] Auf dem Empty GameObject ein Reset auführen (Komponente Rect Transform --> Menü = 3 vertikale Punkte öffnen --> obester Eintrag.
 - [x] Das empty GameObject umbenennen in ParentTargets.
 - [x] in Assets > MyGame > Prefabs Folder anlegen.
 - [x] Sprite Target in der Hierarchy als Kind GameObject von ParentTargets ziehen und umbenennen in Target.
 - [x] Das GameObject per Drag and Drop in den Prefabs Ornder ziehen. Sollte dann blau erscheinen.
 - [x] Ändern des Mauszeigers: 1) auf Sprite clicken und im Inspector Texture Type Cursor setzen. Wichtig ist am Ende Apply (unten rechts) zu bestätigen, sonst werden die
 - [x] Änderungen nicht übernommen. 2) Unter BuildSettings > PlayerSettings per Drag and Drop das Cursorsprite in Default Cursor ziehen.
 - [x] In Assets > MyGame einen neuen Ordner anlegen Scripts
 - [x] In Scripts ein neues C# Script anlegen: Rechtsklick > Create > C# Script. Script gleich umbenennen in Target. Mit Doppelklick öffnen in Visual Studio (https://github.com/HTL-SBG/FAQIssuesUnityVSGitGitHub/issues/2).
 - [x] Anhängen des Scripts Target als Komponente an das GameObject Target (per Drag and Drop).
 - [x] Einen 2D Collider als Komponente dem Target hinzufügen.
 - [x] Dem Script Target eine Methode OnMouseDown() hinzufügen.
 - [x] In der OnMouseDown() Methodendeklaration, die Methodenaufruf Destroy(gameObject); hinzufügen
 - [x] Das GO Target in der Hierarchy auswählen und mit Apply All die Änderungen bestätigen.
 - [x] In der Szene ein empty GameObject anlegen, umbenennen in GameManager und Reset ausführen.
 - [x] Im Scripts Ordner ein neues C# Script erstellen mit dem Namen GameManager.
 - [x] Das GameManager Script per Drag and Drop dem GameObject GameManager hinzufügen.
 - [x] WebGL Build machen in docs Ordner von dem Projektstand 25.11 
 - [x] docs Ordner auf GitHub laden
 - [x] Eine funktionale Änderung einbauen (zusätzliches Audio, hit Bad Targets --> Decrement by 1, etc.) 
 - [x] WebGL Build machen in docs Ordner 
 - [x] docs Ordner auf GitHub laden


### Limitationen:
Bitte hier nicht, ich kann nicht programmieren, sondern was wurde im Projekt von den Anforderungen nicht umgesetz. Wo waren die Probleme. 

### Lessons Learned:
- [ ] Saturn
- [ ] Uranus
- [ ] Neptune
- [ ] Comet Haley

Copyright by Ondic
