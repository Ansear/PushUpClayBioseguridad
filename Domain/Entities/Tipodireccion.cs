using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Tipodireccion : BaseEntity
{

    public string Descripcion { get; set; }

    public virtual ICollection<Dirpersona> Dirpersonas { get; set; } = new List<Dirpersona>();
}
