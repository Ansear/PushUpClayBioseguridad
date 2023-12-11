using APP.Repository;
using Domain.Entities;
using Domain.Interfaces;
using persistence.Data;

namespace APP.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ICategoriaPer _categoriaPer;
        private ICiudad _ciudad;
        private IContactoPer _contactoPer;
        private IContrato _contrato;
        private IDepartamento _departamento;
        private IDirPersona _dirPersona;
        private IEstado _estado;
        private IPais _pais;
        private IPersona _persona;
        private IProgramacion _programacion;
        private ITipoContacto _tipoContacto;
        private ITipoDireccion _tipoDireccion;
        private ITipoPersona _tipoPersona;
        private ITurno _turno;
        private IRol _rol;
        private IUser _user;


    
        private readonly PushUpContext _context;

        public UnitOfWork(PushUpContext context)
        {
            _context = context;
        }


        public ICategoriaPer CategoriaPer
        {
            get
            {
                if (_categoriaPer == null)
                {
                    _categoriaPer = new CategoriaPerRepository(_context);
                }
                return _categoriaPer;
            }
        }

        public ICiudad Ciudades
        {
            get
            {
                if (_ciudad == null)
                {
                    _ciudad = new CiudadRepository(_context);
                }
                return _ciudad;
            }
        }
        public IContactoPer ContactoPer
        {
            get
            {
                if (_contactoPer == null)
                {
                    _contactoPer = new ContactoPerRepository(_context);
                }
                return _contactoPer;
            }
        }
        public IContrato Contratos
        {
            get
            {
                if (_contrato == null)
                {
                    _contrato = new ContratoRepository(_context);
                }
                return _contrato;
            }
        }
        public IDepartamento Departamentos
        {
            get
            {
                if (_departamento == null)
                {
                    _departamento = new DepartamentoRepository(_context);
                }
                return _departamento;
            }
        }
        public IDirPersona DirPersonas
        {
            get
            {
                if (_dirPersona == null)
                {
                    _dirPersona = new DirPersonaRepository(_context);
                }
                return _dirPersona;
            }
        }

        public IPais Paises
        {
            get
            {
                if (_pais == null)
                {
                    _pais = new PaisRepository(_context);
                }
                return _pais;
            }
        }

        public IEstado Estados
        {
            get
            {
                if (_estado == null)
                {
                    _estado = new EstadoRepository(_context);
                }
                return _estado;
            }
        }

        public IPersona Personas
        {
            get
            {
                if (_persona == null)
                {
                    _persona = new PersonaRepository(_context);
                }
                return _persona;
            }
        }

        public IProgramacion Programacion
        {
            get
            {
                if (_programacion == null)
                {
                    _programacion = new ProgramacionRepository(_context);
                }
                return _programacion;
            }
        }

        public IRol Rols
        {
            get
            {
                if (_rol == null)
                {
                    _rol = new RolRepository(_context);
                }
                return _rol;
            }
        }

        public ITipoContacto TipoContactos
        {
            get
            {
                if (_tipoContacto == null)
                {
                    _tipoContacto = new TipoContactoRepository(_context);
                }
                return _tipoContacto;
            }
        }

        public ITipoDireccion TipoDirecciones
        {
            get
            {
                if (_tipoDireccion == null)
                {
                    _tipoDireccion = new TipoDireccionRepository(_context);
                }
                return _tipoDireccion;
            }
        }

        public ITipoPersona TipoPersonas
        {
            get
            {
                if (_tipoPersona == null)
                {
                    _tipoPersona = new TipoPersonaRepository(_context);
                }
                return _tipoPersona;
            }
        }

        public ITurno Turnos
        {
            get
            {
                if (_turno == null)
                {
                    _turno = new TurnoRepository(_context);
                }
                return _turno;
            }
        }

        public IUser Users
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_context);
                }
                return _user;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}