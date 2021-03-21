using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Datos
{
    public class RepositorioTurnos : IRepositorio<Turno>
    {
        public static RepositorioTurnos Instancia = new RepositorioTurnos();
        public List<Turno> _turnos;


        public RepositorioTurnos()
        {
            var l = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            _turnos = new List<Turno>()
            {
                new Turno() {Codigo =  0,
                    Dias = l,
                    Inicio = new DateTime(1,1,1,0,0,0),
                    Fin = new DateTime(1,1,1,7,59,59) },
                new Turno() {Codigo =  1,
                    Dias = l,
                    Inicio = new DateTime(1,1,1,8,0,0),
                    Fin = new DateTime(1,1,1,15,59,59) },
                new Turno() {Codigo =  2,
                    Dias = l,
                    Inicio = new DateTime(1,1,1,16,0,0),
                    Fin = new DateTime(1,1,1,23,59,59) }
            };
        }

        public Turno TurnoActual()
        {
            var horaActual = DateTime.Now;

            if (horaActual.Hour < 8)
            {
                return _turnos[0]; 
            }
            else if (horaActual.Hour < 16)
            {
                return _turnos[1]; 
            }
            
            else return _turnos[2]; 
        }

        public Turno BuscarCodigo(int codigo)
        {
            return _turnos.Find(item => item.Codigo == codigo);
        }

        public void Guardar(Turno objeto)
        {
            _turnos.Add(objeto);
        }

        public Turno VerificarExistencia(int codigo)
        {
            return _turnos.Find(item => item.Codigo == codigo);
        }
    }
}
