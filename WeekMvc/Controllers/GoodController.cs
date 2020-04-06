using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeekMvc.Controllers
{
    public class GoodController : Controller
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <returns></returns>
        public ActionResult Add()
        {
            return View();
        }
        /// <summary>
        /// 显示，查询，删除
        /// </summary>
        /// <returns></returns>
        public ActionResult Show()
        {
            return View();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <returns></returns>
        public ActionResult Update()
        {
            return View();
        }
    }
}