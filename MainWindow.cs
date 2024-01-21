using Microsoft.AspNetCore.Mvc;
using StudentskoZivljenje.Models;
using System;


public class MainWindow : Controller
{
    public virtual IActionResult Index()
    {
        return View();
    }
    public virtual void Show() {
		throw new System.NotImplementedException("Not implemented");
	}
	public virtual void Close() {
		throw new System.NotImplementedException("Not implemented");
	}
    [HttpPost]
	public virtual IActionResult VpisTecajRedirectWindow() {
        var model = new VpisTecajViewModel();
        return View("VpisTecaj", new VpisTecajViewModel());
	}
    [HttpPost]
	public virtual IActionResult HobiRedirectWindow() {
        var model = new HobiViewModel();
        return View("Hobi", new HobiViewModel());
    }
    [HttpPost]
    public virtual IActionResult DomRedirectWindow() {
        var model = new DomViewModel();
        return View("Dom", new DomViewModel());
    }
    [HttpGet]
    public virtual IActionResult StipendijaRedirectWindow() {
        var model = new StipendijaViewModel();
        return View("Stipendija", model);
    }
    [HttpPost]
    public IHttpActionResult StipendijaViewModel([FromBody] StipendijaWindow stipendija)
    {
        if (stipendija.ocena >= 3.0)
        {
            // Scholarship approved
            return Ok("Scholarship approved. Congratulations!");
        }
        else
        {
            // Scholarship not approved
            return BadRequest("Sorry, you did not pass the scholarship competition.");
        }
    }
}

public virtual IActionResult RegistracijaViewModel(Student model)
    {
        if (ModelState.IsValid)
        {
            if (model.File != null && model.File.Length > 0)
            {
                var fileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyTo(fileStream);
                }

                model.FilePath = "/uploads/" + fileName;
            }
            return RedirectToAction("Registracija je bila uspešna!");
        }
        return RedirectToAction("Registracija nije bila uspešna! Invalid model state");
    }
}
