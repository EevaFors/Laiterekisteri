using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laitekirjasto
{
    // Yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille.

    public class Laite
    {
        // Luodaan kenttä (field) name, määritellään esimerkkiarvo
        string name = "Uusi laite";

        //Luodaan kenttää vastaava ominaisuus (property). Isolla alkukirjaimella Name ja sille asetusmetodi set ja lukumetodi get. Ne voi kirjoittaa joko yhdelle tai useammalle riville.
        public string Name { get { return name; } set { name = value; } }

        string ostopaiva = "1.1.2000";
        public string Ostopaiva { get { return ostopaiva; } set { ostopaiva = value; } }

        // Huomaa jälkiliite d (suffix)
        double hinta = 239;
        public double Hinta { get { return hinta; } set { hinta = value; } }

        int takuu = 12;
        public int Takuu { get { return takuu; } set { takuu = value; } }

        string prosessorityyppi = "N/A";
        public string Prosessorityyppi { get { return prosessorityyppi; } set { prosessorityyppi = value; } }

        int keskusmuisti;
        public int Keskusmuisti { get { return keskusmuisti; } set { keskusmuisti = value; } }

        int levytila = 0;
        public int Levytila { get { return levytila; } set { levytila = value; } }

        // Konstruktori eli olionmuodostin (constructor) ilman argumentteja
        public Laite()
        {

        }

        // Konstruktori yhdellä argumentilla
        public Laite(string name)
        {
            this.name = name;
        }

        // Konstruktori neljällä argumentilla
        public Laite(string name, string ostopaiva, double hinta, int takuu)
        {
            this.name = name;
            this.ostopaiva = ostopaiva;
            this.hinta = hinta;
            this.takuu = takuu;
        }

        // Yliluokan metodit
        public void NaytaHankinatiedot()
        {
            // Luetaan laitteen ostotiedot sen kentistä, huom! this

            Console.WriteLine("Laitteen nimi: " + this.name);
            Console.WriteLine("Ostopäivä: " + this.ostopaiva);
            Console.WriteLine("Hankintahinta: " + this.hinta);
            Console.WriteLine("Takuu: " + this.takuu + " kuukautta.");
        }

        //Luetaan laitteen yleiset tekniset tiedot ominaisuuksista, huom. iso alkukirjain
        public void NaytaTeknisettiedot()
        {
        }
        public void NaytaTiedot()
        {

             Console.WriteLine("Koneen nimi: " + Name);
             Console.WriteLine("Prosessori: " + Prosessorityyppi);
             Console.WriteLine("Keskusmuisti: " + Keskusmuisti);
             Console.WriteLine("Levytila: " + Levytila);
            
        }
    }

    // Tietokoneiden luokka, joka perii ominaisuuksia ja metodeja Laite-luokasta.

    public class Tietokone : Laite
    {
        // Määritellään kentät ja ominaisuudet

        string prosessorityyppi;
        public string Prosessorityyppi { get {  return prosessorityyppi; } set {  prosessorityyppi = value; } }
        
        int keskusmuisti;
        public int Keskusmuisti { get { return keskusmuisti; } set { keskusmuisti = value; } }
       
        int levytila;
        public int Levytila { get {  return levytila; } set {  levytila = value; } }

        //Määritellään konstruktorit

        public Tietokone() : base()
        {
        }
        public Tietokone(string name) : base(name) 
        { 
        }

        // Muut metodit
       
    }

    // Tablettien luokka, joka perii Laite-luokan
    public class Tabletti : Laite
    {

        //Kentät ja ominaisuudet

        string jarjestelma;
        public string Jarjestelma { get { return jarjestelma; } set { jarjestelma = value; } }
        bool kaytettavissaKynalla = false;
        public bool KaytettavissaKynalla { get { return kaytettavissaKynalla; } set { kaytettavissaKynalla = value; } }

        // Konstruktorit

        public Tabletti() : base()
        {
        }
        public Tabletti(string name) : base(name) 
        { 
        }

        //Tabletti-luokan erikoismetodit
        public void TabletinTiedot()
        {
            Console.WriteLine("Käyttöjärjestelmä: " + Jarjestelma);
            Console.WriteLine("Kynätuki: " + KaytettavissaKynalla);
        }
    }
    // Pääohjelman luokka, josta tulee Program.exe
    internal class Program
    {

        //Ohjelman varsinaiset toiminnot tapahtuvat täällä. Ohjelma kysyy käyttäjältä tietoja laitteista ja vastaamalla kysymyksiin tiedot tallennetaan muuttujiin.
        static void Main(string[] args)
        {

            //Luodaan uusitietokone, joka perii laiteluokan (Laite) ominaisuudet ja metodit

            Tietokone tietokone1 = new Tietokone();

            // Asetetaan prosessori-ominaisuuden arvo

            tietokone1.Prosessorityyppi = "Intel i7 ";
            tietokone1.Keskusmuisti = 16;
            tietokone1.Ostopaiva = "15.2.2020";
            tietokone1.Hinta = 350.50d;
            tietokone1.Takuu = 36;

            Console.WriteLine("Tietokone 1:n hankintatiedot");
            Console.WriteLine("----------------------------");
            tietokone1.NaytaHankinatiedot();
            
            // Luodaan uusi nimetty kone, toisella konstruktorilla

            Tietokone tietokone2 = new Tietokone("Eevan läppäri");
            tietokone2.Prosessorityyppi = ("Intel Core i7 vPro ");
            tietokone2.Keskusmuisti = 32;

            Console.WriteLine();
            Console.WriteLine("Tietokone 2:n tekniset tiedot: ");
            Console.WriteLine("-------------------------------");

            tietokone2.NaytaTiedot();

            Tabletti tabletti1 = new Tabletti("Eevan iPad");
            tabletti1.Ostopaiva = "1.10.2022";
            tabletti1.Jarjestelma = "iOS";
            tabletti1.KaytettavissaKynalla = true;

            // Näytetään tietoja metodien avulla
            Console.WriteLine("Tabletti 1:n hankintatiedot: ");
            Console.WriteLine("------------------------------");
            tabletti1.NaytaHankinatiedot();

            Console.WriteLine("Tabletti 1:n teknisettiedot: ");
            Console.WriteLine("------------------------------");
            tabletti1.NaytaTeknisettiedot();

            Console.WriteLine("Tabletti 1:n erityistiedot: ");
            Console.WriteLine("------------------------------");
            tabletti1.NaytaTiedot();

            // Lisätty rivi pitämään ikkuna auki

            Console.ReadLine();
        }
    }
}
