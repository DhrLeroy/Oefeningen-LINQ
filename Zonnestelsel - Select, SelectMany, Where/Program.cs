using Zonnestelsel___Select__SelectMany__Where;

var asteroides = File.ReadAllLines("all_asteroids.csv").Skip(1).Select(a => new Asteroide(a)).ToList();

var planeten = File.ReadAllLines("planets.csv").Skip(1).Select(p => new Planeet(p)).ToList();

var planeten_dict = planeten.ToDictionary(p => p.Naam, p => p);
var manen = File.ReadAllLines("moons.csv").Skip(1).Select(m => new Maan(m, planeten_dict)).ToList();

//LINQ-oefeningen: Where, Select en SelectMany
//Deel 1 – Where: gegevens filteren

// Oefening 1.1 – Grote planeten: Maak een lijst met alle planeten waarvan de diameter groter is dan 50.000 km.

// Oefening 1.2 – Kleine asteroïden: Maak een lijst met alle asteroïden waarvan de diameter kleiner is dan 1 km. Hou rekening met asteroïden waarvan de diameter onbekend is. (HasValue)

// Oefening 1.3 – Potentieel gevaarlijke asteroïden: Maak een lijst met alle asteroïden die als potentieel gevaarlijk (IsPotentieelGevaarlijk) worden beschouwd.

// Oefening 1.4 – Manen met een bekende diameter: Maak een lijst met alle manen waarvan de diameter gekend is en groter is dan 100 km.

// Oefening 1.5 – Planeten met veel manen: Maak een lijst met alle planeten die minstens 10 manen hebben.

// Oefening 1.6 – Aardbaan kruisende asteroïden: Maak een lijst met alle asteroïden die de aardbaan kruisen én een diameter hebben die groter is dan 1 km.

// Oefening 1.7 - Planeten met een lange omlooptijd: Maak een lijst met alle planeten waarvan de omlooptijd langer is dan 1000 dagen.

// Oefening 1.8 - Grote asteroïden: Maak een lijst met alle asteroïden met een diameter tussen 100 en 500 km.

// Oefening 1.9 - Manen van Mars: Maak een lijst met alle manen die bij Mars horen.

// Oefening 1.10 - Planeten met kleine manen: Maak een lijst met alle planeten die minstens één maan hebben met een diameter kleiner dan 100 km.

// Oefening 1.11 – Asteroïden met een korte omlooptijd: Maak een lijst met alle asteroïden waarvan de omlooptijd korter is dan 1000 dagen en waarvan de diameter groter is dan 10 km.

// Oefening 1.12 - Potentieel gevaarlijke asteroïden: Maak een lijst met alle asteroïden die potentieel gevaarlijk zijn, maar de aardbaan niet kruisen.

// Oefening 1.13 - Planeten zonder manen: Maak een lijst met alle planeten die geen enkele maan hebben.


// Deel 2 – Select: gegevens omvormen
//Bij deze oefeningen maak je nieuwe resultaten op basis van bestaande objecten. Je hoeft dus niet noodzakelijk de volledige objecten te behouden.

// Oefening 2.1 – Namen van planeten: Maak een lijst met uitsluitend de namen van alle planeten.

// Oefening 2.2 – Omlooptijden: Maak een lijst met de omlooptijden van alle planeten, uitgedrukt in jaren in plaats van dagen. Gebruik hiervoor 365,25 dagen per jaar.

// Oefening 2.3 – Namen en diameters: Maak een lijst waarin je voor elke planeet de naam en diameter bewaart.
// Zorg ervoor dat je resultaat per planeet zowel de naam als de diameter bevat.

// Oefening 2.4 – Diameter in meter: Maak een lijst met de diameters van alle asteroïden, uitgedrukt in meter. Asteroïden waarvan de diameter onbekend is, moeten niet in het resultaat voorkomen.

// Oefening 2.5 – Informatie over de manen: Maak een lijst met tekstregels in de volgende vorm:
// Io heeft een diameter van 3643.2 km.
// Phobos heeft een diameter van 22.2 km.
// Gebruik de naam en diameter van elke maan. Laat manen zonder gekende diameter weg.

// Oefening 2.5 – Overzicht van planeten: Maak een lijst met voor elke planeet een tekstregel in de volgende vorm:
// Jupiter - 139822 km - 95 manen
// Earth - 12742.0168 km - 1 manen
// Gebruik de eigenschappen van de planeet en het aantal manen.

// Oefening 2.6 - Planetaire namen: Maak een lijst met de namen van alle planeten, maar zorg ervoor dat alle namen in hoofdletters staan.

// Oefening 2.7 - Asteroïden in meters: Maak een lijst met de diameters van alle asteroïden, uitgedrukt in meter.
// Asteroïden waarvan de diameter niet gekend is, moeten niet in de lijst voorkomen.

// Oefening 2.8 - Omlooptijden in jaren: Maak een lijst met de omlooptijden van alle planeten, uitgedrukt in jaren. Gebruik 365,25 dagen per jaar.

// Oefening 2.9 - Maanoppervlakte: Maak een lijst met de geschatte oppervlakte van elke maan in km². De oppervlakte van een bol bereken je als volgt: oppervlak = 4 x Pi x straal²

// Oefening 2.10 - Manen met planeet: Maak een lijst van alle manen, met tussen haakjes de naam van de planeet en hun positie tot de planeet t.o.v. de andere manen).
// Bijvoorbeeld:
// Io (1ste maan van Jupiter)
// Europa (2de maan van Jupiter)

// Oefening 2.11 - Maak een lijst van alle planeten, met hierbij hun gemiddelde volume t.o.v. het totale volume met al haar manen. De volume van een bal bereken je als volgt: 4/3 x Pi x straal³
// Bijvoorbeeld:
// Earth: 98,01%



// Deel 3 – SelectMany: geneste collecties combineren
// Bij deze oefeningen werk je met de lijst Manen die aanwezig is in elk planeetobject.
// Het doel is om gegevens uit meerdere collecties samen te brengen in één resultaat.

// Oefening 3.1 – Alle manen: Maak één lijst met alle manen van alle planeten. Je resultaat mag dus geen lijst van lijsten zijn.

// Oefening 3.2 – Namen van alle manen: Maak één lijst met de namen van alle manen van alle planeten.

// Oefening 3.3 – Alle manen met een grote diameter: Maak één lijst met alle manen waarvan de diameter groter is dan 500 km. Je mag hierbij niet eerst een afzonderlijke lijst per planeet maken.

// Oefening 3.4 – Planeten en hun manen: Maak een lijst met tekstregels waarin je telkens de naam van de planeet en de naam van de bijbehorende maan vermeldt.
// Bijvoorbeeld:
// Earth - Earth_moon
// Mars - Phobos
// Mars - Deimos
// Jupiter - Io

// Oefening 3.5 – Aantal grote manen per planeet: Maak een lijst met voor elke planeet het aantal manen met een diameter groter dan 500 km.
// Bijvoorbeeld:
// Earth: 0
// Mars: 0
// Jupiter: ...
// Je moet hiervoor de manen van elke planeet afzonderlijk verwerken.

// Oefening 3.6 – Manen van grote planeten: Maak één lijst met alle manen van planeten met een diameter groter dan 50.000 km.
// Je resultaat bevat uitsluitend de maanobjecten, niet de planeetobjecten.

// Deel 4 – Combinatieoefeningen

// Oefening 4.1 – Grote asteroïden: Maak een lijst met de namen van alle asteroïden met een diameter groter dan 100 km.

// Oefening 4.2 – Gevaarlijke asteroïden: Maak een lijst met tekstregels voor alle potentieel gevaarlijke asteroïden.
// Vermeld per asteroïde de naam en diameter.

// Oefening 4.3 – Planeten met grote manen: Maak een lijst met de namen van alle planeten die minstens één maan hebben met een diameter groter dan 1000 km.
// Een planeet mag maar één keer in het resultaat voorkomen.

// Oefening 4.4 – Alle bekende maanoppervlakken: Maak een lijst met de namen van alle manen met een gekende diameter, afkomstig van planeten die minstens vijf manen hebben.

// Oefening 4.5 – Asteroïden en planeten: Maak een lijst met de namen van alle planeten en asteroïden die een diameter groter dan 10.000 km hebben.
// Zorg ervoor dat beide soorten hemellichamen in één lijst terechtkomen.

// Oefening 4.6 – Ruimtevaartcatalogus: Maak een lijst met tekstregels voor alle hemellichamen (planeten, manen en asteroïden) met een gekende diameter groter dan 1000 km.
// Vermeld telkens:
// - De naam.
// - De diameter.
// - Het soort hemellichaam.
// Bijvoorbeeld:
// Earth - 12742 km - Planeet
// Io - 3643.2 km - Maan
// Ceres - 939.4 km - Asteroïde


// Oefening 4.7 - Per planeet de verhouding van de diameter van de manen en de planeet. Bv. Earth. Verhouding diameter manen/planeet: 27,27%
