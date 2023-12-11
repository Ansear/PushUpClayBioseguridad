using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Categoriaper : BaseEntity
{
    public string NombreCategoria { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
