namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Koodi tähän
            // alustetaan muuttujat ja annetaan toiselle pyydetty arvo
            string viesti, syöte;
            viesti = "Olen viesti-niminen muuttuja ";

            // luodaan tuloste, joka kehoittaa käyttäjää syöttämään ennalta määrätty sana
            Console.WriteLine("Kirjoita joku seuraavista sanoista ja paina enter.");
            Console.WriteLine("kello\ntalo\navain\n");
            // talletetaan käyttäjän kirjoittama syöte samannimisen muuttujaan
            syöte = Console.ReadLine();
            // while-looppi, joka pysähtyy kun break osuu kohdalle
            while (true)
            {
                // tutkitaan if-elsen avulla, onko syötetty sana joku vaadituista
                if (syöte == "kello" || syöte == "talo" || syöte == "avain")
                {
                    // jos ehto täyttyy viesti-muuttujan arvoon lisätään syöte muuttujan arvo ja katkaistaan while
                    viesti = viesti + syöte;
                    break;
                }
                else
                {
                    // jos ehto ei täyty, pyytää sovellus uutta syötettä, kunnes ehto on totta
                    Console.WriteLine(syöte + " on      virheellinen syöte, kirjoita joku seuraavista ja paina enter.");
                    Console.WriteLine("kello\ntalo\navain\n");
                    syöte = Console.ReadLine();
                }
            }

            // tulostetaan viesti-muuttuja, jonka arvoon on jo lisätty jos-lohkossa syöte
            Console.WriteLine(viesti);
            // lsätään viesti-muuttujaan viesti-muuttuja tehtävänannon mukaisesti
            viesti = viesti + " " + viesti;
            Console.WriteLine(viesti);
            // muutetaan viesti-muuttujan arvo syöte-muuttujan arvoksi
            viesti = syöte;
            Console.WriteLine(viesti);

        }
    }
}
