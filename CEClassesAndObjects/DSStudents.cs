//Multi-level Inheritance
class DSStudent : CSStudent {
    public DSStudent(string name,byte roll,string email,string project) : base(name,roll,email,project)
    {
        
    }

    public string DataScienceInstructor { get; set; }
}