using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;
namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/
        public ActionResult Index()
        {

            ViewData["Video"] = BaseHelper.ejecutarConsulta("Select * From VIDEO", CommandType.Text);
            return View();
        }
        public ActionResult Agregar()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Agregar(int idVideo, string titulo, int repro, string url)
        {
            //guardar los datos a SQL server
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            

            BaseHelper.ejecutarSentencia("sp_video_insertar",CommandType.StoredProcedure,parametros);

            return View("Mensaje");
        }

        public ActionResult Eliminar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Eliminar(int idVideo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("sp__video_eliminar", CommandType.StoredProcedure, parametros);

            return View("Mensaje");
        }

        public ActionResult Modificar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Modificar(int idVideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));
            

            BaseHelper.ejecutarSentencia("sp_video_editar", CommandType.StoredProcedure, parametros);

            return View("Mensaje");
        }
        
        
    }
}
