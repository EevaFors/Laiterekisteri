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
        public void ShowInfo()
        {
            Console.WriteLine("Koneen nimi: " + Name);
            Console.WriteLine("Prosessori: " + Prosessorityyppi);
        }
    }
    // Pääohjelman luokka, josta tulee Program.exe
    internal class Program
    {

        /* Ohjelman varsinaiset toiminnot tapahtuvat täällä. Ohjelma kysyy käyttäjältä tietoja laitteista ja 
               vastaamalla kysymyksiin tiedot tallennetaan muuttujiin.*/
        static void Main(string[] args)
        {
            

            //Luodaan uusi laite Laite-luokasta.

            Laite laite = new Laite("Tietokone");
            Console.WriteLine("Laitteen nimi on: " + laite.Name);
            Console.WriteLine("Laitteen hankintapäivä oli: " + laite.Ostopaiva);
            Console.WriteLine("Laitteen ostohinta oli: " + laite.Hinta + " euroa");
            Console.WriteLine("Laitteen takuuaika: " + laite.Takuu + " kuukautta");

            //Luodaan uusitietokone, joka perii laiteluokan (Laite) ominaisuudet ja metodit

            Tietokone tietokone1 = new Tietokone();

            // Asetetaan prosessori-ominaisuuden arvo

            tietokone1.Prosessorityyppi = "Intel i7 ";
            tietokone1.Keskusmuisti = 16; 
            
                Console.WriteLine("Uuden tietokoneen nimi on: " +  tietokone1.Name + " ja siinä on " + tietokone1.Prosessorityyppi + "prosessori ja " + tietokone1.Keskusmuisti + "GB keskusmuisti.");

            // Luodaan uusi nimetty kone, toisella konstruktorilla

            Tietokone tietokone2 = new Tietokone("Eevan läppäri");
            tietokone2.Prosessorityyppi = ("Intel Core i7 vPro ");
            tietokone2.Keskusmuisti = 32;
            tietokone2.ShowInfo();

            // Lisätty rivi pitämään ikkuna auki

            Console.ReadLine();
        }
    }
}
