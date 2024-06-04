using System;
using System.Linq;

namespace Practicing;

class Practices {

    // public void show() {
    //     DateTime dob = DateTime.Now;
    //     Console.Write("" + dob.ToString());
    // }

    // public (int,int) MinMax(int[] ages) {
    //     var max = ages.Max();
    //     var min = ages.Min();
    //     return(max,min);
    // }

    public void LearnArray() {

        // int [] ages = {20,33,34,21};
        // int [] ages = new int[10]{1,2,3,4,5,6,7,8,9,10};
        // foreach (int age in ages) {
        //     Console.Write(age + "\t");
        // }
        // int[,] arr = new int[4,2] {{1,2},{3,4},{5,6},{7,8}};
        // Console.Write(arr[2,0]);

        int [][] array= new int[3][];
        array[0]=new int[]{1,2,3,4,5};
        array[1]=new int[]{11,12};
        array[2]=new int[]{111,121};

        foreach(var i in array) {
            foreach(var j in i) {
                Console.Write(j+"\t");
            }
                Console.WriteLine();
        }
    }
}