using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Contrato : BaseEntity
{

    public DateOnly? Fechacontrato { get; set; }

    public DateOnly? FechaFin { get; set; }

    public int? IdEstado { get; set; }

    public virtual Estado IdEstadoNavigation { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
