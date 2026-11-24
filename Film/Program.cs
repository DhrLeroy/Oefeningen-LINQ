using Films.Classes;
using Films.Data;

List<Reeks> filmReeksen = Data.GetData();



List<string> namen_reeksen = new List<string>();

foreach(var r in filmReeksen)
{
    namen_reeksen.Add(r.Naam);
}
namen_reeksen = filmReeksen.Select(r => r.Naam).ToList();




// alle films


// alle personages


// alle acteurs



// alle personages (naam rol) in de trilogie The Lord of the Rings


// films met Hugo Weaving


// films uit de jaren '80 (1980-1989)


// filmreeksen met Peter Jackson als regisseur


// acteurs die Bilbo Baggins speelden


// titel (jaar) van films die niet beginnen met 'The'


// films die in het begin van een decennium zijn uitgebracht


// titels van films met meer dan 2 rollen


// acteurs wiens achternaam begint met een klinker


// rollen met maar 1 naam (zonder voor- of achternaam)


// bestaan er acteurs waarvan de voornaam korter is dan 3 letters?


// zijn alle films in de 19e eeuw uitgekomen?


// toon per reeks de titels van de films (bv. Star Wars: A New Hope, The Empire Strikes Back, Return of the Jedi)


// toon alle film van met Hugo Weaving (acteur)


// toon alle films van Peter Jackson (regisseur)


// toon alle films van Peter Jackson met Hugo Weaving


// toon alle rollen van The Hobbit, met per rol de verschillende acteurs die die rol hebben vertolkt (bv. Bilo Baggins: Ian Holm, Martin Freeman). Het kan zijn dat rollen meerdere keren voorkomen met een ander aantal acteurs

var rollen_hobbit = filmReeksen.Where(f => f.Naam.Equals("The hobbit", StringComparison.CurrentCultureIgnoreCase))
    .SelectMany(r => r.Films)
    .SelectMany(f => f.Rollen)
    .Select(r => $"{r.Naam}: {string.Join(", ", r.Acteurs.Select(a => $"{a.Voornaam} {a.Naam}"))}")
    .ToList();

Console.WriteLine();


// 