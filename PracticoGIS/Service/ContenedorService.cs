using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using PracticoGIS.Models;

namespace PracticoGIS.Service
{
    public class ContenedorService
    {
        const string ConnectionString = "server=localhost;port=5432;database=PracticoGIS;user id=postgres;";

        public static bool AltaContenedor(Contenedor contenedor)
        {
            var conn = new NpgsqlConnection(ConnectionString);
            
            conn.Open();

            var command = new NpgsqlCommand(@"INSERT INTO barrilaceite (descripcion, estado, geom)
                                            VALUES('EAEA','2',ST_GeomFromText('POINT(-147.68920897258 64.8302537436281)', 4326))", conn);
            
            var filasCreadas = command.ExecuteNonQuery();
            
            conn.Close();
            
            return filasCreadas == 1;
        }
    }
}