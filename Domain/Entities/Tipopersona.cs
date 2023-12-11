using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Tipopersona : BaseEntity
{

    public string Descripcion { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
