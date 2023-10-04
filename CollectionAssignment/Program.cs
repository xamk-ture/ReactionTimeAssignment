using System.Collections.Generic;

namespace CollectionAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assignment1();
            Assignment2();
            Assignment3();
            Assignment4();
            Assignment5();
            Assignment6();
        }

        static void Assignment1()
        {
            //Luo uusi taulukko tai lista

            //Lisää taulukkoon tai listaan luvut 0-9 käyttämällä for-looppia tai for each -tekniikkaa

            //Tulosta taulukko tai lista
        }

        static void Assignment2()
        {
            //Luo uusi taulukko tai lista, jossa on luvut 0-9

            //Tulosta käyttäjälle luvut, jotka ovat suurempia kuin 5 käyttäen ForEach-tekniikkaa
        }

        static void Assignment3()
        {
            //Kysy käyttäjältä 5 kokonaislukua ja tallenna ne taulukkoon tai listaan

            //Tämän jälkeen kerro käyttäjälle, että mikä on keskiarvo
            //Laske keskiarvo käyttäen ForEach tai For tekniikkaa
            //On olemassa funktio, joka laskee keskiarvon (Average), mutta älä käytä sitä, vaan laske itse "käsin".
            //Tämä auttaa ymmärtämään, miten keskiarvo lasketaan ja miten Average-funktio toimii.
        }

        static void Assignment4()
        {
            //Kysy käyttäjältä, että minkä nimistä hän haluaa poistaa listasta
            //Käyttäjä voi poistaa nimen listasta, joko kirjoittamalla nimen tai numeron
            //Jos käyttäjä kirjoittaa numeron, niin poista nimi taulukon indeksin perusteella
            //Käyttäjä voi siis antaa luvut 0,1,2 tässä tapauksessa
            //Tämän jälkeen tulosta lista uudestaan ja näytä, että nimi on poistettu

            List<string> nameList = new List<string>
            {
                "Matti",
                "Tiina",
                "Pena"
            };
        }

        static void Assignment5()
        {
            //Luo ja Tulosta Sanakirja (Dictionary)

            //Luo Dictionary, jossa avaimina on henkilöiden nimet(merkkijonoina string) ja arvoina heidän ikänsä(kokonaislukuina int).
            //Lisää sanakirjaan kolme henkilöä.
            //Tulosta jokainen henkilö ja heidän ikänsä.
        }

        static void Assignment6()
        {
            //Toteuta ohejlma, jonka avulla käyttäjä voi lisätä, poistaa ja muokata henkilöitä dictionaryn avulla.
            //Käyttäjältä kysytään ensin, että haluaako hän lisätä, poistaa vai muokata henkilöitä.
            //Tämän jälkeen kutsutaan oikeata funktiota, joka toteuttaa toiminnallisuuden.
            //Käyttäjä voi lopettaa ohjelman kirjoittamalla "lopeta", jos hän on "päävalikossa",
            //eli tämän funktion alussa jossa kysytään toimintoa

            Dictionary<string, int> personsDictionary = new Dictionary<string, int>();
            personsDictionary.Add("Matti", 21);
            personsDictionary.Add("Tiina", 25);
            personsDictionary.Add("Pena", 32);

            //Toteuta lisäys
            Assignment6Add(personsDictionary);

            //Toteuta poisto
            Assignment6Remove(personsDictionary);

            //Toteuta muokkaus
            Assignment6Edit(personsDictionary);

        }

        static void Assignment6Add(Dictionary<string, int> persons)
        {
            //Tee ohjelma, joka kysyy käyttäjältä ikää ja nimeä. Tallenna tämä tulos dictionaryyn,
            //jossa avaimena on nimi ja arvona ikä.

            //Tulosta tämän jälkeen kaikki nimet ja iät.

            //Käyttäjä voi lopettaa poistamisen kirjoittamalla "lopeta"
        }

        static void Assignment6Remove(Dictionary<string, int> persons)
        {
            //Laajenna Assignmet6 tehtävää siten, että käyttäjä voi myös poistaa henkilöitä sanakirjasta.
            //Käyttäjä voi poistaa joko nimen tai iän perusteella.
            //Käyttäjä voi lopettaa poistamisen kirjoittamalla "lopeta"

        }

        static void Assignment6Edit(Dictionary<string, int> persons)
        {
            //Tee tämän jälkeen vielä toiminallisuus, jossa käyttäjä voi muokata henkilön ikää.
            //Ikää voi muokata, jos käyttäjän antama nimi löytyy sanakirjasta.
            //Tämän jälkeen kysytään käyttäjältä uusi ikä
            //Jos käyttäjää ei löydy, tulostetaan virheilmoitus.
            //Tämän jälkeen käyttäjältä kysytään nimeä uudestaan.
            //Käyttäjä voi lopettaa muokkaamisen kirjoittamalla "lopeta"
        }
    }
}