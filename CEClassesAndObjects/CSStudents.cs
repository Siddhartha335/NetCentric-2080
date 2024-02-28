class CSStudent : Student,IGradeable { //Multiple Inheritance
    public CSStudent(string name,byte roll, string email,string project) : base(name,roll,email)  //Single Inheritance
    {
        ProjectTitle = project;
    }
    public string ProjectTitle {get; set;}
    public string InternReport {get; set;}

    public double GetGrade() => 3.6;

    public override string PrintInfo()
    {
        var previousDetails =  base.PrintInfo();
        previousDetails += $" and project title is:{ProjectTitle}";
        return previousDetails;

    }
}