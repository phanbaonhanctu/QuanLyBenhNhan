using AspWebMvc.Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspWebMvc.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            DataDBContext dataDBContext = new DataDBContext();
            List<BENHNHAN> list = dataDBContext.BENHNHANs.ToList();
            return View(list);
        }

        public ActionResult Add()
        {
            return View( new BENHNHAN());
        }

        [HttpPost]
        public ActionResult Add(BENHNHAN bn)
        {
            using (DataDBContext db = new DataDBContext())
            {
                BENHNHAN b = bn;
                b.id = Guid.NewGuid();
                db.BENHNHANs.Add(b);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(Guid id)
        {


            DataDBContext db = new DataDBContext();
                // Tìm đối tượng cần xóa
                BENHNHAN benhNhanToEdit = db.BENHNHANs.Find(id);
            
            return View(benhNhanToEdit);
        }

        [HttpPost]
        public ActionResult Edit(BENHNHAN bn)
        {
            DataDBContext db = new DataDBContext();
            // Tìm đối tượng cần xóa
            BENHNHAN benhNhannew = db.BENHNHANs.Find(bn.id);
            benhNhannew.name = bn.name;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            using (DataDBContext db = new DataDBContext())
            {
                // Tìm đối tượng cần xóa
                BENHNHAN benhNhanToDelete = db.BENHNHANs.Find(id);

                if (benhNhanToDelete != null)
                {
                    // Xóa đối tượng
                    db.BENHNHANs.Remove(benhNhanToDelete);

                    // Lưu thay đổi vào cơ sở dữ liệu
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

    }
}