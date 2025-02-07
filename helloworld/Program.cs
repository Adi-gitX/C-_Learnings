// this is Collectinformation management programe!

using System;

namespace Collectingmyinformation{

    class Collectinformation{

        static void Main(){

            string name;
            int age;
            string address;
            string college;
            string addmoreinfo;

            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Your Age:");
            age = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Address: ");
            address = Console.ReadLine();

            Console.Write("Enter Your College: ");
            college = Console.ReadLine();

            Console.Write("you want to add any more info: ");
            addmoreinfo = Console.ReadLine();


            // this is to display all collected information
            Console.WriteLine("\nHello " + name + ", these are your details:"); 
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("College: " + college);
            Console.WriteLine("Add more info:" + addmoreinfo);
        }
    }
}


This is typeconversion conversion System!
using System;

namespace Typeconversionfromdoubletoint{

    class typeconversion{

        static void Main(){

            double mydoublenumber= 1000.999;
            int myintnumber;

            myintnumber = (int)mydoublenumber;
            Console.WriteLine("My Double Number is: " + mydoublenumber);
            Console.WriteLine("My Int Number is: " + myintnumber);
        }
    }
}

// this is the program for operators
using System;

namespace usingoperators
{
    class operatorsProgramme
    {
        static void Main()
        {

            int a = 10;
            int b = 30;

            // working with the operations basic
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int divide = a / b;
            int reminder = a % b;

            //this is to display the working process
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Console.WriteLine("Sum of a,b: " + sum);
            Console.WriteLine("difference of a,b: " + difference);
            Console.WriteLine("product of a,b: " + product);
            Console.WriteLine("division of a,b: " + divide);
            Console.WriteLine("reminder of a,b: " + reminder);


        }

    }
}

using System;

namespace desisionmaking{
    
    class ifelsestatements{

        static void Main(){

            int a;
            int b;

            Console.Write("Enter the value of a: " );
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of b: " );
            b = int.Parse(Console.ReadLine());

            if(a>b){
                Console.WriteLine("a is greater than b");
            }
            else{
                Console.WriteLine("b is greater than a");
            }
        }
    }
}

// This is for the loops
using System;

namespace workingonloops
{
    class Loops
    {
        static void Main()
        {
            int a;

            Console.Write("Enter the value of a: ");
            a = int.Parse(Console.ReadLine());

            // an example for For Loop:
            Console.WriteLine("For Loop: ");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("i: " + i);
            }

            // example for while loop:
            Console.WriteLine("While Loop: ");
            int j = 0;
            while (j < a)
            {
                Console.WriteLine("j: " + j);
                j++;
            }

            // example for do while loop:
            Console.WriteLine("Do-While Loop: ");
            int k = 0;
            do
            {
                Console.WriteLine("k: " + k);
                k++;
            } while (k < a);
        }
    }
}


using System;
using System.IO.Pipelines;

namespace encapsulation{

    class PersonDetails{

        // private: can be accessed only insede the main class PersonDetails!    
        private string name;

        // public: can be accessed from any class!
        public int age;

        // protected: can be accessed only in the same class and the derived class!
        protected string address;

        // internal: can be accessed only in the same assembly!
        internal string college;

        // public method to set the name 
        public void SetName(string name){
            this.name = name;
        }

        // public method to get the name
        public string GetName(){
            return name;
        }

        // public method to set the address
        public void SetAddress(string address){
            this.address = address;
        }

        // public method to get the address
        public string GetAddress(){
            return address;
        }

    
    }
    class encapsulation{

        static void Main(){
            
            // obj of person details!
            PersonDetails person = new PersonDetails();

            // setting the name,age and address!
            person.SetName("Aditya kammati");
            person.age = 20;
            person.SetAddress("Hyderabad");
            person.college = "Newton School Of Technology";

            // displaying the details!
            Console.WriteLine("Name: " + person.GetName());
            Console.WriteLine("Age: " + person.age);
            Console.WriteLine("Address: " + person.GetAddress());
            Console.WriteLine("College: " + person.college);
        }
    }
}


using System;

namespace CalculatorApplication{

    class FindingmaximumNumber{

        public int findMax(int number1 , int number2){
            int result;

            if(number1 > number2){
                result = number1;
            }
            else{
                result = number2;
            }
            return result;
        }

        static void Main(){
            int a = 100;
            int b = 200;
            int result;

            FindingmaximumNumber obj = new FindingmaximumNumber();
            result = obj.findMax(a,b);
            Console.WriteLine("Maximum Number is: " + result);
        }
        

    }

}


using System;

namespace defineNullables{
    
    class Nullables{

        static void Main(){

            int? num1 = null; // here the value of num1 can be null or can be assigned a value of int!
            int? num2 = 45; // here the value of num2 is assigned a value of 45!

            double? num3 = new double?();
            double? num4 = 3.14159;

            bool? boolval = new bool?();

            // display the values
            Console.WriteLine("Value of num1: {0}", num1); // the {0} will be replaced by the num1 when exicuted!
            Console.WriteLine("Value of num2: {0}", num2);
            Console.WriteLine("Value of num3: {0}", num3);
            Console.WriteLine("Value of num4: {0}", num4);
            Console.WriteLine("Value of boolval: {0}", boolval);
        }
    }

}
using System;

namespace CheckingTheArray{
    class Array
    {
        static void Main()
        {
            Console.Write("enter the number of elements to display in the array: ");
            int N = int.Parse(Console.ReadLine());

            int[] a = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write($"Enter the value for element {i + 1}: "); // here $ in C# i an interpolated string, which is used to display the value of the variale in the string!
                a[i] = int.Parse(Console.ReadLine());
            }
            //This is teh old casual method to display all the elements in the array!

            // Console.WriteLine("\nThe elements in the array are: ");
            // for (int i = 0; i < N; i++)
            // {
            //     Console.WriteLine(a[i]);
            // }

            Console.WriteLine("\nThe elements in the array are: [{0}]", string.Join(", ", a)); // this will display the elements in the array! the string.join allows the elements to be in one line 
        }
    }
}


using System;

namespace StringApplicationdemo{

    class StringApplication{

        static void Main(){

            string str1 = "Hello";
            string str2 = "World";
            string str3;
            int len;

            str3 = String.Concat(str1,str2);
            Console.WriteLine("Concatenation: " + str3);

            len = str3.Length;
            Console.WriteLine("Length of the string: " + len);

            str3 = str3.ToUpper();
            Console.WriteLine("Uppercase: " + str3);

            str3 = str3.ToLower();
            Console.WriteLine("Lowercase: " + str3);

            Console.ReadKey();
            
        }
    }
}

// thsi is the program for the structure!
using System;

namespace DefininStructure
{
    struct Books
    {
        private string title;
        private string author;
        private string subject;
        private int bookId;

        public void getValues(string T, string A, string S, int B)
        {
            title = T;
            author = A;
            subject = S;
            bookId = B;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Subject: " + subject);
            Console.WriteLine("BookID: " + bookId);
        }
    }

    class TestStructure
    {
        static void Main() 
        {
            Books book1 = new Books();
            Books book2 = new Books();

            // Input for Book1
            Console.WriteLine("Enter Details of Book1: ");
            Console.Write("Title: ");
            string title1 = Console.ReadLine();

            Console.Write("Author: ");
            string author1 = Console.ReadLine();

            Console.Write("Subject: ");
            string subject1 = Console.ReadLine();

            Console.Write("BookId: ");
            int bookId1 = int.Parse(Console.ReadLine()); 

            book1.getValues(title1, author1, subject1, bookId1);

            // Input for Book2
            Console.WriteLine("Enter Details Of Book2: ");
            Console.Write("Title: ");
            string title2 = Console.ReadLine();

            Console.Write("Author: ");
            string author2 = Console.ReadLine();

            Console.Write("Subject: ");
            string subject2 = Console.ReadLine();

            Console.Write("BookId: ");
            int bookId2 = int.Parse(Console.ReadLine());

            book2.getValues(title2, author2, subject2, bookId2);

            // Display the details of both books
            Console.WriteLine("\nDetails of Book1:");
            book1.Display();

            Console.WriteLine("\nDetails of Book2:");
            book2.Display(); 
        }
    }
}

encapsulation is the proces of wrapping 
This is an example of Enum! this is used to define the constants!
using System;

namespace usingEnum{

    class EnumProgramme{

        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat};

        static void Main(){

            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;

            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
  

        }
    }
}

using System;

namespace usingString{

    class StringPrograme{

        static void Main(){

            String str1 = "aditya";
            String str2 = "kammati";
            String str3;

            str3 = String.Concat(str1,str2);

            Console.WriteLine("Joined: "+ str3);

        }
    }
}


using System;

namespace DateandTimeMessage{

    class DateAndTime{

        static void Main(){

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Display the current date and time,HEre i have used ToString() method date and time to string and display only date or only time!
            Console.WriteLine("Date and Time: ");
            DateTime now = DateTime.Now;
            Console.WriteLine("Date: " + now.ToShortDateString());
            Console.WriteLine("Time: " + now.ToShortTimeString());
        }

    }
}


using System;

namespace ClassesBoxApplication{
    class box{
        public double length; // its the lenght of the box
        public double breadth; // its the breadth of the box
        public double height; // its the height of the box
    }

    class testBox{
        static void Main(){
            box box1 = new box();
            box box2 = new box();
            double volume = 0.0; //Setting the volume of the box to 0.0! initilizing the value set!

            // box1 specification
            Console.WriteLine("Enter the details of Box1:");
            Console.Write("Enter the length: ");
            box1.length = double.Parse(Console.ReadLine());

            Console.Write("Enter the breadth: ");
            box1.breadth = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            box1.height = double.Parse(Console.ReadLine());

            // box2 specification
            Console.WriteLine("Enter the details of Box2: ");
            Console.Write("Enter the length: ");
            box2.length = double.Parse(Console.ReadLine());

            Console.Write("Enter the length: ");
            box2.breadth = double.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            box2.height = double.Parse(Console.ReadLine());

            // volume of box1
            volume = box1.length * box2.breadth * box1.height;
            Console.WriteLine("Volume of Box1: "+volume);

            //volume of box 2 
            volume = box2.length * box2.breadth *box2.height;
            Console.WriteLine("Volume of Box2: "+volume);

            
        }

    }

}

Example for inheritance! inheritance is a mechanism in which one class acquires the property of another class!
a simple inheritance example!

using System;

namespace InheritanceApplication{

    class shape{
        public void setWidth(int w){
            width = w;
        }
        public void setHeight(int h){
            height = h;
        }
        protected int width;
        protected int height;

    }
    class Rectangle: shape{
        public int getArea(){
            return (width * height );
        }

    }

    class TestRectangle{
        static void Main(){
            Rectangle rect = new Rectangle();

            Console.WriteLine("Enter the details of rectangle: ");

            Console.Write("Enter the width: ");
            int w = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the Height: ");
            int h = int.Parse(Console.ReadLine());

            rect.setWidth(w);
            rect.setHeight(h);

            Console.WriteLine("Total Area: " + rect.getArea());

        }
    }


}

implementing polymorphism, polymorphism is the ability to present the same interface for different data types!
in simple words polymorphism allows you to define one interface and have multiple implementations!
interface in simple terms is a contract that defines the signature of the method, properties, events or indexers!

simple example for polymorphism!
namespace polymorphismApplication{ 

    abstract class Shape {
        public abstract int Area();
    }

    class Rectangle : Shape {
        private int length;
        private int width;

        public Rectangle(int a = 0, int b = 0) {
            length = a;
            width = b;
        }

        public override int Area() {
            Console.WriteLine("Rectangle class area: ");
            return width * length;
        }
    }

    class Triangle : Shape {
        private int base1;
        private int height;

        public Triangle(int a = 0, int b = 0) {
            base1 = a;
            height = b;
        }

        public override int Area() {
            Console.WriteLine("Triangle class area: ");
            return (base1 * height) / 2;
        }
    }

    class TestShape {
        static void Main() {
            Console.WriteLine("Enter The Details Of Rectangle: ");

            Console.Write("Enter the length:");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            int width = int.Parse(Console.ReadLine());

            Rectangle rect = new Rectangle(length, width);
            Console.WriteLine("Total Area of Rectangle: " + rect.Area());

            Console.WriteLine("Enter the details of Triangle: ");

            Console.Write("Enter the base: ");
            int base1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the height: ");
            int height = int.Parse(Console.ReadLine());

            Triangle tri = new Triangle(base1, height);
            Console.WriteLine("Total Area of Triangle: " + tri.Area());
        }
    }
}

interface example! interface is a contract that defines the signature of the method, properties, events or idexes!
interface is a refrence typr in c# and it is similar to classes but it is a collecttion of abstract classes, the difference from class is that it cannot have implementation!

using System;

namespace interfaceApplication{
    
    public interface PaintCost{
        int getCost(int area);
    }

    class Rectangle : PaintCost{
        public int getCost(int area){
            return area * 70;
        }
    }

    class TestInterface{
        static void Main(){
            Rectangle rect = new Rectangle();
            int area = 500;
            Console.WriteLine("Total cost for painting the rectangle: " + rect.getCost(area));
        }
    }
}

namespace simple hello world function!, Namespace is a way to organise the code in a logical manner!, it is used to resolve the name conflit between the classes when there is asame class name in different namespaces!
using System;

namespace NamespacePrograme{
    
    class Namespace {
        static void Main(){
            Console.WriteLine("Hello World");
        }
    }
}

Function Overloading is a feature that allows creatig multiple methods in the same class witth the same name but with different parameters!

using System;

namespace functionOverloading{

    class FunctionOverLoading{
        public int Add(int a, int b){
            return a+b;
        }

        public int Add(int a, int b, int c){
            return a+b+c;
        }

        static void Main(){
            FunctionOverLoading obj = new FunctionOverLoading();
            Console.WriteLine("Addition of two numbers: " + obj.Add(10,20));
            Console.WriteLine("Addition of three numbers: " + obj.Add(10,20,30));

        }
    }
}


Classes - Concrete class, Abstract class, Static class
instantiation - creating an object of a class
inheritance - a class can inherit the properties and methods of another class
Concrete class is a normal class that can be instantiated and can be inherited by other classes.
Abstract class is a class that cannot be instantiated and can be inherited by other classes.
Static class is a class that cannot be instantiated and cannot be inherited by other classes.
The difference between abstract class and concrete class is that abstract class cannot be instantiated and concrete class can be instantiated.
The difference between abstract class and interface is that abstract class can have implementation of methods and properties but interface cannot have implementation of methods and properties.

Exceptional Handling 
Exception Handling is a mechanism to handle runtime errors. It is maintained by the System.Exception Class!
simple Example for Exceptional Handling!

using System;

namespace ExceptionalHandling{

    class ExceptionalHandling{
        static void Main(){
            int a = 10;
            int b = 0;
            int result;

            try{
                result = a/b;
            }
            catch{
                Console.WriteLine("Division By Zero Is Not Allowed!");
            }
            finally{
                Console.WriteLine("Finally Block is Executed!");
            }
            throw new Exception("when there is an error!");
        }

    }
}

examples for collection: array list , hashtable , sorted list, stack, queue, bitArray 

using System;

namespace CollectionProgram{

    class CollectionProgram{
        static void Main(){
            // Array List
            System.Collections.ArrayList al = new System.Collections.ArrayList();
            al.Add(100);
            al.Add(200);

            Console.WriteLine("ArrayList");
            Console.WriteLine("Value at the index 0 is: "+ al[0]);//here [0] is the index of the array list 

            //hash Table
            System.Collections.Hashtable ht = new System.Collections.Hashtable();
            ht.Add("001", "Aditya");

            Console.WriteLine("HashTable");
            Console.WriteLine("Value at the index 001 is: "+ ht["001"]);


            //SortedList
            System.Collections.SortedList sl = new System.Collections.SortedList();
            sl.Add("001", "Aditya");

            Console.WriteLine("SortedList");
            Console.WriteLine("Value at the index 001 is :" + sl["001"]);

            //Stack
            System.Collections.Stack st = new System.Collections.Stack();
            st.Push("Aditya");
            st.Push("kammati");

            Console.WriteLine("stack");
            Console.WriteLine("Top value of the stack is : " + st.Peek());

            //Queue
            System.Collections.Queue q = new System.Collections.Queue();
            q.Enqueue("Aditya");
            q.Enqueue("kammati");

            Console.WriteLine("Queue");
            Console.WriteLine("First value of the queue is: " + q.Peek());

            //BitArray
            System.Collections.BitArray ba = new System.Collections.BitArray(3);
            ba.Set(0, true);
            ba.Set(1, false);

            Console.WriteLine("BitArray");
            Console.WriteLine("Value of the bit array at index 0 is: " + ba.Get(0));

        }

    }
}

generics is a feature which allows us to define a class or a method with placeholder for the datatype

using System;

namespace GenericsProgeam{

    class GenericsProgeam{

        static void Main(){

            //first step declaring the generic class
            Generics<int> g1 = new Generics<int>(10);
            g1.Write();

            Generics<string> g2 = new Generics<string>("Hello");    
            g2.Write();

        }
    }
}



















