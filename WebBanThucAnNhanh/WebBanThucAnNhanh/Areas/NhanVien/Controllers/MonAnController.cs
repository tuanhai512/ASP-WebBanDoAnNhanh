<<<<<<< Updated upstream
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;
using System.IO;


namespace WebBanThucAnNhanh.Areas.NhanVien.Controllers
{
    public class MonAnController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: Admin/MonAn
        public ActionResult Index()
        {
            return View(_db.MONANs.ToList());
        }

        // GET: Admin/MonAn/Details/5
        public ActionResult Details(string id)
        {
            return View(_db.MONANs.Where(s=>s.MAMONAN==id).FirstOrDefault());
        }

        // GET: Admin/MonAn/Create
        public ActionResult Create()
        {
            List<LOAI> list = _db.LOAIs.ToList();
            ViewBag.listLoai = new SelectList(list, "MaLoai", "TenLoai", "Select cate");
            MONAN monan = new MONAN();
            return View(monan);
        }

        // POST: Admin/MonAn/Create
        [HttpPost]
        public ActionResult Create(MONAN monan)
        {
            try
            {
                List<LOAI> list = _db.LOAIs.ToList();
                
                // TODO: Add insert logic here
                if(monan.UploadImage!=null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(monan.UploadImage.FileName);
                    string extension = Path.GetExtension(monan.UploadImage.FileName);
                    fileName = fileName + extension;
                    monan.HINHANH= "~/Assets/admin/img/" + fileName;
                    monan.UploadImage.SaveAs(Path.Combine(Server.MapPath("~/Assets/admin/img/"), fileName));
                }
                ViewBag.listLoai = new SelectList(list, "MaLoai", "TenLoai", 1);
                _db.MONANs.Add(monan);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/MonAn/Edit/5
        public ActionResult Edit(string id)
        {
            return View(_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault());
        }

        // POST: Admin/MonAn/Edit/5
        [HttpPost]
        public ActionResult Edit( MONAN monan)
        {
            try
            {
                // TODO: Add update logic here
                if (monan.UploadImage != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(monan.UploadImage.FileName);
                    string extension = Path.GetExtension(monan.UploadImage.FileName);
                    fileName = fileName + extension;
                    monan.HINHANH = "~/Assets/admin/img/" + fileName;
                    monan.UploadImage.SaveAs(Path.Combine(Server.MapPath("~/Assets/admin/img/"), fileName));
                }
                _db.Entry(monan).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/MonAn/Delete/5
        public ActionResult Delete(string id)
        {
            return View(_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault());
        }

        // POST: Admin/MonAn/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, MONAN monan)
        {
            try
            {
                // TODO: Add delete logic here
                monan=_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault();
                _db.MONANs.Remove(monan);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SelectFood()
        {
            LOAI se_loai = new LOAI();
            se_loai.listLoai = _db.LOAIs.ToList<LOAI>();
            return PartialView(se_loai);
        }
        public ActionResult SelectUnit()
        {
            DONVITINH se_donvi = new DONVITINH();
            se_donvi.listUnit = _db.DONVITINHs.ToList<DONVITINH>();
            return PartialView(se_donvi);
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanThucAnNhanh.Models;
using System.IO;


namespace WebBanThucAnNhanh.Areas.NhanVien.Controllers
{
    public class MonAnController : Controller
    {
        QLThucAnNhanhEntities _db = new QLThucAnNhanhEntities();
        // GET: Admin/MonAn
        public ActionResult Index()
        {
            return View(_db.MONANs.ToList());
        }

        // GET: Admin/MonAn/Details/5
        public ActionResult Details(string id)
        {
            return View(_db.MONANs.Where(s=>s.MAMONAN==id).FirstOrDefault());
        }

        // GET: Admin/MonAn/Create
        public ActionResult Create()
        {
            List<LOAI> list = _db.LOAIs.ToList();
            ViewBag.listLoai = new SelectList(list, "MaLoai", "TenLoai", "Select cate");
            MONAN monan = new MONAN();
            return View(monan);
        }

        // POST: Admin/MonAn/Create
        [HttpPost]
        public ActionResult Create(MONAN monan)
        {
            try
            {
                List<LOAI> list = _db.LOAIs.ToList();
                
                // TODO: Add insert logic here
                if(monan.UploadImage!=null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(monan.UploadImage.FileName);
                    string extension = Path.GetExtension(monan.UploadImage.FileName);
                    fileName = fileName + extension;
                    monan.HINHANH= "~/Assets/admin/img/" + fileName;
                    monan.UploadImage.SaveAs(Path.Combine(Server.MapPath("~/Assets/admin/img/"), fileName));
                }
                ViewBag.listLoai = new SelectList(list, "MaLoai", "TenLoai", 1);
                _db.MONANs.Add(monan);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: Admin/MonAn/Edit/5
        public ActionResult Edit(string id)
        {
            return View(_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault());
        }

        // POST: Admin/MonAn/Edit/5
        [HttpPost]
        public ActionResult Edit( MONAN monan)
        {
            try
            {
                // TODO: Add update logic here
                if (monan.UploadImage != null)
                {
                    string fileName = Path.GetFileNameWithoutExtension(monan.UploadImage.FileName);
                    string extension = Path.GetExtension(monan.UploadImage.FileName);
                    fileName = fileName + extension;
                    monan.HINHANH = "~/Assets/admin/img/" + fileName;
                    monan.UploadImage.SaveAs(Path.Combine(Server.MapPath("~/Assets/admin/img/"), fileName));
                }
                _db.Entry(monan).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/MonAn/Delete/5
        public ActionResult Delete(string id)
        {
            return View(_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault());
        }

        // POST: Admin/MonAn/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, MONAN monan)
        {
            try
            {
                // TODO: Add delete logic here
                monan=_db.MONANs.Where(s => s.MAMONAN == id).FirstOrDefault();
                _db.MONANs.Remove(monan);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult SelectFood()
        {
            LOAI se_loai = new LOAI();
            se_loai.listLoai = _db.LOAIs.ToList<LOAI>();
            return PartialView(se_loai);
        }
        public ActionResult SelectUnit()
        {
            DONVITINH se_donvi = new DONVITINH();
            se_donvi.listUnit = _db.DONVITINHs.ToList<DONVITINH>();
            return PartialView(se_donvi);
        }
    }
}
>>>>>>> Stashed changes
