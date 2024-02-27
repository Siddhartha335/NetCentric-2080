using System;
using System.Collections.Generic;

class ProjCollections
{

    void LearnCollections()
    {

        // double [] weights = new double[20];
        // double[] weight = {23.4,24.26,24.6,34.7,87.5};
        // string [][] names  = [["A","B","C"],[],[]];

        //Built in collections list,(dictionary) = (fast search)
        List<string> studentNames = ["Sid", "Ritiz"];

        // studentNames.
        Dictionary<string, char> studentGrades = new()
        {
            ["Sid"] = 'A',
            ["Ritiz"] = 'B',
            ["Leo"] = 'C',
        };

        Console.WriteLine(studentGrades["Sid"]);

    }
}