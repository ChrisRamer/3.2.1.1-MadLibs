using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
	public class HomeController : Controller
	{
		[Route("/")]
		public ActionResult Story()
		{
			MadLibsVariables madLibsVariables = new MadLibsVariables();
			madLibsVariables.Name = "Sally";
			madLibsVariables.Verb = "walking";
			madLibsVariables.Animal = "dog";
			madLibsVariables.Noun = "fish";
			madLibsVariables.Number = 42;
			madLibsVariables.Adjective = "Dog lover";
			madLibsVariables.Name2 = "Luna";
			return View(madLibsVariables);
		}

		[Route("/form")]
		public ActionResult Form() { return View(); }

		[Route("/story")]
		public ActionResult Story(string name, string verb, string animal, string noun, int number, string adjective, string name2)
		{
			MadLibsVariables madLibsVariables = new MadLibsVariables();
			madLibsVariables.Name = name;
			madLibsVariables.Verb = verb;
			madLibsVariables.Animal = animal;
			madLibsVariables.Noun = noun;
			madLibsVariables.Number = number;
			madLibsVariables.Adjective = adjective;
			madLibsVariables.Name2 = name2;
			return View(madLibsVariables);
		}
	}
}