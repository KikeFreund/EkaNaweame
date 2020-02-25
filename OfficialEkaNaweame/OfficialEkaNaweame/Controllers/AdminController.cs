using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using OfficialEkaNaweame.Models;

namespace OfficialEkaNaweame.Controllers
{
    public class AdminController : Controller
    {
        
        public ActionResult ListaUser()
        {
            // Obtener Correos de usuarios 

            List<ListaUsuarios> lst;
            List<ListaUsuarios> tipo_user;

            using (ekaEntities db = new ekaEntities())
            {
                lst = (from d in db.AspNetUsers
                           select new ListaUsuarios
                           {
                               Correo = d.Email,
                               Emailconfirmado = d.EmailConfirmed
                           }).ToList();

                tipo_user = (from d in db.AspNetUsers
                             select new ListaUsuarios
                             {
                                 Correo = d.Email,
                                 Emailconfirmado = d.EmailConfirmed
                             }).ToList();
            }

            return View(lst);

        }

    }
}