public class GrandChild : Child 
{
    public static int income;

    public GrandChild(string name, int age, string caste, int cage) : base(name, age, caste, cage)
    {
    }

    public int calculateIncome() => 30000;

    public override string printInfo() {
        var prevResult = base.printInfo();
        var newResult = prevResult + $" and My income is {calculateIncome()}";
        return newResult;
    }
}