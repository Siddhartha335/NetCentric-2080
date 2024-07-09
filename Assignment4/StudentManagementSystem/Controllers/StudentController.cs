using Microsoft.AspNetCore.Mvc;

public class StudentController : Controller
{
    StudentDB db = new();  //Dependecy injection
    public IActionResult Index()
    {

        List<Student> students = db.Students.ToList();
        
        return View(students);
    }

    [HttpPost]
    public IActionResult Add(Student Student) //Model Binding
    {
        
        db.Students.Add(Student);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        
        var Student = db.Students.Find(id); //it needs id
        return View(Student);
    }

    [HttpPost]
    public IActionResult Edit(Student student) 
    {
        
        db.Students.Update(student);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        
        var student = db.Students.Find(id);
        db.Students.Remove(student);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    

}