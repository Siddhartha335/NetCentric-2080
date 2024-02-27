using System;
using System.Linq;

class Methods {

    public void Print() {
        Console.WriteLine("Hello!");
    }
    // void Print(string greet) {
    //     Console.WriteLine("Hello!" + greet);
    // }

    public float CalculateBMI(float heightInFeet, float weight=78.0f) { //optional parameter
        var heightInM = heightInFeet/3.14;
        var bmi = weight / (heightInM*heightInM);
        return (float)bmi;
    }

    public (int,int) MinMax (params int [] ages) {
        var youngest =  ages.Min();
        var eldest =  ages.Max();
        return (youngest,eldest);
    }
}