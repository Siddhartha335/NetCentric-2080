using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld;

class Programs {

    // public void GetValue() {
    //     Console.WriteLine("Sid!");
    // }

    // public void PassByValue(ref int i) {
    //     i=90;
    //     System.Console.WriteLine("Value is={0}",i);
    // }

    public void Add() {
        Console.WriteLine("Adding function");
    }
    public void Add(int a, int b) {
        int res = a+b;
        Console.WriteLine(res);
    }

    // public void Arrays() {
        // string[] str = new string[3] {"A","B","C"};
    //     string[] str = new string[4]{"1","2","3","4"};
    //     int[] str2 = {1,234,24,43534534};
    //     foreach(var i in str) {
    //     Console.Write(i+"\t");
    //     }
    //     Console.WriteLine();
    //     foreach(var j in str2) {
    //     Console.Write(j+"\t");
    //     }
    // }

    // public void Jagged() {
    //     int [][] array= new int[3][];
    //     array[0]=new int[]{1,2,3,4,5};
    //     array[1]=new int[]{11,12,13,14,15};
    //     array[2]=new int[]{111,121,131,141,151};

    //     foreach(var i in array) {
    //         foreach(var j in i) {
    //             Console.Write(j+"\t");
    //         }
    //             Console.WriteLine();
    //     }

    // }

    // public void GenericsInAction() {
    //     List<int> arr= new List<int>();
        
    // }

    public void LearnLinq() {
        int [] num = {11,2,3,23,345,22};
        List<Student> students= new List<Student> {
            new("Ram",12,"ram@gmail.com"),
            new("Shyam",53,"shyam@gmail.com"),
            new("Geeta",14,"geeta@gmail.com"),
        };

        var even = num.Where(val => val%2==0);
        var mult = num.Select(val => val*val);
        var contains = num.Contains(22);
        var average = even.Average();
        Console.WriteLine(contains);
        Console.WriteLine(average);
        foreach(var i in even) {
            Console.Write(i+"\t");
        }
        Console.WriteLine();
        foreach(var i in mult) {
            Console.Write(i+"\t");
        }

    }
}