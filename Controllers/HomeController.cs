using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VehcileUpgrades.Models;
using System.Data.SqlClient;

namespace VehcileUpgrades.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        String conString = "Data Source=KABELOKWENAITE;Initial Catalog=Vehicles;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private IUpgradeColor _upC;
        private IUpgradeEngine _upE;
        private IUpgradeSpeed _upS;
        public HomeController(ILogger<HomeController> logger, IUpgradeSpeed upS, IUpgradeEngine upE, IUpgradeColor upC)
        {
            _logger = logger;
            _upS = upS;
            _upE = upE;
            _upC = upC;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upgrades()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}