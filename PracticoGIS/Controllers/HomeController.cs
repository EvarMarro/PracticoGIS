using System.Web.Mvc;
using Npgsql;

namespace PracticoGIS.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var conn = new NpgsqlConnection("server=localhost;port=5432;database=PracticoGIS;user id=postgres;");
            conn.Open();
            var command = new NpgsqlCommand("INSERT INTO barrilaceite (descripcion, estado, geom) VALUES('EAEA','2',ST_GeomFromText('POINT(-147.68920897258 64.8302537436281)', 4326))", conn);
            command.ExecuteNonQuery();

            conn.Close();
            
            return View();
        }

    }
}
