﻿using Microsoft.AspNetCore.Mvc;
using Negocio;
using WebApplication1.Modelos;

namespace WebApiEma.Controllers.Logica
{
    public class tipoUserController : Controller
    {
        [HttpGet]
        [Route("listartipouser")]
        public dynamic listarTipoUser()
        {
            List<Tipouser> lista = new List<Tipouser>();
           lista = TipoUserNegocio.ListarTipoUsuarios();
            return lista;
        }

        [HttpPost]
        [Route("listartipouserid")]
        public dynamic listarTipoUserid(int id)
        {
            Tipouser usuarioTipo = new Tipouser();
            usuarioTipo = TipoUserNegocio.ListarUsuarios(id);
            return usuarioTipo;
        }

        [HttpPost]
        [Route("actualizartipo")]
        public dynamic actualizarTipo(Tipouser tipoActualizado)
        {
            return TipoUserNegocio.actualizarTipo(tipoActualizado);
        }

    }
}