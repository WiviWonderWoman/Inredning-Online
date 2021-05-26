# Inredning-Online
Dynamiska Webbsystem 1 - januari 2021
## Inlämningsuppgift i Användarautentisering
100/100 (VG)
### Scenario
Det lagom stora inredningsbolaget "Ballong: Luftiga Utrymmen AB" har ett akut behov av att förenkla sin materialbeställningsprocess. De har under många år haft en erfaren inköpsansvarig, men som nu ska gå i pension, och Ballong vill göra det enklare för den nya inköpsansvariga att samverka med övrig personal vid inköp av material. Redan från årsskiftet vill dom ha en första version av ett digitalt webbverktyg för detta på plats, där man snabbt och enkelt ska kunna köpa in sånt man behöver när man inreder ett rum eller kontorsyta.

Nu behöver dom snabbt hitta en erfaren webbutvecklare som kan skapa detta och ha det online till årsskiftet. Av en händelse är Ballongs VD ett stort fan och personlig vän till Hantverkaren, och du har den vägen blivit uppmärksammad för uppdraget! Bolagets VD skriver så här...

> Hej! Vad kul att du kunde ta det här uppdraget med så kort varsel! Vi arbetar generellt sett med att renovera och inreda olika publika ytor, exempelvis kontorslandskap, restauranger, hotell-lobbys med mera, vad vi kallar ett "projekt". För varje projekt köper våra inredare in en lång lista med material från leverantörer vi har avtal med, detta är oftast möbler - men även byggmaterial som golv, färg och detaljprodukter.
Idag gör alla våra inrederare lite olika, och Robert har i stort sett haft ett eget system för att hantera detta. I framtiden vill vi dock att alla inredare ska använda en hemsida för att skapa en lista med produkter att beställa, som sen vår nya inköpare, Ingrid, kan använda sig utav. Det viktigaste är att det blir väldigt enkelt att se vad totalkostnaden för varje projekt hamnar på så att vi kan vara tydliga med detta mot våra kunder.
Jag har sneglat lite på Bolon i Ulricehamn (Länkar till en externa sida.) som har en mycket snyggt sätt att beställa varuprover - men vår sida kommer vi bara använda internt, så det skulle kunna vara mycket enklare designat.
Första versionen skulle kunna vara en sida där man kan registera sig som användare, logga in och och skapa eller se sina projekt. För varje projekt ska det gå att lägga till orderrader, - namn, vart beställning ska ske ifrån och ett pris. Exempelvis "10st CM-BEATRICE" från "Interiör Collection" och 1 700 kr styck. Vore bra att man kunde lägga till en länk där Ingrid kan läsa mer också.
Ingrid behöver kunna se vad totalkostnaden blir på projektet. Ibland kommer man såklart lägga in fel uppgifter, så både Ingrid och inredarna bör kunna justera detta. Det vore också önskvärt om man kunde se snittpriset och totalpriset på alla projekt som skapats!
Hör av dig om du har några frågor eller funderingar, det ska bli kul att få detta på plats!
> Mvh Viktor, VD Ballong AB

### Kravlista:
* Lösningen ska vid inlämning vara körbar med .NET Core (version 3 eller 5)
* Applikationen använder ASP.NET för att starta en webbserver som visar html-sidor när den besöks från en webbläsare
* En "start"-sida finns som visar (korta) instruktioner för hur hemsidan ska användas, enligt valfri utformning.
* En "beställningssida" finns där man kan arbeta med "projekt".
* En besökare kan registera sig som användare på hemsidan, samt logga in och ut ur systemet, detta ska ske via användning av ASP.NET Core Identity.
* Endast inloggade användare har tillgång till beställningsformuläret.
* Via beställningssidan kan man skapa ett nytt projekt.
* Via beställningssidan kan man skapa redigera ett existerande projekt.
* Projekts data hämtas och sparas via Entity Framework Core
* Entity Framework ska användas med en databaskoppling till en tillfällig databas via metoden "UseInMemoryDatabase" i Startup.cs
* Projekt innehåller den information kunden önskar i uppdragsbesrivningen.
* Projekt är väl representerade i kod i jämförelse med kundens önskemål i uppdragsbeskrivningen.
* Minst två lämpliga enhetstester finns för domänlogiken i applikationen.
* En inloggad användare kan endast se sina egna skapade projekt
* En inloggad inköpsansvarig kan se alla projekt, samt snittpris och totalpris på alla projekt
* Lösningen ska förutom kod innehålla en fil med namnet "reflections" i formatet md, txt eller pdf
* I reflections-filen under rubkriken "Struktur" finns en kort och väl vald motivering till kod-strukturen för "projekt".
* I reflections-filen under rubkriken "Säkerhet" finns en kort beskrivning över hur du särkerhetsställt att endast inloggade användare kan arbeta med projekt.
* I reflections-filen under rubkriken "Användare" finns en beskrivning över vilka olika typer av användare som finns i applikationen, och hur detta är implementerat med kod.
