using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Modelos;

public partial class Tipouser
{
    public int Idtipo { get; set; }

    public string Tipo { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Usuario> Usuarios { get; } = new List<Usuario>();
}
