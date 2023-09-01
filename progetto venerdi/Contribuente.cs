using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto_venerdi
{
     public  class Contribuente
    {

        public static  string Nome { get; set; }

        public  static string Cognome { get; set; }

        public static  DateTime DataDiNascita { get; set; }

        public  static string CodiceFiscale { get; set; }

        public static string Sesso { get; set; }

        public static string ComunediResidenza { get; set; }

        public static  double RedditoAnnuale { get; set; }

        public static double imposta { get; set; }

        public static  List<string> Lista { get; set; } = new List<string>();

       

       

        public static void Failatuascelta()
        {

            Console.WriteLine("-----MENU-------");
            Console.WriteLine(" Scegli l'operazione da effettuare");
            Console.WriteLine("1 NUOVO contribuente");
            Console.WriteLine("2 lista dei contribuenti");
            Console.WriteLine("3-ESCI");
           
            

            int scelta = int.Parse(Console.ReadLine());

            if (scelta == 1)
            {

                Menu();

            }else if(scelta == 2)
            {
                Console.WriteLine("=================ecco a te la lista dei vari contribuenti====================");
                stampa();
            }else if (scelta==3)
            {
                Console.WriteLine("Chiusura programma in corso");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("====seleziona non valida=====");
                Failatuascelta();
            }

            

           
        }

        public static void Menu()
        {

            Console.WriteLine("inserisci dati anagrafici");

            Console.WriteLine("1-Nome");
            String Nome = Console.ReadLine();

            Console.WriteLine("2-Cognome");
            String Cognome = Console.ReadLine();


            Console.WriteLine("3-Data-di-nascita");
            DateTime DatadiNascita = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("4-codice fiscale");
            string CodiceFiscale = Console.ReadLine();

            Console.WriteLine("5-sesso");
            string Sesso = Console.ReadLine();

            Console.WriteLine("6 comune di residenza");
            string ComunediResidenza = Console.ReadLine();


            Console.WriteLine(" 7 redditto annuale");
            double RedditoAnnuale = Convert.ToDouble(Console.ReadLine());

            if (RedditoAnnuale <= 15000)
            {
                double imposta = RedditoAnnuale * 0.23;
                Contribuente.Lista.Add($"nome:{Nome} - cognome:{Cognome}- datadinascita :{DatadiNascita}- CODICEFISCALE :{CodiceFiscale} SESSO:{Sesso} COMUNE DI RESIDENZA :{ComunediResidenza}   redditoannuale{RedditoAnnuale} imposta che pagherai {imposta}  ");
                stampa();
                Failatuascelta();
                
            }

            else if (RedditoAnnuale >= 15001 && RedditoAnnuale <= 28000)
            {
                double imposta = (RedditoAnnuale - 15000) * 0.27 + 3450;
                Contribuente.Lista.Add($"nome:{Nome} - cognome:{Cognome}- datadinascita :{DatadiNascita}- CODICEFISCALE :{CodiceFiscale} SESSO:{Sesso} COMUNE DI RESIDENZA :{ComunediResidenza}   redditoannuale{RedditoAnnuale} imposta che pagherai {imposta}  ");
                stampa();
                Failatuascelta();

           
            }

            else if(RedditoAnnuale >=28001 &&  RedditoAnnuale <= 55000)
            {
                double imposta = (RedditoAnnuale - 28000) * 0.38 + 6960;
                Contribuente.Lista.Add($"nome:{Nome} - cognome:{Cognome}- datadinascita :{DatadiNascita}- CODICEFISCALE :{CodiceFiscale} SESSO:{Sesso} COMUNE DI RESIDENZA :{ComunediResidenza}   redditoannuale{RedditoAnnuale} imposta che pagherai {imposta}  ");
                stampa();
                Failatuascelta();
            }

            else if(RedditoAnnuale>=55001 && RedditoAnnuale <= 75000)
            {
                double imposta = (RedditoAnnuale - 55000) * 0.41 + 17220;
                Contribuente.Lista.Add($"nome:{Nome} - cognome:{Cognome}- datadinascita :{DatadiNascita}- CODICEFISCALE :{CodiceFiscale} SESSO:{Sesso} COMUNE DI RESIDENZA :{ComunediResidenza}   redditoannuale{RedditoAnnuale} imposta che pagherai {imposta}  ");
                stampa();
                Failatuascelta();
            }



            else if (RedditoAnnuale >=75001)
            {
                double imposta = (RedditoAnnuale - 75000) * 0.43 + 25420;
                Contribuente.Lista.Add($"nome:{Nome} - cognome:{Cognome}- datadinascita :{DatadiNascita}- CODICEFISCALE :{CodiceFiscale} SESSO:{Sesso} COMUNE DI RESIDENZA :{ComunediResidenza}   redditoannuale{RedditoAnnuale} imposta che pagherai {imposta}  ");
                stampa();
                Failatuascelta();
            }

        }



       
        public static void stampa()
        {


            Console.WriteLine("=====ecco un resoconto dettagliato delle informazioni fornite dai contribuenti=======");
            foreach(string x in Lista)
            {
                Console.WriteLine(x);
            }
        }

        





    }
}
