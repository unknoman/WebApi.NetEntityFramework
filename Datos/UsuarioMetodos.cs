﻿using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using WebApplication1.Modelos;

namespace Datos
{
    public static class UsuarioMetodos
    {

        public static List<Usuario> listarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (ApiEmaContext db = new ApiEmaContext())
            {
                var list1 = db.Usuarios;
                foreach (var usuario1 in list1)
                {
                    usuario1.IdtipoNavigation = listarTipo(usuario1);
                    usuarios.Add(usuario1);
                }
            }
            return usuarios;

        }


        public static Tipouser listarTipo(Usuario user)
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

                    tipo = lista.Find(t => t.Idtipo == user.Idtipo);
                    
            }

            return tipo;

        }

        public static bool borrarUsuario(Usuario user)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                db.Remove(user);
                db.SaveChanges();
                return true;
            }
        }


        public static bool crearUsuario(Usuario user)
        {
            using (ApiEmaContext db = new ApiEmaContext())
            {
                db.Add(user);
                db.SaveChanges();
                return true;
            }
        }


    }
}