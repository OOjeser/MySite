﻿using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using MySite.Models;
using Wangkanai.Detection;

namespace MySite.Controllers
{
    public class HomeController : Controller
    {
        readonly IDetection detection;
        public HomeController(IDetection d) 
        {
            detection = d;
        }
        public IActionResult Index()
        {
            if(detection.Browser == null || detection.Browser.Type == BrowserType.Safari)
                ViewBag.ImagePath = $"../images/me/{(new Random()).Next(0, 18)}.jpg";
            else
                ViewBag.ImagePath = $"../images/me/{(new Random()).Next(0, 18)}.webp";
            ViewBag.Br = detection.Device.Type.ToString();
            ViewBag.Description = "";
            ViewBag.Keywords = "Гавриленко, Сергей, Константинович";
            return View();
        }
        [HttpPost]
        public IActionResult Index(ContactModel c)
        {
            if (detection.Browser.Type == BrowserType.Safari)
                ViewBag.ImagePath = $"../images/me/{(new Random()).Next(0, 18)}.jpg";
            else
                ViewBag.ImagePath = $"../images/me/{(new Random()).Next(0, 18)}.webp";
            ViewBag.Br = detection.Device.Type.ToString();
            MailAddress from = new MailAddress("boss.gavrilenko@yandex.ru", "Гавриленко Сергей");
            MailAddress to = new MailAddress("boss.gavrilenko@bk.ru");
            MailMessage m = new MailMessage(from, to);
            m.Subject = c.name + " :-: " + c.email;
            m.Body = c.message;
            m.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.yandex.ru", 25);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("boss.gavrilenko@yandex.ru", "Cam25151519");
            smtp.EnableSsl = true;
            smtp.Send(m);
            return View();
        }
    }
}