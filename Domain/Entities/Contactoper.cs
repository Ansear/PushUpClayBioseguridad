﻿using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Entities;

public partial class Contactoper : BaseEntity
{

    public int? IdPersona { get; set; }

    public int? IdTipoContacto { get; set; }

    public virtual Persona IdPersonaNavigation { get; set; }

    public virtual Tipocontacto IdTipoContactoNavigation { get; set; }
}
