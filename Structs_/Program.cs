﻿//using System;
//using System.Collections.Generic;
//using System.Linq;





//public class Program
//{
//    public static void Main(string[] args)
//    {

//        string Brand;
//        int Year;
//        float Price;
//        string Model;


//        Car car1;

//        Console.WriteLine("Input brand:");
//        car1.Brand = Console.ReadLine();
//        Console.WriteLine("Input brand:");
//        car1.Year = int.Parse(Console.ReadLine());
//        Console.WriteLine("Input brand:");
//        car1.Price = float.Parse(Console.ReadLine());
//        Console.WriteLine("Input brand:");
//        car1.Model = Console.ReadLine();





//    }
//    struct Car
//    {
//        public string Brand;
//        public int Year;
//        public float Price;
//        public string Model;


//        //public Car(string Brand)
//        //{
//        //    this.Brand = Brand;
//        //}
//    }

//}





//using System;
//using System.Collections.Generic;
//using System.Linq;





//public class Program
//{
//    struct employee
//    {
//        public string Name;
//        public DtObirth Date;


//    }

//    struct DtObirth
//    {
//        public int Day;
//        public int Month;
//        public int Year;

//        public DtObirth(int Day, int Month, int Year)
//        {
//            this.Day = Day;
//            this.Month = Month;
//            this.Year = Year;
//        }


//    }
//    public static void Main(string[] args)
//    {
//        //Ask the user to input data for 2 users 
//        //store it in an array and point to the struct 

//        int total = 2;

//        Console.WriteLine("Input data for users");
//        Console.WriteLine("---------------------");
//        employee[] emp = new employee[total];

//        for (int i = 0; i < total; i++)
//        {
//            Console.WriteLine("Enter a name:");
//            emp[i].Name = Console.ReadLine();

//            Console.WriteLine("Enter date of birth:");
//            emp[i].Date.Day = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter month of birth:");
//            emp[i].Date.Month = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter year of birth:");
//            emp[i].Date.Year = int.Parse(Console.ReadLine());


//        }

//        foreach (var item in emp)
//        {

//            Console.ForegroundColor = ConsoleColor.Magenta;
//            Console.WriteLine($"{item.Name},{item.Date.Day}");
//            Console.ResetColor();

//        }








//    }

//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;




//        //class MainClass

//        //    //Pass by ref and pass ba value
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Class vs Struct

//        PointStruct structPoint = new PointStruct();



//        structPoint.x = 10;
//        structPoint.y = 10;

//        Console.WriteLine($"Initial pointStruct values are: {structPoint.x} , {structPoint.y}");

//        ModifyStructPoint(ref structPoint);  //method

//        Console.WriteLine($"After modifying struct values are: {structPoint.x} , {structPoint.y}");

//        PointClass classPoint = new PointClass(10, 10);

//        Console.WriteLine($"Initial pointStruct values are: {classPoint.x} , {classPoint.y}");

//        ModifyClassPoint(classPoint); //method

//        Console.WriteLine($"After modifying classPoint, class values are: {classPoint.x} , {classPoint.y}");



//        static void ModifyStructPoint(ref PointStruct newStruct)
//        {   //Passing by value
//            newStruct.x = 20;
//            newStruct.y = 20;

//            Console.WriteLine("Inside ModifyStructPoint()");
//            Console.WriteLine($"Modified struct values are: {newStruct.x} and {newStruct.y}");
//        }

//        static void ModifyClassPoint(PointClass newClass)
//        {  //passing by ref
//            newClass.x = 20;
//            newClass.y = 20;

//            Console.WriteLine("Inside ModifyClassPoint()");
//            Console.WriteLine($"Modified class values are: {newClass.x} and {newClass.y}");
//        }


//    }

//    public struct PointStruct  //stored on the stack memory
//    {
//        public int x;
//        public int y;

//        public PointStruct(int x, int y)
//        {
//            this.x = x;
//            this.y = y;

//        }

//    }
//    public class PointClass //heap memory
//    {
//        public int x;
//        public int y;

//        public PointClass(int x, int y)
//        {
//            this.x = x;
//            this.y = y;
//        }

//    }
//}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;




//class MainClass

//    //Pass by ref and pass ba value
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many people do you wanna have in your array?");
        int total = int.Parse(Console.ReadLine());
        Person[] Person_arr = new Person[total];
        Person_arr[0] = new Person();
        Person_arr[1] = new Person();
        Person_arr[2] = new Person();
        

        for (int i = 0; i < total; i++)
        {
            
            Console.WriteLine($"Enter name for Person {i}");
            Person_arr[i].Name = Console.ReadLine();

            Console.WriteLine($"Enter age for Person {i}");
            Person_arr[i].Age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Enter email for Person {i}");
            Person_arr[i].Email = Console.ReadLine();


        }

        foreach (Person person in Person_arr)
        {
            Console.WriteLine($"{person.Name},{person.Email},{person.Age}");

        }

    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person()
        {
           
        }
    }
}
