using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Dirpersona : BaseEntity
{

    public string Direccion { get; set; }

    public int? IdPersona { get; set; }

    public int? IdTipoDireccion { get; set; }

    public virtual Persona IdPersonaNavigation { get; set; }

    public virtual Tipodireccion IdTipoDireccionNavigation { get; set; }
}
