using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pasca_Andrei_Alexandru_Lab1.Models;

namespace Pasca_Andrei_Alexandru_Lab1.Controllers;

public class GreetingController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public GreetingController(ILogger<HomeController> _logger)
	{
		_logger = _logger;
	}

	public string Index()
	{
		return new string("Bun Venit !");
        //Testat cu url default
    }

    public String SalutUtilizatorule()
    {
        return new string("Salut utilizatorule !");

		//Testat cu url ../greeting/SalutUtilizatorule
    }

    public String IntSiString(int num, String text)
    {
        return new string(num.ToString() + text);

        //Testat cu url ../greeting/IntSiString?num=1&text=/2
    }


}



