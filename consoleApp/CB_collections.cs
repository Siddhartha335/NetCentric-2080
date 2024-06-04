using System;
using System.Collections.Generic;

class ProjCollections
{

    public void LearnCollections()
    {

        // double [] weights = new double[20];
        // double[] weight = {23.4,24.26,24.6,34.7,87.5};
        // string [][] names  = [["A","B","C"],[],[]];

        //Built in collections list,(dictionary) = (fast search)
        List<string> studentNames = new();

        studentNames.Add("Rista");
        studentNames.Add("Senpai");
        // foreach (string studentName in studentNames) {
        //     Console.WriteLine(studentName);
        // }

        // studentNames.
        Dictionary<string, char> studentGrades = new()
        {
            ["Sid"] = 'A',
            ["Ritiz"] = 'B',
            ["Leo"] = 'C',
        };

        studentGrades.Add("Rista",'E');

        Console.Write(studentGrades["Rista"]);

        // Console.WriteLine(studentGrades["Sid"]);

    }
}