// Linq -> language Integrated queries

using System;
using System.Collections.Generic;
using System.Linq;

class LINQLearner
{

    public void Learn()
    {
        int[] numbers = [2, 3, 5456, 56, 76];
        // Student s1 = new("Ram",12,"ram@gmail.com");
        List<Student> students= [
            new("Ram",12,"ram@gmail.com"),
            new("Shyam",53,"shyam@gmail.com"),
            new("Geeta",14,"geeta@gmail.com"),
            new("Rista",44,"geeta@abc.com"),
        ];

        var evenNumbers = numbers.Where(number => number % 2 == 0);
        var squareNumbers = numbers.Select(number => number*number);

        //Method syntax
        var cubeOfOddNumber = numbers.Where(number => number %2 !=0).Select(num => Math.Pow
        (num,3));
        //Expresssion syntax

        var cubes= from num in numbers where num%2==1 select Math.Pow(num,3);


        var stduentsRollNumberLessThan50 = students.Where(student => student.rollNUmber<50).OrderBy(student=> student.Name);

        //group all sudent by email domain

        var groupStudents = students.GroupBy(stud=> stud.Email[(stud.Email.IndexOf('@')+1)..]); //spread operator

        foreach(var student in groupStudents) {
            Console.WriteLine($"Domain name: {student.Key} ");
            foreach(var stud in student) {
                Console.WriteLine($"\t\t{stud.PrintInfo()}");
            }
        }

        // for(byte i=0;i<cubeOfOddNumber.length;i++);
    }
}