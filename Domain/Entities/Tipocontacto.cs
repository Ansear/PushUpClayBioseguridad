using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Tipocontacto : BaseEntity
{

    public string Descripcion { get; set; }

    public virtual ICollection<Contactoper> Contactopers { get; set; } = new List<Contactoper>();
}
