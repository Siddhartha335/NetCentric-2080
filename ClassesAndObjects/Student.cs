using System;

class Student {
    public Student() {   //Default constructor will be called

    }
    //Parameterized constructor
    public Student(string name, byte rollNUmber,string email) {
        this.name = name;
        this.rollNUmber = rollNUmber;
        this.Email = email;
    }

    public Student(string name,byte rollNUmber,string email, DateTime dob):this(name,rollNUmber,email) {
        this.Dob = dob;
    }
    string name;
    public string Name {  // C sharp properties

        get {
            return name;
        }

        set {
            if(value.Length >=2) {
                name = value;
            }
        }
    }
    public byte rollNUmber;
    public DateTime Dob { get;}

    //Auto implemented property
    public string Email {get; set;}

    public virtual string PrintInfo() {
        return $"My name is {name} and my roll number is {rollNUmber} and my email is {Email}";
    }

}