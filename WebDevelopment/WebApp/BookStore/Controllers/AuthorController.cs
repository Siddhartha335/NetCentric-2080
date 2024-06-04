using Microsoft.AspNetCore.Mvc;

public class AuthorController : Controller
{
    BookStoreDB db = new();  //Dependecy injection
    public IActionResult Index()
    {

        // Author a1 = new() { Id = 1, Name = "Siddhartha Raut", Gender = 'M', Address = "Lagankhel", Email = "sid33@gmail.com" };
        // Author a2 = new() { Id = 2, Name = "Rista Senpai", Gender = 'F', Address = "Texas,NY", Email = "ristasenpai54@gmail.com" };
        // Author a3 = new() { Id = 3, Name = "Yunisha", Gender = 'F', Address = "Kumaripati", Email = "yunisha11@gmail.com" };
        // Author a4 = new() { Id = 4, Name = "Rojina", Gender = 'F', Address = "Canberra Aus", Email = "rojina223@gmail.com" };
        
        List<Author> authors = db.Authors.ToList();
        
        
        
        // List<Author> authors = [a1, a2, a3, a4];
        return View(authors);
    }
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Author author) //Model Binding
    {
        
        db.Authors.Add(author);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        
        var author = db.Authors.Find(id); //it needs id
        return View(author);
    }

    [HttpPost]
    public IActionResult Edit(Author author) 
    {
        
        db.Authors.Update(author);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        
        var author = db.Authors.Find(id);
        db.Authors.Remove(author);
        db.SaveChanges();
        return RedirectToAction("Index");
    }

}