using Microsoft.AspNetCore.Mvc;

public class PublisherController : Controller {

    public IActionResult Index() {
        Publisher p1 = new() {Id=1,Name="Siddhartha Raut",Address="Lagankhel",Phone=9832423423,EstablishedDate = DateTime.Now};
        Publisher p2 = new() {Id=1,Name="Siddhartha Raut",Address="Lagankhel",Phone=9832423423,EstablishedDate = DateTime.Now};
        Publisher p3 = new() {Id=1,Name="Siddhartha Raut",Address="Lagankhel",Phone=9832423423,EstablishedDate = DateTime.Now};

        List<Publisher> publishers = [p1,p2,p3];
        return View(publishers);
    }
}