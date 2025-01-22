using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading;

namespace Myfirstproject
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //long age = 23000000l; //automatically int by default, add in an l
            //float age = 2.33F; //F for float, automatically double by defaut
            //decimal money = 14.99M; // M for decimal
            //string name = "25"; //string and char are the same as C, C++
            //Convert.ToInt32(name);
            //string age = "2.33";
            //Convert.ToSingle(age);
            //string age = "Abdul";
            //age += " Is learning C#"; //the same may be done for chars but then their unicode values are added and the relevant char is printed
            //var bruv = 23; //var automatically decides which type it is, specify L for long, M for decimal, F for float ofcoursse but dont use unless the type is obv
            //Convert.ToDouble(age);
            //const works the same as c++
            //Console.WriteLine(age);
            //Console.Write("Enter your department name: ");
            //string dep = Console.ReadLine(); //readline returns a string type always, you may convert whenever you want after reading the string
            //Console.Write("Enter your Student ID: ");
            //string iD = Console.ReadLine();
            //Console.WriteLine("Your department is "+dep+" and your student iD is "+iD);
            //Console.ReadLine();
            //if else structure stays the same
            //switch statements, for loop, while loop, conditional operators all stay the same
            //double money = -10D / 3D; //just some tricks to print currencies, nothing relevant
            //Console.WriteLine(money);
            //Console.WriteLine(string.Format("${0}", money));
            //Console.WriteLine(money.ToString("C5"));
            //Console.WriteLine(money.ToString("C5", CultureInfo.CurrentCulture));
            //Console.WriteLine(money.ToString("C5", CultureInfo.CreateSpecificCulture("en-GB")));

            //string speech = "He said\"something\""; //back slash can be outputted by double back slash
            //Console.Write(speech);
            //string name = "abdul"; //the @ before teh string makes sure the /, /n and /t are not given special functio, just taken as they are 
            //int age = 20;
            //Console.WriteLine($"My name is {name} and my age is {age}");
            //Console.WriteLine("My name is {0} and my age is {1}", name, age);
            //Console.ReadLine();
            // "" is the same as string.empty
            // == operator checks both value and address while string1.equals(string2) compares only the value, the latter is useful when comparing different types but same values
            // string.Length - obv
            string message = "My name is ehhhhh abdul";
            if (!string.IsNullOrEmpty(message)) //good practice to avoid accessing fields of null string
            {
                for (int i = 0; i < message.Length; i++)
                {
                    Console.Write(message[i]);
                    Thread.Sleep(50);
                }
            }
            Console.ReadLine();
        }
    }
}

namespace HelloWorld
{
    public class Program
    {
        // struct Person
        // {
        //   public string name;
        //   public int age;

        //   public Person(string name, int age)
        //   {
        //     this.name = name;
        //     this.age = age;
        //   } //for structs, a constructor cannot have no parameters

        // }
        class Person
        {
            private string name;
            private int age;

            //or auto properties that basically defines the private
            variable for you :

        // public string Name {get; set;}
        // public int Age {get; set;}

        // public string Name //class property, a middle man to access private variables
         // {
         //   get
         //   {
         //     return name;
         //   }
         //   set
         //   {
         //     name = value;
         //   }
         // }
         public string Name { get => name; set => name = value; }
            //alternative property syntax preferred when there is no additional logic

            //public int Age
            //{
            //  get
            //  {
            //    return age;
            //  }
            //  set
            //  {
            //    age = value;
            //  }
            //}

            public int Age { get => age; set => age = value; } //value is a default keyword that is basically representing whatever actual value you are setting into the field

          public Person()
            {
            }

            public Person(int age)
            {
                this.age = age;
                this.name = "";
            }

            public Person(int age, string name)
            {
                this.age = age;
                this.name = name;
            }

            public override bool Equals(object obj) //operator overloading in C#
         {
           if(obj is Person)
           {
             Person person = obj as Person;
             return (Name.Equals(person.Name) && Age == (person.Age));//cast type of obj to Person if it is Person
           }
           return false;
         }

}

public static void Main(string[] args)
{
    // Console.WriteLine("No");
    // int[] my_arr = new int[]
    // {
    //   1,2,10,4,5
    // };
    // Array.Sort(my_arr);
    // //also Array.Reverse(var_name);
    // //Array.Clear(array_name, start_index, length to go till); resets the values in the array to their default acc to type, default is a valid keyword
    // //Array.IndexOf(array_name, search_el, start_index, end_index) returns positions if found else -1
           // foreach(int num in my_arr)
           // {
           //   Console.Write($"{num} ");
           // }
           //string functions return a new string but array functions return void and change the actual array
             //   List<int> mylist = new List<int>(); //vector equivalent of C#
             //   Dictionary<int, int> mydict = new Dictionary<int, int> ();
             //dict for C#, has its own many functions ez
             //   mylist.Add(1);
             //   mylist.Add(2);
             //   for (int i =0; i<mylist.Count; i++)
             //   {
             //     Console.Write($"{mylist[i]} ");
             //   }
             // int xd = 67;
             // myfunc(out int num);
             // Console.WriteLine(num);
             // myfunc2(ref xd);
             // Console.WriteLine(xd);
            Person myself = new Person(20, "Moiz");
            Person dopple = new Person(20, "Moiz");
            if (myself.Equals(dopple)) Console.WriteLine("same");
            else Console.WriteLine("Not same");
            // myself.age = 20;
            Console.ReadLine();

}
//function return values and parameters work the same but there is usage of static and public a lot, static means the function usage does not need to be initialized first, it can be called direcrtly
           //to pass by reference, there are two ways, out keyword or ref keyword, for out keyword, the variable may be assigned during  passing and it needs to be altered inside the passed function since the out keyword basically means that variable is going to be outputted


        public static void myfunc(out int num)
{
        num = 5;
        return;
}
public static void myfunc2(ref int num)
{
    num = 100;
    return;
}
     }
}          //unlike c++ the out and ref keywords must be used both in the parameters and in the arguments