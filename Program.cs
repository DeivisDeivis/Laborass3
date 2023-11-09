using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratorinis_3
{
    class krepsininkas
    {
        public string komanda;
        public string pavarde;
        public string vardas;
        public double  ugis;
        public int metai;
        public string pozicija;
        public int rungtynes;
        public int ImestiTaskai;


        public krepsininkas(string komanda, string pavarde, string vardas, double ugis, int metai, string pozicija, int rungtynes, int imestiTaskai)
        {
            this.komanda= komanda;
            this.pavarde = pavarde;
            this.vardas= vardas;
            this.ugis = ugis;
            this.metai = metai;
            this.pozicija = pozicija;
            this.rungtynes = rungtynes;
            ImestiTaskai = imestiTaskai;
        }


            public override string ToString()
        {
            string eilute;
            eilute = string.Format(" | {0,14} | {1,19} | {2,12} | {3,14:d} | {4,21:d} | {5,17:d} | {6, 18 : d}",
            komanda, pavarde,  ugis, metai, pozicija, rungtynes);
            return eilute;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int ImtiKieki(int i) { return i; }
    }


    class Krepsininkai {
        const int Cn = 100; 
        private krepsininkas[] krepsininkai;
        private int kiekis;

public Krepsininkai()
        {
            kiekis = 0;
            krepsininkai = new krepsininkas[Cn];
        }
public Krepsininkai(krepsininkas [] krepsininkai, int kiekis)
        {
            this.krepsininkai = krepsininkai;
            this.kiekis = kiekis;

        }

        public krepsininkas Imti(int i) { return krepsininkai[i]; } 
        public int ImtiKieki( ) { return kiekis; }




    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.GetEncoding(1257);
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            krepsininkas krepsininkai = new krepsininkas();

        }


        static void Spausdinti(string fv, Krepsininkai krepsininkai, string antraste)
        {
            string virsus =
            ""
            + " -------------------------------------------------------------------------------------------------------------------- \r\n"
            + " |   Komanda      |       pavarde       | vardas       |   ugis         |         | Standart. popier. | \r\n"
            + " |                |                     |   formatas   |  sparta (cpm)  |  išspausdinimo laikas |   kasetės talpa   | \r\n"
            + " --------------------------------------------------------------------------------------------------------------------";
            using (var fr = File.AppendText(fv))
            {
                fr.WriteLine(antraste);
                fr.WriteLine(virsus);
                for (int i = 0; i < 3; i++)
                    fr.WriteLine(krepsininkai.Imti(i).ToString());
                fr.WriteLine(" -------------------------------------------------------------------------------------------------------------------- ");
            }
        }

        static void Skaityti(ref Krepsininkai krepsininkai, string fv)
        {
            string komanda, pavarde, line;

            int ugis, metai;

            string pozicija;
            int rungtynes, ImestiTaskai;

      

            using (StreamReader reader = new StreamReader(fv))
            {
                 krepsininkai = new Krepsininkai();

                while ((line = reader.ReadLine()) != null)
                {
                   
                    string[] parts = line.Split(';');
                    komanda = parts[0].Trim();
                    pavarde = parts[1].Trim();
                    ugis = double.Parse(parts[2].Trim();
                    metai = int.Parse(parts[3].Trim());
                    pozicija = (parts[4].Trim());
                    rungtynes = int.Parse(parts[5].Trim());
                    ImestiTaskai= int.Parse(parts[6].Trim());
                    Krepsininkai krepsininkai = new Krepsininkai(komanda, pavarde, ugis, metai, pozicija, rungtynes, ImestiTaskai);
                   
                }
            }
        }
    }
}
