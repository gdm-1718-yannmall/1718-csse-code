using System;
using System.Collections.Generic;

namespace opdrachtweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int vermenigvuldigtal;
            //Declare a List
            List<String> tafelsList = new List<String>();
            //Declare an Array
            String[] tafelsArray = new String[11];
            //Declare a Dictionary
            Dictionary<int, String> tafelsDictionary = new Dictionary<int, String>();
            
            //Ask user for number and convert it to Int32
            Console.Write("Vermenigvuldigtal: ");
            vermenigvuldigtal = Convert.ToInt32(Console.ReadLine());
            
            Vermenigvuldiging(tafelsList, tafelsArray, tafelsDictionary, vermenigvuldigtal);

            PrintCollections(tafelsList, tafelsArray, tafelsDictionary);
            

        }

        private static void Vermenigvuldiging(List<String> list, String[] array, Dictionary<int, String> dictionary, int getal){
            Console.WriteLine("\nVermenigvuldigingstafel:\n");
            for(int i = 0; i < 11; i++){
                int uitkomst = i * getal;
                String vermenigvuldiging = i + " x " + getal + " = " + uitkomst;
                Console.WriteLine(vermenigvuldiging);

                AddToCollections(list, array, dictionary, i, vermenigvuldiging);
            }
        }

        private static void AddToCollections(List<String> list, String[] array, Dictionary<int, String> dictionary, int i, String x){
            //Add to List
            list.Add(x);
            //Add to Array
            array[i] = x;
            //Add to Dictionary
            dictionary.Add(i, x);
        }

        private static void PrintCollections(List<String> list, String[] array, Dictionary<int, String> dictionary){
            Console.WriteLine("\n================= LIST =================");
            foreach (String item in list){
                Console.WriteLine(item);
            }

            Console.WriteLine("\n================= ARRAY =================");
            foreach (String item in array){
                Console.WriteLine(item);
            }

            Console.WriteLine("\n================= DICTIONARY =================");
            foreach (var item in dictionary){
                Console.WriteLine(item.Value);
            }
        }
    }
}
