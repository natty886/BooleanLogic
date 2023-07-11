using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Approval");

            Console.WriteLine("Please press Enter and answer the following questions.");

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?");
            string dui = Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());


            //Applicants must be over 15 years old.
            int qual1 = 15;
            //Applicants must not have any DUI’s.
            string qual2 = "false";
            //Applicants must not have more than 3 speeding tickets.
            int qual3 = 3;

            Console.WriteLine("Applicant qualified?");
            bool result = (qual1 < age && (qual2 == dui && qual3 > tickets));
            Console.WriteLine(result);
            Console.ReadLine();
            //AND = Are both of these TRUE?
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);

            //OR = Are one of these TRUE?
            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);
            //Console.ReadLine();

            //EQUAL = Does TRUE equal TRUE?
            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //NOT EQUAL = Does TRUE NOT equal TRUE?
            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //XOR = Does one equal but not all?
            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

        }
    }
}
