using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Boucle
{
    class Program
    {
        static void Main(string[] args)
        {
            // Afficher les multiples de 2 de 0 à 20 compris
            /*for(int i = 0; i < 21; i++)
            {
                Console.WriteLine(i);
            }

            int counter = 0;
            while(counter < 21)
            {
                Console.WriteLine(counter);
                counter++;
            }*/

            // Saisir un nombre puis afficher la somme totale en additionnant tous les nombres jusqu'à ce nombre
            /*Console.WriteLine("Saisir un nombre :");
            int max = Convert.ToInt32(Console.ReadLine());
            StringBuilder addition = new StringBuilder();
            int sum = 0;
            for(int i = 1; i <= max; i++)
            {
                sum += i;
                if (i.Equals(max))
                {
                    addition.Append(i);
                } else
                {
                    addition.Append(i);
                    addition.Append("+");
                }
            }
            Console.WriteLine(addition);
            Console.WriteLine("Le résultat est " + sum);*/

            // Saisir 5 nombres au clavier. Calculer la sommme des nombres puis afficher la moyenne
            /*Console.WriteLine("Choisir 5 nombres");
            Console.WriteLine("Nombre 1 :");
            int nb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre 2 :");
            int nb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre 3 :");
            int nb3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre 4 :");
            int nb4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nombre 5 :");
            int nb5 = Convert.ToInt32(Console.ReadLine());
            int[] tabMoyenne = new int[] { nb1, nb2, nb3, nb4, nb5 };
            int moyenne = 0;
            for (int i = 0; i < tabMoyenne.Length; i++)
            {
                moyenne += tabMoyenne[i];
            }
            moyenne = moyenne / 5;
            Console.WriteLine("La moyenne est " + moyenne);*/

            // Méthode statique qui calcule la somme des entiers entre x et y, CalculSommeEntiers(x, y)
            // si (x=1 et y=10, somme=55)
            /*static int CalculSommeEntiers(int x, int y)
            {
                int sum = 0;
                for (int i = x; i <= y; i++)
                {
                    sum += i;
                }
                return sum;
            }

            Console.WriteLine("Choisir x :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choisir y :");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Somme = " + CalculSommeEntiers(x, y));*/

            // Méthode statique qui calcule la moyenne d'une liste, CalculMoyenne(liste)
            // (si liste={1.0, 5.5, 9.9, 2.8, 9.6}, moyenne=5.76
            /*static double CalculMoyenne(double[] list)
            {
                double moyenne = 0;
                for(int i = 0; i <  list.Length; i++)
                {
                    moyenne += list[i];
                }
                return moyenne / list.Length;
            }
            double[] list = new double[] { 1.0, 5.5, 9.9, 2.8, 9.6 };
            Console.WriteLine("Moyenne = " + CalculMoyenne(list));*/

            // La dernière méthode devra dans un premier temps construire une liste d'entier de 1 à 100 qui sont des multiples de 3
            // Dans un second temps, construire une autre liste d'entiers de 1 à 100 qui sont des multiples de 5
            // Et dans un dernier temps, il faudra calculer la somme des entiers qui sont communs aux deux listes
            List<int> multipleDe3 = new List<int>();
            List<int> multipleDe5 = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                if(i%3 == 0)
                {
                    multipleDe3.Add(i);
                }
            }
            for (int i = 1; i <= 100; i++)
            {
                if (i%5 == 0)
                {
                    multipleDe5.Add(i);
                }
            }
            List<int> commons = multipleDe3.FindAll(elem => multipleDe5.Contains(elem));
            int sum = 0;
            foreach (int i in commons)
            {
                sum += i;
            }
            Console.WriteLine("Somme = " + sum);

            Console.ReadLine();
        }
    }
}
