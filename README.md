# NewTechnologies

Hoe heb je het aangepakt (gebruikershandleiding)
Welke technologien heb je gebruikt
Wat waren problemen 
Wat werkt niet
Wat is moeilijk

<h2>Methode Beschrijving, Kinect Test</h2>
Allereerst hebben we een tool uitgekozen, dat werd de kinect. We gingen met elkaar brainstormen over concepten die we zouden kunnen testen. Bij elk concept checkte we het internet of het al niet bestond. Het eerste concept was een level op iemands gezicht, d.m.v. facetracking. De kinect had als het goed is de unity libraries, maar er was geen test scene, dus wij wisten niet hoe het te moeten gebruiken.

Waar wel een test scene van te vinden was, was de lichaam detectie. Wanneer de kinect een lichaam herkend maakt hij daar een 'skelet' van. Voor ons eerste hebben we arkanoid gemaakt, waarbij je handen de paddle bestuurt.

<h>Problemen</h>
In eerste instantie bleef de paddle horizontaal binnen de xy-plane. Om meer controle over je paddle te hebben wilde wij rotatie toevoegen, maar dat was vrij moelijk. 
Wij hebben het volgende geprobeerd:
- Vector3.Angle(linkerhand, rechterhand), het resultaat passen we toe op de paddle. Maar de paddle maakt willekeurige draaibewegingen. 
- Vector3.LookAt(), hierdoor bleef de paddle niet binnen zijn xy-plane, wanneer je je handen een z-richting bewoog.

We hebben het er maar uitgehaald. 

Wat soms gebeurde wanneer je de paddle te hard omhoog bewoog is dat de bal er door heen bewoog. Dus de force die wij wilde toepassen, op basis van je beweegsnelheid, kon niet worden toegepast.

Kinect kan tot 6 mensen herken, maar we wisten niet hoe we alle zes konden pakken om er eventueel een multiplayer van te maken.