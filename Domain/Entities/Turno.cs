using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Turno : BaseEntity
{

    public string NombreTurno { get; set; }

    public TimeOnly? HoraTurnoInicio { get; set; }

    public TimeOnly? HoraTurnoFin { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
