using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Siddhartha;

class Sid {

//     public void learnDataType() {
//         // const int i=10;
//         // Console.WriteLine(i);

//         // string [] name = {"Sid","Raut","Rista","Senpai"};
//         // foreach(string i in name) {
//         //     Console.WriteLine(i);
//         // }
//         // int i=0;
//         // do {
//         //     Console.WriteLine(name[i]);
//         //     i++ ;
//         // }
//         // while(i<name.Length);
//         // for(int i = 0; i < name.Length;i++) {
//         //     if(i==2) {
//         //         break;
//         //     }
//         //     Console.WriteLine(name[i]);
//         // }

//         string name = "siddhartha";
//         Console.WriteLine(name.ToUpper() + name.ToLower());

//     }

//     public void LearnArray() {
//         int [] num = new int[]{1,2,4,5,23,346,6723}; //1
//         int [] num2 = {12,2345,567,234,45,345,0,};

//         int[,] num3 = new int[4,2] {{1,2},{3,4},{5,6},{7,8}};

//         int [] [] jagged = new int[3][];
//         jagged[0] = new int[5]{1,2,3,4,5};
//         jagged[1] = new int[]{0,0};
//         jagged[2] = new int[]{0,0,0,0,0};
//     }

//     public (int,int) MinMax(params int[] ages) {
//         var max = ages.Max();
//         var min = ages.Min();

//         return (max, min);
//     }


      public void LearnCollections() {
        // ArrayList al = new ArrayList();
        // al.Add(23);
        // al.Add(263);
        // al.Add(3);
        // al.Remove(23);
        // Console.WriteLine(al.Count);        
        // Console.WriteLine(al.Capacity);       

        // List<Object> list= new List<Object>();
        // list.Add(23); 
        // list.Add(23325); 
        // list.Add(23234);
        // list.Add(234);
        // list.Add(24);
        // list.Add("Sidd");
        // list.Add(true);
        // list.Remove(23);
        // foreach (object i in list) {
        //     Console.WriteLine(i);
        // }

        // Dictionary<Object,char> dict = new Dictionary<Object,char>();
        // dict.Add(1, 'A');
        // dict.Add(2, 'B');
        // dict.Add(3, 'C');

        // Console.WriteLine(dict[1]);

      }

      public void LearLINQ() {
        // List<int> ints= new List<int>();
        // ints.Add(23);
        // ints.Add(32);
        // ints.Add(34);

        // var results = from s in ints where s%2==0 select s;
        // foreach (var result in results) {
        //     Console.WriteLine(result);
        // }

        int [] num = {12,234,34523,123,4,34};

        var evenNumbers = num.Where(x=>x%2==0);
        // foreach (var evenNumber in evenNumbers) {
        //     Console.WriteLine(evenNumber);
        // }
        var squareNumber = num.Select(x=> x*x);
        // foreach (var number in squareNumber) {
        //     Console.WriteLine(number);
        // }
        var cubeOfOddNumbers = from x in num where x%2!=0 select Math.Pow(x,3);
        foreach (var number in cubeOfOddNumbers) {
            Console.WriteLine(number);
        }

      }

      public void LearnException() {
        int x=0;
        int div=0;
        // div = 100/x;
        // Console.WriteLine($"Result is {div}");
        try {
            div =100/x;
            Console.Write("Not executed line!");
            // throw new DivideByZeroException("Invalid decision");
                    }
        catch(DivideByZeroException) {
            Console.WriteLine("DivideByZeroException");
        }
        finally {
            Console.WriteLine("Finally block!");
        }
        Console.WriteLine($"Result is {div}");
    }

    public void LearnFile() {
        //Creating a file
        // var dirPath = @"./CG_FIleIO";
        // File.WriteAllText($"{dirPath}/sid.txt","Hello Siddhartha");
        // Console.WriteLine("Written succesfully!");

        //Reading a file!
        var dirPath = @"./CG_FIleIO";
        var filePath = $"{dirPath}/sid.txt";
        var result = File.ReadAllText(filePath);
        Console.WriteLine(result);
    }

    public async Task Method1() {

        await Task.Run(()=> {
            for(int i=0;i<10;i++) {
                Console.WriteLine("Method1");
                Task.Delay(100);
            }
        });

    }

    public void Method2() {
        for (int i=0;i<5;i++) {
            Console.WriteLine("Method2");
        }
    }
}



// class IndexerClass {
//     private string [] names = new string[2];

//     public string this [int i] {
//         get {
//             return names [i];
//         }
//         set {
//             names[i] = value;
//         }
//     }
// }

// using System;

// class Students {
//     public string name;

//     public string Name {
//         get{
//             return name;
//         }
//         set { 
//             name = value;
//         }
//     }

//     public int Age {get; set;}
//     public string Address {get; set;}

//     public DateTime Dob {get; set;}

//     public Students() {
//         //default
//     }

//     public Students(string name,int age,string address) {
//         Name = name;
//         Age = age;
//         Address = address;
//     }

//     public Students(string name,int age,string address,DateTime dob):this(name,age,address) {
//         Dob = dob;
//     }

//     public virtual string Display() {
//         return $"My name is {Name} my age is {Age} my address is {Address}";
//     }

//     public void show() {
//         Console.WriteLine("Parent Class");
//     }

// }

// struct Books {
//     public string title;
//     public string author;
// }

// class ComputerStudents :Students,IGradeable {

//     public string Project {get; set;}

//     public ComputerStudents(string name,int age,string address,string project): base(name,age,address) {
//         Project=project;
//     }

//     public double GetGrade() => 4.0;

//     public override string Display()
//     {
//         var prevValue = base.Display();
//         prevValue += $" and the project is {Project} ";
//         return prevValue;
//     }

//     public new void show() {
//         Console.WriteLine("Child Class");
//     }

// }



