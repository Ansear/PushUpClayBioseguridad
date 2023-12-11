using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Programacion : BaseEntity
{

    public int? IdContrato { get; set; }

    public int? IdTurno { get; set; }

    public int? IdEmpleado { get; set; }

    public virtual Contrato IdContratoNavigation { get; set; }

    public virtual Persona IdEmpleadoNavigation { get; set; }

    public virtual Turno IdTurnoNavigation { get; set; }
}
