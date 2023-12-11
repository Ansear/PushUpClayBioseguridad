using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Ciudad : BaseEntity
{

    public string Nombreciud { get; set; }

    public int? IdDep { get; set; }

    public virtual Departamento IdDepNavigation { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
