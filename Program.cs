using System;

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

Student siddhartha = new();
siddhartha.Name = "Siddhartha Raut";
siddhartha.rollNUmber = 39;
// siddhartha.Dob = DateTime.now;
// siddhartha.PrintInfo();


var deepak = new Student("A",12,"deepak@gmail.com");
// var annayuna = new Student("A",12,"deepak@gmail.com",);
// var x = deepak.Name;

// Console.WriteLine(x);

var rashmi = new CSStudent("rashmi",2,"rashmi@gmail.com","Education Management System");
Console.WriteLine(rashmi.PrintInfo());


// var numbers = new LINQLearner();
// numbers.Learn();