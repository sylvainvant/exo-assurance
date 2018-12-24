using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_assurance
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=0;
            int nb_accidents=0;
            int duree=0;
            int anciennete=0;
            int point = 0;
            string saissie;

            Console.WriteLine("Bienvenue dans l'outil de afiliation de tarif assurence");
                Console.WriteLine("entrez votre age:");
                saissie = Console.ReadLine();
                age = Convert.ToInt32(saissie);
           
                Console.WriteLine("entrez vos nombres accidents:");
                saissie = Console.ReadLine();
                nb_accidents = Convert.ToInt32(saissie);
                Console.WriteLine("entrez votre nombre année de permis:");
                saissie = Console.ReadLine();
                duree = Convert.ToInt32(saissie);
                Console.WriteLine("entrez votre ancienneté:");
                saissie = Console.ReadLine();
                anciennete = Convert.ToInt32(saissie);
            
           
                if (age < 25)
                {
                    point += 1;
                }
                    if (duree <= 2)
                    {
                    point += 1;
                    }
                point += nb_accidents;
                if (point < 3 && anciennete > 1)
                {
                    point -= 1;
                }

                switch (point)
                {
                    case -1:
                        Console.WriteLine("assurance bleu");
                        break;
                    case 0:
                        Console.WriteLine("assurance vert");
                        break;
                    case 1:
                        Console.WriteLine("assurance orange");
                        break;
                    case 2:
                        Console.WriteLine("assurance rouge");
                        break;
                    default:
                        Console.WriteLine("assurance imposible");
                        break;
                }

            // permet de conserver affichage consol
            Console.ReadLine();


        }
    }
}
