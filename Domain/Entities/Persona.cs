using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Persona : BaseEntity
{

    public string IdPersona { get; set; }

    public string Nombre { get; set; }

    public DateOnly? FechaRegistro { get; set; }
    public int IdUser { get; set; }

    public int? IdTipoPersona { get; set; }

    public int? IdCategoria { get; set; }

    public int? IdCiudad { get; set; }

    public User User { get; set; }
    public virtual ICollection<Contactoper> Contactopers { get; set; } = new List<Contactoper>();

    public virtual ICollection<Dirpersona> Dirpersonas { get; set; } = new List<Dirpersona>();

    public virtual Categoriaper IdCategoriaNavigation { get; set; }

    public virtual Ciudad IdCiudadNavigation { get; set; }

    public virtual Tipopersona IdTipoPersonaNavigation { get; set; }

    public virtual ICollection<Programacion> Programacions { get; set; } = new List<Programacion>();
}
