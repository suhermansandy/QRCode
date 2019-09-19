using GeradorQRCodeAspNetCore.QRCodeGenerators;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Drawing;

namespace GeradorQRCodeAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewBarcode(string test, string id, string id1)
        {            
            Image image = GeneratorQRCoder.GeneratedQRCodeString(test);
            byte[] byteArray = GeneratorQRCoder.ImageToByte2(image);
            string base64 = Convert.ToBase64String(byteArray);
            ViewBag.Message = base64;
            return View();
        }
    }
}