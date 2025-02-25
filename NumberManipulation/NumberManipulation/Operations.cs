using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation
{
    internal class Operations : Program
    {
        public void PrintList(List<int> numbers)
        {
            foreach (int num in numbers)
            {

                //Display  all elements in the list with a space between each other.
                Console.Write(num + " ");

            }
            Console.WriteLine();

            //Display each list value followed by a comma.
            //Console.WriteLine(string.Join(",", numbers));
        }

        //Add value to the list
        public void AddNumbers(List<int> numbers)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number:{i + 1} ");
                int num = int.Parse(Console.ReadLine());

                numbers.Add(num); //Add 3 element in the  list
            }

            Console.WriteLine();
        }
        public void removeNumbers(List<int> numbers)
        {
            //Removing an Element at a Specific Index (RemoveAt)
            // Removes the element at index 0 (3)
            numbers.RemoveAt(0);
        }

        public void removeAllOcurences(List<int> numbers)
        {
            //Removing all ocurences of an element (RemoveAll())
            numbers.RemoveAll(n => n == 2);  //Remove all the 2s
        }

        public void removeEvenNumbers(List<int> numbers)
        {
            //Removing even numbers (RemoveAll())
            numbers.RemoveAll(n => n % 2 == 0);  // Removes the even numbers
        }

        //public void sliceListNumbers(List<int> numbers)
        //{
        //    //var lastThree = numbers.Skip(numbers.Count - 3);
        //    //return lastThree.ToList();
        //    //List<int> slice = new List<int>();
        //    //Removing even numbers(RemoveAll())
        //    numbers.GetRange(0, 3);


        //}

        public void removeLastElement(List<int> numbers)
        {
            //Removing Last number (RemoveAt())
            numbers.RemoveAt(numbers.Count - 1);    // Removes the last element
        }

        public void RemoveElementInIteration(List<int> numbers)
        {
            //Removing Elements While Iterating (Where().ToList())
            numbers.RemoveAll(n => n <= 2);   // Remove elements less or equal to 2

            //Where(n => n > 2) filters the list and creates a new list.
        }

        public void removeElementForLoop(List<int> numbers)
        {
            //Removing Elements Using a for Loop(Best for Large Lists)
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 2) //Remove numbers 2
                {
                    numbers.RemoveAt(i);
                }
            }
        }
        public void clearList(List<int> numbers)
        {
            if(numbers.Count == 0)
            {
                Console.WriteLine("Sorry, List is Empty");
                //Console.WriteLine("List Cleared");
            }

            //Clearing the Entire List (Clear)
            numbers.Clear();
            Console.WriteLine("List Cleared");
        }

        public void Pause()
        {
            Console.WriteLine("Updating List.......");
            Thread.Sleep(3000);
            Console.WriteLine();
            //Console.WriteLine("List Updated Successfully!");
        }

        public void generateRandomNumber(List<int> numbers)
        {
           Random rnd = new Random();

            for(int i = 0;i < 5; i++)
            {
                numbers.Add((int)rnd.Next(1, 100));
                
            }

            Console.WriteLine("5 numbers have been genatated");
            Console.WriteLine();
            
        }
        //public void inputNumber(List<int> numbers)
        //{
        //    // Adding example values to the list
        //    numbers.Add(10);
        //    numbers.Add(20);

        //    Console.WriteLine("Running program...");
        //    Console.WriteLine("Numbers in the list:");
        //    foreach (int num in numbers)
        //    {
        //        Console.WriteLine(num);
        //    }
    }
}   

    
