using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using WebApplication1.Modelos;


namespace Datos
{
    public static class tiposUserMetodos
    {



        //---

        public static Tipouser listarTipo(int id)
        {
            List<Tipouser> lista = new List<Tipouser>();
            Tipouser tipo = new Tipouser();
            using (ApiEmaContext db = new ApiEmaContext())
            {
                var list1 = db.Tipousers;
                foreach (var tipos in list1)
                {
                    lista.Add(tipos);
                }

                tipo = lista.Find(t => t.Idtipo == id);
            }
            return tipo;
        }



        public static List<Tipouser> listarTipo()
        {
            List<Tipouser> lista = new List<Tipouser>();
            using (ApiEmaContext db = new ApiEmaContext())
            {
                var list1 = db.Tipousers;
                foreach (var tipo in list1)
                {
                    lista.Add(tipo);
                }
            }
            return lista;
        }



        // -------------------------------------------------------------------------------------
        public static bool crearTipo(Tipouser tipo)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                db.Add(tipo);
                return true;
            }
        }


        public static bool eliminarTipo(Tipouser tipo)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                db.Remove(tipo);
                db.SaveChanges();
                return true;
            }
        }



       public static bool actualizarTipo(Tipouser tipoActualizado)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                Tipouser tipo = new Tipouser();
                tipo = tipoActualizado;
                db.Update(tipo);
                db.SaveChanges();
                return true;
            }
                
        }
     



    }
}
