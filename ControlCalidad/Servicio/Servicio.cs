using Aplicacion;
using Dominio;
using Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    public class Servicio : IServicio
    {
        public AutenticarDTO Autenticar(string user, string pass)
        {
            var aux = GestorAutenticar.Autenticar(user, pass);
            if (aux.Item1 == null)
            {
                return new AutenticarDTO() { Estado = aux.Item2 };
            }
            else
            {
                var login = new AutenticarDTO()
                {
                    Estado = aux.Item2,
                    Sesion = aux.Item1.Codigo,
                    Usuario = aux.Item1.User.Codigo,
                    Empleado = aux.Item1.User.Empleado.Codigo,
                    Nombre = aux.Item1.User.Empleado.Nombre
                };
                switch (aux.Item1.User.Empleado.Cargo)
                {
                    case Cargo.SUP_LINEA:
                        login.Cargo = Cargo.SUP_LINEA.ToString();
                        break;
                    case Cargo.SUP_CALIDAD:
                        login.Cargo = Cargo.SUP_CALIDAD.ToString();
                        break;
                    case Cargo.ADMIN:
                        login.Cargo = Cargo.ADMIN.ToString();
                        break;
                    default:
                        break;
                }
                return login;
            }
        }

        public bool CerrarSesion(int sesion)
        {
            return GestorPrincipal.CerrarSesion(sesion);
        }

        public List<OPDTO> ListarOPs(int empleado)
        {
            var aux = GestorListaOPSupLinea.ListarOPs(empleado);
            var ops = new List<OPDTO>();
            foreach (var op in aux)
            {
                ops.Add(new OPDTO()
                {
                    Numero = op.Numero,
                    Modelo = op.Modelo.SKU,
                    Color = op.Color.Codigo,
                    Hermanado = op.Hermanado,
                    Estado = op.Estado.ToString(),
                    Linea = op.Linea.Numero,
                    Supervisor = op.Supervisor.Codigo
                });
            }
            return ops;
        }

        public bool FinalizarOP(int numero)
        {
            return GestorListaOPSupLinea.FinalizarOP(numero);
        }

        public bool PausarOP(int numero)
        {
            return GestorListaOPSupLinea.PausarOP(numero);
        }

        public bool ReanudarOP(int numero)
        {
            return GestorListaOPSupLinea.ReanudarOP(numero);
        }

        public List<ModeloDTO> GetModelos()
        {
            var aux = GestorIniciarOP.ListarModelos();
            var modelos = new List<ModeloDTO>();
            foreach (var modelo in aux)
            {
                modelos.Add(new ModeloDTO()
                {
                    SKU = modelo.SKU,
                    Denominacion = modelo.Denominacion,
                    Objetivo = modelo.Objetivo
                });
            }
            return modelos;
        }

        public List<ColorDTO> GetColores()
        {
            var aux = GestorIniciarOP.ListarColores();
            var colores = new List<ColorDTO>();
            foreach (var color in aux)
            {
                colores.Add(new ColorDTO()
                {
                    Codigo = color.Codigo,
                    Descripcion = color.Descripcion
                });
            }
            return colores;
        }

        public List<LineaTrabajoDTO> GetLineasLibres()
        {
            var aux = GestorIniciarOP.ListarLineasLibres();
            var lineas = new List<LineaTrabajoDTO>();
            foreach (var linea in aux)
            {
                lineas.Add(new LineaTrabajoDTO()
                {
                    Numero = linea.Numero,
                    Descripcion = linea.Descripcion
                });
            }
            return lineas;
        }

        public bool ControlarOPsTodasFinalizadas(int empleado)
        {
            return GestorListaOPSupLinea.ControlarTodasFinalizadas(empleado);
        }

        public bool IniciarOP(int numero, int linea, int modelo, int color, int empleado)
        {
            return GestorIniciarOP.IniciarOP(numero, linea, modelo, color, empleado);
        }

        public List<OPDTO> ListaOPs()
        {
            var aux = GestorListaOPSupCalidad.ListaOPs();
            var ops = new List<OPDTO>();
            foreach (var op in aux)
            {
                ops.Add(new OPDTO()
                {
                    Numero = op.Numero,
                    Modelo = op.Modelo.SKU,
                    Color = op.Color.Codigo,
                    Hermanado = op.Hermanado,
                    Estado = op.Estado.ToString(),
                    Linea = op.Linea.Numero,
                    Supervisor = op.Supervisor.Codigo
                });
            }
            return ops;
        }

        public bool AptoCargarHermanado(int numero)
        {
            return GestorListaOPSupCalidad.AptoCargarHermanado(numero);
        }

        public OPDTO GetOP(int numero)
        {
            var op = GestorCargarHermanado.GetOP(numero);
            return new OPDTO()
            {
                Numero = op.Numero,
                Modelo = op.Modelo.SKU,
                Color = op.Color.Codigo,
                Hermanado = op.Hermanado,
                Estado = op.Estado.ToString(),
                Linea = op.Linea.Numero,
                Supervisor = op.Supervisor.Codigo
            };
        }

        public bool CargarHermanado(int hermanado, int op)
        {
            return GestorCargarHermanado.CargarHermanado(hermanado, op);
        }

        public int AsociarOP(int numero, int supervisor)
        {
            return GestorListaOPSupCalidad.AsociarOP(numero, supervisor);
        }

        public List<TipoDefectoDTO> ListarTipoDefectos()
        {
            var aux = GestorRegistrarInspeccion.ListarTiposDefectos();
            var defectos = new List<TipoDefectoDTO>() { };
            foreach (var def in aux)
            {
                defectos.Add(new TipoDefectoDTO()
                {
                    Codigo = def.Codigo,
                    Descripcion = def.Descripcion,
                    Tipo = def.Tipo.ToString()
                });
            }
            return defectos;
        }

        public int RegistrarInspeccion(int numeroOP, List<DefectoDTO> defectos)
        {
            var aux = new List<Defecto>() { };
            foreach (var d in defectos)
            {
                var def = new Defecto(){Codigo = d.Codigo};
                switch (d.Pie)
                {
                    case "Izquierdo":
                        def.Pie = Pie.IZQ;
                        break;
                    case "Derecho":
                        def.Pie = Pie.DER;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                def.TipoDefecto = GestorRegistrarInspeccion.TipoDefecto(d.TipoDefectoCodigo);
                aux.Add(def); 
            }
            
            return GestorRegistrarInspeccion.RegistrarInspeccion(numeroOP, aux);
        }

        public bool DesasociarOP(int numeroOP)
        {
            return GestorRegistrarInspeccion.DesasociarOP(numeroOP);
        }



        public InspeccionDTO GetInspeccion(int codigo)
        {
            throw new NotImplementedException();
        }

        public DefectoDTO GetDefecto(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
