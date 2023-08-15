using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonelProjesiBLL;
using PersonelProjesiEntity;

namespace PersonelProjesi.Controllers
{
    public class PersonelController : Controller
    {
        PersonelManager personelManager=new PersonelManager();
        // GET: Personel
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                var model = personelManager.GetAllPersonel();
                return View(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Beklenmedik bir hata oluştu!{ex.Message}");
                return View(new List<Personel>());
            }
        }

        public ActionResult Delete(int id)
        {
            try
            {
                if (id<=0)
                {
                    TempData["DeleteErrorMsg"] = $"id değeri sıfırdan büyük olmalı!";
                    return RedirectToAction("Index");
                }
                if (personelManager.DeletePersonel(id))
                {
                    TempData["DeleteSuccessMsg"] = $"Personel silindi";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["DeleteErrorMsg"] = $"Personel Silinemedi";
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["DeleteErrorMsg"] =$"Beklenmedik bir hata oluştu!{ex.Message}";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Add(Personel newPersonel)
        {
            try
            {
                if (personelManager.AddPersonel(newPersonel))
                {
                    TempData["AddSuccessMsg"] = $"Personel eklendi";
                    return View();
                }
                else
                {
                    TempData["AddErrorMsg"] = $"Personel Eklenemedi";
                    return View();
                }
            }
            catch (Exception ex)
            {
                TempData["AddErrorMsg"] = $"Beklenmedik bir hata oluştu!{ex.Message}";
                return View();
            }
        }

        //public ActionResult Add(Personel newPersonel)
        //{
        //    try
        //    {
        //        personelManager.AddPersonel(newPersonel);

        //        TempData["AddSuccessMsg"] = "Personel eklendi";
        //        return View();
        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["AddErrorMsg"] = $"Beklenmedik bir hata oluştu! {ex.Message}";
        //        return View();
        //    }
        //}

    }
}