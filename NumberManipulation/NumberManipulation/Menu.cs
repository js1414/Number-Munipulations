using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NumberManipulation
{
    using NumberManipulation;
    internal class Menu
    {
        public void ChoseOption(List<int> numbers)
        {

            int option;
            
            do 
            {
                try
                {

                }
                catch (Exception)
                {
                }
                Console.WriteLine("____________________MENU___________________");
                Console.WriteLine();

                Console.WriteLine("         Please select option (1 - 8):\n");
                Console.WriteLine("           Option 1: Print List:");
                Console.WriteLine("           Option 2: Add Numbers: ");
                Console.WriteLine("           Option 3: Remove First Number");
                Console.WriteLine("           Option 4: Remove Repeting Numbers");
                Console.WriteLine("           Option 5: Remove Even Number(s)");
                Console.WriteLine("           Option 6: Remove Last Number ");
                Console.WriteLine("           Option 7: Remove Number Less or Equal to Two");
                Console.WriteLine("           Option 8: Clear List");
                Console.WriteLine();

                
                Console.Write("Enter Option: ");
                option = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Operations myOp = new Operations();


                switch (option)
                {
                    case 1:
                        Console.Write("Number(s) in the List: ");
                        myOp.PrintList(numbers);
                        Console.WriteLine();
                        break;
                    case 2:
                       Console.WriteLine("Add 3 Numbers: ");
                        myOp.AddNumbers(numbers);
                        myOp.Pause();
                       Console.WriteLine();
                        //myOp.PrintList(numbers);
                        break;  
                    case 3:
                        Console.WriteLine("Remove 1 Element (by index): ");
                        myOp.removeNumbers(numbers);
                        myOp.Pause();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Remove all the two in the List): ");
                        myOp.removeAllOcurences(numbers);
                        myOp.Pause();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Remove Even Number(s): ");
                        myOp.removeEvenNumbers(numbers);
                        myOp.Pause();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Remove Last Number: ");
                        myOp.removeLastElement(numbers);
                        myOp.Pause();
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine("Remove Number(s) Less or Equal to Two ");
                        myOp.RemoveElementInIteration(numbers);
                        myOp.Pause();
                        Console.WriteLine();
                        break;
                    case 8:
                        Console.Write("Clear List\n");
                        myOp.Pause();
                        myOp.clearList(numbers);
                        myOp.PrintList(numbers);
                        //Console.WriteLine("List Cleared");
                        break;
                }
                    
            }

            while(option != 0);
            Console.WriteLine("bye");
            
        }

    }
}