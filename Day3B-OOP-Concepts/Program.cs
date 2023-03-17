using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3B_OOP_Concepts
{
     class Program
     {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Day 3B Practice Problem ");
            TypeOfConstructor typeOfConstructor = new TypeOfConstructor();

            TypeOfConstructor parameterConstructor = new TypeOfConstructor("Mahesh", 30);

            TypeOfConstructor copyConstructor = new TypeOfConstructor(parameterConstructor);

            TypeOfConstructor.SampleMessage();

            //ExampleOfPrivetClass exampleOfPrivetClass = new ExampleOfPrivetClass(); // we can not create instance of this class due to Private Constructor
            ExampleOfPrivetClass.employeeName = "Gangurde";
            Console.WriteLine(ExampleOfPrivetClass.DisplayDetails());

            BankManager bankManager=new BankManager();
            bankManager.GetBankDetails();
  
        }
     }
}
