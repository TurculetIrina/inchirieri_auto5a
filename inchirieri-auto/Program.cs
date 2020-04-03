using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inchirieri_auto
{
    class Program
    {
        static string Meniu()
        {
            string meniu;
            meniu = "M - Citire masina de la tastatura\n";
            meniu += "A - Citire angajat de la tastatura\n";
            meniu += "C - Citire client de la tastatura\n";
            meniu += "F - Afisare masini\n";
            meniu += "T - Test masini\n";
            meniu += "X - Exit";
            return meniu;
        }

        static void Main(string[] args)
        {
            string FisierMasini = "masini.txt";
            FileManager adminMasini = new FileManager(FisierMasini);
            int NrMasini;
            Masini[] MasiniFisier = adminMasini.GetMasini(out NrMasini);

            do
            {
                Console.Clear();
                Console.WriteLine(Meniu());
                string optiune = Console.ReadLine();
                optiune = optiune.ToUpper();
                switch(optiune)
                {
                    case "M":
                        string mesaj;
                        mesaj = "Marca, Model, Nr. Inmatriculare, An, Capacitate Motor, Culoare:\n1.Alb\n";
                        mesaj += "2.Negru\n3.Albastru\n4.Verde\n5.Galben\n6.Portocaliu,";
                        mesaj += "Motorizare:\n1.Benzina\n2.Diesel\n3.ElectricPartial\n4.FullElectric, Inghiriata: 0 Nu 1 Da";
                        Console.WriteLine(mesaj);
                        // var masina = new Masini(Console.ReadLine());
                        var masina = new Masini("Audi", "RS7", "SV01IRI", 2019, 3500, (CuloareMasina)1, (CombustibilMasina)2, false);
                        MasiniFisier[NrMasini] = masina;
                        NrMasini++;
                        adminMasini.AddMasini(masina);
                        Console.ReadLine();
                        break;
                    case "A":
                        var angajat = new Angajati("Turculet", "Irina", "Cuza Voda", "0745454545", 22,
                        "2971231565658", "Vanzari", 4, 3, 2020);
                        Console.WriteLine(angajat.ConversieLaSir());
                        var angajat2 = new Angajati("Turculet", "Irina", "Cuza Voda", "0745454545", 22,
                        "2971231565658", "Vanzari", 4, 3, 2020);
                        Console.WriteLine(angajat2.ConversieLaSir());
                        if (angajat.Compare(angajat2))
                            Console.WriteLine("Este acelasi angajat");
                        else
                            Console.WriteLine("NU este acelasi angajat");
                        Console.ReadKey();
                        break;
                    case "C":
                        var client = new Clienti("Turculet", "Georgel", "Grigore Antipa", "0741414141", 27, "1921122565859",
                        "SV92TGM", 1, 2, 2020, 7);
                        var client2 = new Clienti("Turculet", "Georgel", "Grigore Antipa", "0741414141", 27, "1921122565859",
                        "SV92TGM", 1, 2, 2020, 7);
                        Console.WriteLine(client.ConversieLaSir());
                        Console.WriteLine(client2.ConversieLaSir());
                        if (client.Compare(client2))
                            Console.WriteLine("Este acelasi client");
                        else
                            Console.WriteLine("NU este acelasi client");
                        Console.ReadKey();
                        break;
                    case "T":
                       var masina1 = new Masini("Audi", "RS7", "SV01IRI", 2019, 3500, (CuloareMasina)1, 
                           (CombustibilMasina)2, false);
                        Console.WriteLine(masina1);
                        var masina2 = new Masini("Audi", "R8", "SV02IRI", 2019, 4800,
                            (CuloareMasina)3, (CombustibilMasina)3, false);
                        Console.WriteLine(masina2.ConversieLaSir());
                        if (masina1.Compare(masina2))
                            Console.WriteLine("Este aceiasi masina");
                        else
                            Console.WriteLine("Nu este aceeasi masina");
                        Console.ReadKey();
                        break;
                    case "F":
                        if (NrMasini == 0)
                            Console.WriteLine("Nu sunt date");
                        for(int i=0; i < NrMasini; i++)
                            Console.WriteLine(MasiniFisier[i].ConversieLaSir());
                        Console.ReadKey();
                        break;
                    case "X":
                        System.Environment.Exit(1);
                        break;
                }
            } while (true);
        }
    }
}
