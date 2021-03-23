using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class GestorListaOPSupCalidad
    {
        public static List<OP> ListaOPs()
        {
            return RepositorioOP.Instancia._ops;
        }

        public static bool AptoCargarHermanado(int numero)
        {
            if (RepositorioOP.Instancia.BuscarCodigo(numero).Estado != Estado.FINALIZADA)
            {
                return true;
            }
            else return false;
        }

        public static int AsociarOP(int numero, int supervisor)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);

            if (!RepositorioOP.Instancia.SupervisorDisponible(RepositorioEmpleados.Instancia.BuscarCodigo(supervisor)))
                return 1;//MessageBox.Show("No se puede asociar a OP, supervisor ya asociado a otra op", "Aviso");
            else
            {
                if (op.Estado == Estado.EN_PROCESO)
                    if (op.AsociarSupCalidad(RepositorioEmpleados.Instancia.BuscarCodigo(supervisor))) //debe controlar que no haya otro sup asociado (verificar implementacion -> si lo hace)
                    {
                        RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                        //!!!_presentador.IniciarVistaRegistrarInspeccion(op.Numero, Supervisor.Codigo);//new VistaRegistrarInspeccion(op, _supervisor).Show(); //ROTO BUSCAR SOLUCION //OJO!
                        return 0;//MessageBox.Show("Asociado a OP", "Aviso");

                    }
                    else
                        return 2;//MessageBox.Show("No se puede asociar, op ya asociada a otro supervisor de calidad.", "Aviso");
                else
                    return 3;//MessageBox.Show("No se puede asociar a OP, OP no esta en proceso", "Aviso");
            }
        }


        /*public GestorListaOPSupCalidad(PresentadorListaOPSupCalidad presentadorListaOPSupCalidad, int codSup)
        {
            //this._presentador = presentadorListaOPSupCalidad;
            this.Supervisor = RepositorioEmpleados.Instancia.BuscarCodigo(codSup);
            RepositorioOP.Suscribe(Actualizar); //me suscribo para recibir aaactualizaciones del repo
        }
        private void Actualizar()
        {
            //_presentador.Actualizar();//ROTO BUSCAR SOLUCION //OJO!
        }

        internal object ListaOPs()
        {
            return RepositorioOP.Instancia._ops;
        }

        internal int Asociar(int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);

            if (!RepositorioOP.Instancia.SupervisorDisponible(Supervisor))
                return 1;//MessageBox.Show("No se puede asociar a OP, supervisor ya asociado a otra op", "Aviso");
            else
            {
                if (op.Estado == Estado.EN_PROCESO)
                    if (op.AsociarSupCalidad(Supervisor)) //debe controlar que no haya otro sup asociado (verificar implementacion -> si lo hace)
                    {
                        RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                        //!!!_presentador.IniciarVistaRegistrarInspeccion(op.Numero, Supervisor.Codigo);//new VistaRegistrarInspeccion(op, _supervisor).Show(); //ROTO BUSCAR SOLUCION //OJO!
                        return 0;//MessageBox.Show("Asociado a OP", "Aviso");
                        
                    }
                    else
                        return 2;//MessageBox.Show("No se puede asociar, op ya asociada a otro supervisor de calidad.", "Aviso");
                else
                    return 3;//MessageBox.Show("No se puede asociar a OP, OP no esta en proceso", "Aviso");
            }
        }

        internal bool CargarHermanado(int numero)
        {
            if (RepositorioOP.Instancia.BuscarCodigo(numero).Estado != Estado.FINALIZADA)
            {
                //!!_presentador.IniciarVistaCargarHermanado(numero);//ROTO BUSCAR SOLUCION //OJO!
                return true;
            }
            else return false;
        }*/
    }
}
