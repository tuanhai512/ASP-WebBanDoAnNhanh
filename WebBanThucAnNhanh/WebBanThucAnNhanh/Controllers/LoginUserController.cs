﻿using WebBanThucAnNhanh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanThucAnNhanh.Controllers
{
    public class LoginUserController : Controller
    {
        QLThucAnNhanhEntities database = new QLThucAnNhanhEntities();
        // GET: LoginUser
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAccount(KHACHHANG _user)
        {
            var check = database.KHACHHANG.Where(s => s.EMAIL == _user.EMAIL && s.PASSWORD == _user.PASSWORD).FirstOrDefault();
                if(check == null)
                {
                    ViewBag.ErrorInfo = "Sai info";
                    return View("Login");
                }    
                else
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    Session["EMAIL"] = _user.EMAIL;
                    Session["PASSWORD"] = _user.PASSWORD;
                    return RedirectToAction("About", "Home");
                }    
            return View();
        }
        public ActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterUser(KHACHHANG _user)
        {
            if (ModelState.IsValid)
            {
                var check_ID = database.KHACHHANG.Where(s => s.EMAIL == _user.EMAIL).FirstOrDefault();
                if (check_ID == null)
                {
                    database.Configuration.ValidateOnSaveEnabled = false;
                    database.KHACHHANG.Add(_user);
                    database.SaveChanges();
                    return RedirectToAction("Login");
                }
                else
                {
                    ViewBag.ErrorRegister = "This ID is exist";
                    return View();
                }
            }
            return View();
        }
    }
}