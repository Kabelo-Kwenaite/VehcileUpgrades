using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.VisualStudio;

namespace VehcileUpgrades.Controllers
{
    public class UpgradeController : Controller
    {

        public IActionResult Upgrade()
        {
            
            return View();
        }
    }
}
