using System.Collections.Generic;
using System.Diagnostics;
using static System.Formats.Asn1.AsnWriter;

namespace ReactionTimeAssignment
{
    internal class Program
    {

        //Tee sovellus, joka mittaa käyttäjän reaktioaikaa.
        //Tallenna käyttäjältä 3-5 reaktioaikaa ja tämän jälkeen ilmoita käyttäjälle hänen keskimääräinen reaktionopeus.
        //Lisäksi voit tehdä High Score toiminnallisuuden käyttämällä Dictionary:a.
        //Tallenna Dictionaryyn key-arvoksi käyttäjän nimi ja valueksi käyttäjän reaktioaika.
        //Näytä High Score lista aina yhden pelatun pelin jälkeen.
        //High Score listalla voi olla vain viisi nimeä kerrallaan.
        //Jos uusi tulos on parempi kuin mitä listalla on, pudota huonoin tulos pois sieltä ja lisää uusi.
        //Lisäksi High Score lista tulisi tulostaa aina siten, että paras pelaaja on ensimmäinen.

        //Käyttäjä voi jatkaa tämän jälkeen pelaamista tai lopettaa ohjelman.

        static void Main(string[] args)
        {
            //Luodaan uusi random-olio
            Random random = new Random();
            // Asettaa satunnaisen ajan 1-5 sekuntia.
            int sleepTime = random.Next(1000, 5000);
            // Odottaa satunnaisen ajan 1-5 sekuntia.
            Thread.Sleep(sleepTime);

            // Aloittaa ajanoton.
            Stopwatch stopwatch = Stopwatch.StartNew();
            //Lopettaa ajanoton
            stopwatch.Stop();
            //Otetaan talteen reaktioaika
            double reactionTime = stopwatch.Elapsed.TotalMilliseconds;
        }
    }
}