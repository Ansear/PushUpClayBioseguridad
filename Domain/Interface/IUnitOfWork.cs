namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IPais Paises { get; }
        ICategoriaPer CategoriaPer {get;}
        ICiudad Ciudades {get;}
        IContactoPer ContactoPer {get;}
        IContrato Contratos {get;}
        IDepartamento Departamentos {get;}
        IDirPersona DirPersonas {get;}
        IEstado Estados {get;}
        IPersona Personas {get;}
        IProgramacion Programacion {get;}
        IRol Rols {get;}
        ITipoContacto TipoContactos {get;}
        ITipoDireccion TipoDirecciones {get;}
        ITipoPersona TipoPersonas {get;}
        ITurno Turnos {get;}
        IUser Users {get;}
        Task<int> SaveAsync();
    }
}