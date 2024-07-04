public abstract class Father {
    
    public Father(string name,int age) {  // parameterized constructor
        Name = name;
        Age = age;
    }

    public string name;

    public string Name {
        get {
            return name;
        }
        set {
            if(value.Length >=2) {
                name = value;
            }
        }
    }

    private int Age {get; set;}

    public virtual string printInfo() {
        return $"My name is {Name} and my age is {Age}";
    }
}