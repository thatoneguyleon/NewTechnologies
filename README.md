<h1>Experiment 1</h1>
<h2>Welke technologien heb je gebruikt</h2>
Kinect for Windows
<h2>proces(aanpak, bevindingen en moeilijkheden)</h2>
Allereerst hebben we een tool uitgekozen, dat werd de kinect. We gingen met elkaar
brainstormen over concepten die we zouden kunnen testen. Bij elk concept checkte we het
internet of het al niet bestond. Het eerste concept was een level op iemands gezicht, d.m.v.
facetracking. De kinect had als het goed is de unity libraries, maar er was geen test scene,
dus wij wisten niet hoe het te moeten gebruiken. Uiteindelijk kwamen we uit op een
breakout game maken met kinect zoals arkenoid. Hierbij zou er tussen de handen van de
speler een balk verschijnen waarmee de speler de bal kan weren.

Toen wij dit in eerste instantie uitprobeerden bleef de paddle, de balk, horizontaal binnen de
xy-plane. Om meer controle over je paddle te hebben wilde wij rotatie toevoegen, maar dat
was vrij moelijk. Dit is dan uiteindelijk ook niet gelukt, maar we hebben wel de volgende
dingen geprobeerd:
• Vector3.Angle(linkerhand, rechterhand), het resultaat passen we toe op de paddle.
Maar de paddle maakt willekeurige draaibewegingen.
• Vector3.LookAt(), hierdoor bleef de paddle niet binnen zijn xy-plane, wanneer je je
handen een z-richting bewoog.

Wat soms gebeurde wanneer je de paddle te hard omhoog bewoog is dat de bal er door
heen bewoog. Dus de force die wij wilde toepassen, op basis van je beweegsnelheid, kon
niet worden toegepast. Dit kwam omdat er problemen waren met de clipping en de collision
van de paddle.

Wat wel is gelukt is de lengte van de balk aan te passen aan de hand van de afstand tussen
de handen van de speler.

Hiernaast kwamen we erachter dat de Kinect maximaal 6 mensen kan herkennen. Helaas
wisten we niet hoe we 6 mensen konden konden implementeren om er een multiplayer van
te maken.

<h2>gebruikershandleiding</h2><br>
Benodigdheden:<br>
• De Kinect for Windows<br>
• De SDK voor Unity: https://channel9.msdn.com/coding4fun/kinect/Kinect-for-Windows-v2-SDK-and-Unity-3D<br>
• Unity 3D<br><br>

Setup:<br>
• Download deze repo en run het.<br><br>

<h1>Experiment 2</h1>
<h2>Welke technologien heb je gebruikt</h2>
HTC vive
<h2>proces(aanpak, bevindingen en moeilijkheden)</h2>
Wij wouden voor ons tweede project graag met Virtual Reality werken. Als experiment
wouden kijken naar de mogelijkheid van third-person-perspective in Virtual Reality. Hierom
hebben we een concept bedacht een ezel in een omgeving loopt die jij kan besturen.

Na herhalend proberen, bleek dat een Virtual Realiy eigenlijk een first-person view nodig had
om volledig de ruimte te bekijken. Met een third-person-perspective kan je namelijk niet
omhoog en omlaag kijken. Om dit goed op te lossen zou je de third-person camera moeten
customizen wat te veel tijd kost. Wij hebben dit probleem opgelost door een first person
camera te gebruiken en deze achter de player-character, een paard, te hangen. We hebben
de player-character met de first person controller verbonden een hingeJoint.

Omdat je in Virtual Reality niet ver kunnen lopen, bedachten we ons dat de ezel al
automatisch loopt en je hem alleen naar links en rechts kan laten gaan met behulp van de
controllers. Dit is geïmplementeerd door een stok met een wortel eraan voor de ezel te doen
die de ezel achtervolgd. De speler heeft de stok in zijn hand, dus als hij die beweegt, zal de
ezel meebewegen.

<h2>gebruikershandleiding</h2><br>
Benodigdheden:<br>
• De Kinect for Windows<br>
• De SDK voor Unity: https://channel9.msdn.com/coding4fun/kinect/Kinect-for-Windows-v2-SDK-and-Unity-3D<br>
• Unity 3D<br><br>

Setup:<br>
• Download deze repo en run het.<br><br>

<h>Rolverdeling</h><br>
Tariq Bakhtali - Developer<br>
Erik de Beurs - Designer, 3D Artist<br>
Jelle Bighelaar - 3D Artist<br>
Kevin van As - Developer<br>
Leon v.d. Berg - Designer<br><br>

Voor de sourcecode en build, download dit bestand:<br>
http://studenthome.hku.nl/~kevin.vanas/src/SuperDonkeyBall.rar

<h>PMI</h>
Tariq: <br>
    P - We hadden een ruime keus aan technologiën<br>
    M - Het resultaat van de kinect was mager. Jammer dat we geen beschikking hadden over facetracking<br>
    I - De oplossing voor een 3rd person vr game vond ik interessant. <br><br>
    
Kevin:<br>
P - Deels leren omgaan met met de Vive, een waardevolle skill. Super Donkey Ball level is gaaf geworden. De vertaling van jouw beweging naar de paddle in Arkanoid voelt goed.<br>
M - Inputs verwerken van Vive controllers is niet helemaal gelukt, zou eigenlijk nog net iets meer aandacht nodig hebben. <br>
I - Volgens mij begin ik resistentie op te bouwen tegen VR-misselijkheid...<br><br>

Leon:<br>
P - Gewerkt met nieuwe technologie namelijk Virtual reality via de HTC Vive en gewerkt met mensen waar ik nog niet eerder mee heb samengewerkt.<br>
M - We hadden niet echt een vaste planning. Hierdoor kon niet iedereen altijd iets doen. hiernast werd er geen voortgang bijgehouden hierdoor was niet iedereen altijd op de hoogte van hoe goed het ging en hoe ver we waren.<br>
I - Doordat we geen theorie kregen, moesten we alles zelf uitzoeken en experimenteren. Doordat we de basis zelf moesten uitzoeken was het moeilijker om geavanceerdere projecten te doen. Maar leren we hierdoor wel alles zelfstandig en begrijpen we het door te doen.<br><br><br>

Erik:<br>
P - Interessant om kennis te maken met een VR systeem met bijbehorende controls. Erg geslaagd!<br>
M: Het opzetten en calibreren van de VR installaties hadden we vaak moeite mee, lag deels aan de ruimte, maar ergens knaagde het gevoel ook dat het aan de hardware lag.<br>
I: Het experimenteren met een 3rd person view voor een VR platform was tof om te doen. Uiteindelijk hebben we een leuke oplossing gevonden.<br><br>

Jelle:<br>
P - 
M - 
I -
