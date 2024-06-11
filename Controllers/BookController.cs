using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using firstwebapp.Models;
using firstwebapp.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace firstwebapp.Controllers;

public class BookController: Controller {
    private ApplicationDbContext _db;

    public BookController(ApplicationDbContext db){
        _db = db;
    }

    public IActionResult Index(){
        var books = _db.Books.ToList();
        return View(books);
    }
}