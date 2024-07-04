public class Child: Father, IAge 
{
    public Child(string name,int age, string caste,int cage):base(name,age) {
        Caste = caste;
        ChildAge = cage;
    }

    public string Caste { get; set; }
    public int ChildAge { get; set; }

    public string ageInfo = "";
    public string getAge() {
        if(ChildAge <=10) {
            ageInfo = "Juvenile";
        }
        else if(ChildAge >10 && ChildAge <18) {
            ageInfo = "Teenager";
        }
        else {
            ageInfo = "Adult";
        }
        return ageInfo;
    }

    public string getAge(int age) {
        if(age <=10) {
            ageInfo = "Juvenile";
        }
        else if(age >10 && age <18) {
            ageInfo = "Teenager";
        }
        else {
            ageInfo = "Adult";
        }
        return ageInfo;
    }

    public override string printInfo() {
        var prevResult = base.printInfo();
        var newResult = prevResult + $" We are from {Caste} family and My child age is {ChildAge} and he/she is {getAge()}";
        return newResult;
    }

}