using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration
{
    class Program
    {


        static void Main()
        {
            {
                string[] array1 = new string[5];
                // for loop for taking input from user and add it to the array
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine("enter input to array1");
                    array1[i] = Console.ReadLine();

                }
                Console.WriteLine("---------------------------------------");
                //for loop for printing array
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }
                Console.Read();
                Console.WriteLine("----------------------------------------");
                //creating infinit loop    
                // int k = 0;

                //   do
                // {
                //   console.writeline(array1[k]);

                //}
                //while (k < array1.length);
                Console.WriteLine("----------------------------------------");
                //resolving infinit loop    
                int j = 0;

                do
                {
                    Console.WriteLine(array1[j]);
                    j++;
                }
                while (j < array1.Length);
                Console.Read();
                Console.WriteLine("--------------------------------------");

                //4. creating loop where the comparison used to determine whether to continue iterating the loop is a “<” operator.
                int[] array2 = new int[] { 2, 4, 12, 45, 67, 34, 89, 54 };
                for (int k = 0; k < array2.Length; k++)
                {
                    if (array2[k] < 45)
                    {
                        Console.WriteLine(array2[k]);
                    }
                }

                Console.WriteLine("--------------------------------------");
                //creating loop where the comparison used to determine whether to continue iterating the loop is a “<=” operator.
                for (int l = 0; l < array2.Length; l++)
                {
                    if (array2[l] <= 45)
                    {
                        Console.WriteLine(array2[l]);
                    }
                }

                Console.WriteLine("--------------------------------------");
                //creating list of string. iterate list and display index of list which match specific search in list.
                List<string> searchlist = new List<string>() { "lion", "fox", "elephant", "tiger", "deer" };
                //adding code that tells a user if they put in text that isn’t in the list.
                Console.WriteLine("you want to add extra that not in list");
                string extra = Console.ReadLine();
                searchlist.Add(extra);
                Console.WriteLine("enter text for search for in list");
                string text = Console.ReadLine();
                foreach (string item in searchlist)
                {
                    Console.WriteLine(item);
                    if (item == text)
                    {
                        Console.WriteLine(searchlist.IndexOf(item));
                        break;//adding break so it will come out of the loop once match found
                    }

                }


                //creating list of string which has two identical string and it will return idices of  array that contain matching text on the scree
                List<string> matchitemlist = new List<string>() { "milk", "fruits", "meat", "egg", "fruits", "juice" };
                //adding code that tells a user if they put in text that isn’t in the list.
                Console.WriteLine("you want to add extra that not in list");
                string extra1 = Console.ReadLine();
                matchitemlist.Add(extra1);
                Console.WriteLine("enter text for searchfor in list");
                string text1 = Console.ReadLine();
                if (!matchitemlist.Contains(text1))
                {
                    Console.WriteLine("There was an error. Please only search from the given list ");
                    //continue;
                }
                else
                {
                    Console.WriteLine("You selected " + text1 + ". The indices of that veggie are: ");
                    for (int i = 0; i < matchitemlist.Count; i++)
                    {
                        if (matchitemlist[i] == text1)
                        {
                            Console.WriteLine(i);

                        }
                    }
                }



                Console.Read();


                List<string> findingduplicateitemList = new List<string>() { "Milk", "Fruits", "Meat", "Egg", "Fruits", "Juice" };
                var mylist = new List<int>();
                var duplicates = findingduplicateitemList
                 .GroupBy(i => i)
                .Where(g => g.Count() > 1)
                 .Select(g => g.Key);
                foreach (string item in findingduplicateitemList)
                {
                    Console.WriteLine(item);
                    if (duplicates.Count() > 0)
                    {

                        foreach (var dupe in duplicates)
                        {
                            Console.WriteLine(dupe + "\t This item already exists.");
                        }
                    }


                    Console.Read();
                }

            }
        }
    }
}