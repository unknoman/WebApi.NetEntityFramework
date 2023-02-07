using System;
using System.Collections.Generic;

namespace WebApplication1.Modelos;

public partial class Usuario
{
    public int Idusuario { get; set; }


    public string Usuario1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual Tipouser IdtipoNavigation { get; set; } = null!;

    public int Idtipo { get; set; }


}
