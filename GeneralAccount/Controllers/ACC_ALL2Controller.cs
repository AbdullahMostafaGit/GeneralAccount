using GeneralAccount.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using PagedList;
using PagedList.Mvc;

namespace GeneralAccount.Controllers
{
    public class ACC_ALL2Controller : Controller
    {
        DataContext db = new DataContext();
        // GET: ACC_ALL2waddwawdadwa

        public ActionResult Index(int? i)
        {

            return View(db.ACC_ALL2.ToList().ToPagedList(i ?? 1, 5));
        }

        //take n digits of number 
        private static string takeNDigits(string number, int N)
        {
            string TAKE = "";
            int length = N - 1;
            for(int I =0; I <= length; I++)
            {
                TAKE = TAKE + number[I];

            }
            return TAKE;
        }
        //end function
       
        public ActionResult Create_Check_Code()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create_Check_Code(ACC_ALL2 Acc)
        {
            if (((Acc.CODE).ToString()).Length / 3.00 == Convert.ToInt64(Acc.Account_Level))
            {
                var allacc = db.ACC_ALL2.ToList();

                //level 1
                if (Convert.ToInt32(Acc.Account_Level) == 1)
                {
                    foreach (var item in allacc)
                    {
                        if (item.CODE == Acc.CODE)
                        { return Content("already exists"); }
                    }
                    db.ACC_ALL2.Add(Acc);
                    db.SaveChanges();
                    return Json(new { result = 1 });
                }
                //end level one 
                ////level 2
                else if (Convert.ToInt32(Acc.Account_Level) == 2)
                {
                    foreach (var item in allacc)
                    {
                        if ((item.CODE).ToString() == takeNDigits((Acc.CODE).ToString(), 3))   //function to get first 3 digit
                        {
                            foreach (var AllCode in allacc)
                            {
                                if (AllCode.CODE == Acc.CODE)
                                { return Json(new { result = 0 }); }
                            }
                            db.ACC_ALL2.Add(Acc);
                            db.SaveChanges();
                            return Json(new { result = 1 });
                        }
                    }
                }
                //end level two
                ////level 3
                else if (Convert.ToInt32(Acc.Account_Level) == 3)
                {
                    foreach (var item in allacc)
                    {
                        if ((item.CODE).ToString() == takeNDigits((Acc.CODE).ToString(), 6)) //function to get first 6 digit
                        {
                            foreach (var AllCode in allacc)
                            {
                                if (AllCode.CODE == Acc.CODE)
                                {
                                    return Json(new { result = 0 });
                                    //return Content("already exists");

                                }
                            }
                            db.ACC_ALL2.Add(Acc);
                            db.SaveChanges();
                            return Json(new { result = 1 });
                            //return Content("insertion done");
                        }
                    }


                }
                //end level three
                //level 4 
                else if (Convert.ToInt32(Acc.Account_Level) == 4)
                {
                    foreach (var item in allacc)
                    {
                        if ((item.CODE).ToString() == takeNDigits((Acc.CODE).ToString(), 9)) //function to get first 9 digit
                        {
                            foreach (var AllCode in allacc)
                            {
                                if (AllCode.CODE == Acc.CODE)
                                { return Json(new { result = 0 }); }
                            }
                            db.ACC_ALL2.Add(Acc);
                            db.SaveChanges();
                            return Json(new { result = 1 });
                        }
                    }
                }
                //end level four


            }
            else { return Json(new { error = 1 }); }

            return View();



        }


        public ActionResult Delete(string code)
        {

            var client = db.ACC_ALL2.Find(code);
            db.ACC_ALL2.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(string code)
        {
            if (code.Length == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ACC_ALL2 CLIENT = db.ACC_ALL2.Find(code);
            if (CLIENT == null)
            {
                return HttpNotFound();
            }
            return View(CLIENT);
        }

        [HttpPost]
        public ActionResult Edit(ACC_ALL2 CLIENT)
        {

            if (ModelState.IsValid)
            {
                var GetCLIENT = db.ACC_ALL2.Where(stu => stu.CODE == CLIENT.CODE).FirstOrDefault();

                if (GetCLIENT != null)
                {
                    if (GetCLIENT.Account_Level != CLIENT.Account_Level)
                    {
                        GetCLIENT.NAME = CLIENT.NAME;
                        GetCLIENT.LIQ_CR = CLIENT.LIQ_CR;
                        GetCLIENT.liq_bal = CLIENT.liq_bal;
                        GetCLIENT.LIQ_DR = CLIENT.LIQ_DR;
                        GetCLIENT.SORTBY = CLIENT.SORTBY;
                        GetCLIENT.FLAG_TR = CLIENT.FLAG_TR;
                        GetCLIENT.FL = CLIENT.FL;
                        GetCLIENT.CHK_NAV = CLIENT.CHK_NAV;
                        GetCLIENT.s_type_____ = CLIENT.s_type_____;
                      
                        GetCLIENT.Account_Level = GetCLIENT.Account_Level;
                        db.SaveChanges();
                        return RedirectToAction("Index");
                        /*db.Entry(student).State = EntityState.Modified;
                         db.SaveChanges();*/
                    }
                }

            }
            else
            {
                return View(CLIENT);
            }
            return View(CLIENT);
        }

        public ActionResult Details(string code)
        {
            if (code.Length != 0)
            {
                return View(db.ACC_ALL2.Find(code));
            }
            else
            {
                return Content("this Client Not found");
            }

        }

        //searching 
        public ActionResult SearchByCode(string searching, int? i)
        {
            var result = db.ACC_ALL2.Where(x => x.CODE.Contains(searching) || searching == null).ToList().ToPagedList(i ?? 1, 5);
            return View(result);
        }
        public ActionResult SearchByName(string searching, int? i)
        {
            var result = db.ACC_ALL2.Where(x => x.NAME.Contains(searching) || searching == null).ToList().ToPagedList(i ?? 1, 5);
            return View(result);
        }
        public ActionResult SearchByLevel(string AccountLevel, int? i)
        {
            var result = db.ACC_ALL2.Where(x => (x.Account_Level).ToString().Contains(AccountLevel) || AccountLevel == null).ToList().ToPagedList(i ?? 1, 5);
            return View(result);

        }

    }
}

