using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esimerkki
{
    // Yleinen laiteluokka, yliluokka tietokoneille, tableteille ja puhelimille.

    public class Laite
    {
        // Luodaan kenttä (field) name, määritellään esimerkkiarvo
        string name = "uusi laite";

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
    internal class Program
    {
        // Pääohjelman luokka, josta tulee Program.exe

        static void Main(string[] args)
        {
            /* Ohjelman varsinaiset toiminnot tapahtuvat täällä. Ohjelma kysyy käyttäjältä tietoja laitteista ja 
               vastaamalla kysymyksiin tiedot tallennetaan muuttujiin.*/

            //Luodaan uusi laite Laite-luokasta.

            Laite laite = new Laite("Tietokone");
            Console.WriteLine("Laitteen nimi on: " + laite.Name);
            Console.WriteLine("Laitteen hankintapäivä oli: " + laite.Ostopaiva);
            Console.WriteLine("Laitteen ostohinta oli: " + laite.Hinta + " euroa");
            Console.WriteLine("Laitteen takuuaika: " + laite.Takuu + " kuukautta");


            Console.ReadLine();
        }
    }
}
