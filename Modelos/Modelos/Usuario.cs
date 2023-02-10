using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace WebApplication1.Modelos;

public partial class Usuario
{
    public int Idusuario { get; set; }


    public string Usuario1 { get; set; } = null!;

    public string Password { get; set; } = null!;

    [JsonIgnore]
    public virtual Tipouser? IdtipoNavigation { get; set; } = null!;

    public int Idtipo { get; set; }


}
