using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ListSample1();
            ListSample2();
            DictionarySample1();
            DictionarySample2();
        }
        
        private static void ListSample1()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); // adding elements using add() method
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            var cities = new List<string>();
            cities.Add("New York");
            cities.Add("London");
            cities.Add("Mumbai");
            cities.Add("Chicago");
            cities.Add(null);// nulls are allowed for reference type list

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };

            var students = new List<Student>() {
                new Student(){ Id = 1, Name="Bill"},
                new Student(){ Id = 2, Name="Steve"},
                new Student(){ Id = 3, Name="Ram"},
                new Student(){ Id = 4, Name="Abdul"}
             };

            string[] anothercities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(anothercities);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(popularCities);

            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            Console.WriteLine(numbers[0]); // prints 1
            Console.WriteLine(numbers[1]); // prints 2
            Console.WriteLine(numbers[2]); // prints 5
            Console.WriteLine(numbers[3]); // prints 7

            // using foreach LINQ method
            numbers.ForEach(num => Console.WriteLine(num + ", "));//prints 1, 2, 5, 7, 8, 10,

            // using for loop
            for (int i = 0; i < numbers.Count; i++)
                Console.WriteLine(numbers[i]);

            var numbers1 = new List<int>() { 10, 20, 30, 40 };

            numbers1.Insert(1, 11);// inserts 11 at 1st index: after 10.

            foreach (var num in numbers1)
                Console.WriteLine(num);

            var numbers2 = new List<int>() { 10, 20, 30, 40, 10 };

            numbers2.Remove(10); // removes the first 10 from a list

            numbers2.RemoveAt(2); //removes the 3rd element (index starts from 0)

            //numbers.RemoveAt(10); //throws ArgumentOutOfRangeException

            foreach (var el in numbers2)
                Console.WriteLine(el); //prints 20 30 10

            var numbers3 = new List<int>() { 10, 20, 30, 40 };
            numbers3.Contains(10); // returns true
            numbers3.Contains(11); // returns false
            numbers3.Contains(20); // returns true

            Console.WriteLine(numbers3.Contains(10));
            Console.ReadKey();
        }
        private static void ListSample2()
        {
            List<string> colors = new List<string>();
            //add items in a List collection
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            //insert an item in the list
            colors.Insert(1, "violet");
            //retrieve items using foreach loop
            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
            //remove an item from list
            colors.Remove("violet");
            //retrieve items using for loop
            for (int i = 0; i < colors.Count; i++)
            {
                Console.WriteLine(colors[i]);
            }
            if (colors.Contains("Blue"))
            {
                Console.WriteLine("Blue color exist in the list");
            }
            else
            {
                Console.WriteLine("Not exist");
            }
            //copy array to list
            string[] strArr = new string[3];
            strArr[0] = "Red";
            strArr[1] = "Blue";
            strArr[2] = "Green";
            List<string> arrlist = new List<string>(strArr);
            foreach (string str in strArr)
            {
                Console.WriteLine(str);
            }
            //call clear method
            arrlist.Clear();
            Console.WriteLine(arrlist.Count.ToString());
            Console.ReadKey();
        }

        private static void DictionarySample1()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> kvp in numberNames)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            //creating a dictionary using collection-initializer syntax
            var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
};

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


            Console.WriteLine(cities["UK"]); //prints value of UK key
            Console.WriteLine(cities["USA"]);//prints value of USA key
                                             //Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

            //use ContainsKey() to check for an unknown key
            if (cities.ContainsKey("France"))
            {
                Console.WriteLine(cities["France"]);
            }

            //use TryGetValue() to get a value of unknown key
            string result;

            if (cities.TryGetValue("France", out result))
            {
                Console.WriteLine(result);
            }

            //use ElementAt() to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);
            }

            cities["UK"] = "Liverpool, Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles, Boston"; // update value of USA key
                                                   //cities["France"] = "Paris"; //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }


            cities.Remove("UK"); // removes UK 
                                 //cities2.Remove("France"); //throws run-time exception: KeyNotFoundException

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }

            cities.Clear(); //removes all elements
            Console.ReadKey();
        }
        private static void DictionarySample2()
        {

            Dictionary<string, Int16> AuthorList = new Dictionary<string, Int16>();
            AuthorList.Add("Mahesh Chand", 35);
            AuthorList.Add("Mike Gold", 25);
            AuthorList.Add("Praveen Kumar", 29);
            AuthorList.Add("Raj Beniwal", 21);
            AuthorList.Add("Dinesh Beniwal", 84);
            // Count    
            Console.WriteLine("Count: {0}", AuthorList.Count);
            // Set Item value    
            AuthorList["Neel Beniwal"] = 9;
            if (!AuthorList.ContainsKey("Mahesh Chand"))
            {
                AuthorList["Mahesh Chand"] = 20;
            }
            if (!AuthorList.ContainsValue(9))
            {
                Console.WriteLine("Item found");
            }

            // Read all items    
            Console.WriteLine("Authors all items:");
            foreach (KeyValuePair<string, Int16> author in AuthorList)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                author.Key, author.Value);
            }
            // Remove item with key = 'Mahesh Chand'    
            AuthorList.Remove("Mahesh Chand");
            // Remove all items    
            AuthorList.Clear();
            Console.ReadKey();
        }
    }
}
