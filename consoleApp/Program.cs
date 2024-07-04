// using HelloWorld;
// using Practicing;
// using System;

// Console.WriteLine("sdff");

// DataTypes types = new();
// DataTypes types = new();
// types.LearnDataType();

// Console.WriteLine("");

// Methods method = new();
// method.Print();
// int[] ages  = [23,21,45,20];

// Console.Write(method.CalculateBMI(5.10f,82.0f));
// (int youngest,int eldest) = method.MinMax(2,3,4,5,6,7,8,9);

// Console.Write(method.MinMax(ages));

// Generics<decimal> g = new();

// g.Add(2.4f,5.6f);
// g.Add(2,5);
// g.Add<bool>(true,false);

// Student siddhartha = new();
// siddhartha.Name = "Siddhartha Raut";
// siddhartha.rollNUmber = 39;
// siddhartha.Dob = DateTime.Now;
// siddhartha.PrintInfo();


// var deepak = new Student("A",12,"deepak@gmail.com");
// var annayuna = new Student("A",12,"deepak@gmail.com",);
// var x = deepak.Name;

// Console.WriteLine(x);

// var rashmi = new CSStudent("rashmi",2,"rashmi@gmail.com","Education Management System");
// Console.WriteLine(rashmi.PrintInfo());

// ProjCollections proj = new();
// proj.LearnCollections();


// var numbers = new LINQLearner();
// numbers.Learn();

// FileHandling fd = new();
// fd.CreateFile();
// fd.ReadFile();


//Practice

// Programs pr = new();
// pr.getValue();
// int i=20;
// Console.WriteLine("Value is={0}",i);
// pr.PassByValue(ref i);
// Console.WriteLine("Value is={0}",i);
// pr.Add(3,4);
// pr.Arrays();
// pr.Jagged();
// pr.GenericsInAction();
// pr.LearnLinq();

// Practices prac = new();
// prac.show();
// int [] ages = { 1, 2, 3,};
// Console.Write(prac.MinMax(ages));
// prac.LearnArray();

using System;
// using Siddhartha;

// Sid sid = new();
// sid.learnDataType();

// int [] ages = {32,12,45,56,32,43,67};
// var (result1,result2) = sid.MinMax(ages);
// Console.WriteLine(result1);
// Console.WriteLine(result2);

// IndexerClass team = new();
// team[0] = "Sid";
// team[1] = "Rista";

// int i=0;
// while(i<2) {
//     Console.WriteLine(team[i]);
//     i++;
// }

// ComputerStudents sid = new ComputerStudents("Siddhartha",22,"Lagankhel","Rest API Development");

// Console.WriteLine(sid.Address);
// Console.Write(sid.Display());
// sid.show();

// Books book1;
// book1.title = "Harry Potter";
// book1.author = "J.K Rowling";

// Console.WriteLine(book1.title + " " + book1.author);

using Siddhartha;
Sid sid = new();

// sid.LearLINQ();
// sid.LearnFile();
sid.Method1();
sid.Method2();

