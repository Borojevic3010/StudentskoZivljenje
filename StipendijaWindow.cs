using Microsoft.AspNetCore.Mvc;
using System;

public class StipendijaWindow : MainWindow  {
	private StipendijaViewModel vm;

	public override void Show() {
		throw new System.NotImplementedException("Not implemented");
	}
	public override void Close() {
		throw new System.NotImplementedException("Not implemented");
	}

    [HttpGet]
    public override IActionResult StipendijaRedirectWindow()
    {
        //var model = new StipendijaViewModel();
		return View("Stipendija", vm);
    }

}
