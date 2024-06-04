using System;
using System.IO;

class FileHandling {

    public void CreateFile() {
        //Create
        var dirPath = @"./CG_FILEIO";
        // var filePath = $"{dirPath}//student.txt";
        // File.WriteAllText(filePath,"Hello!, My name is Siddhartha!");
        // byte i=0;
        char c = 'A';
        for(int i=0;i<10;i++) {
            File.WriteAllText($"{dirPath}/file{c++}{i}.txt",$"{DateTime.Now}");
            // Console.WriteLine(i++);
        }

    }
    public void ReadFile() {
        //Read
        var dirPath = @"./CG_FILEIO";
        var filePath = $"{dirPath}//student.txt";
        var fileContent = File.ReadAllText(filePath);
        var sentences = fileContent.Split([',','!','?']);
        foreach (var sentence in sentences) {
            Console.WriteLine(sentence);
        }
        // Console.WriteLine();

    }
}