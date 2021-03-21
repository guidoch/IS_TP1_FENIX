using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class GestorListaOPSupLinea
    {
        public static List<OP> ListarOPs(int empleado)
        {
            return RepositorioOP.Instancia.BuscarSupervisorLinea(empleado);
        }

        public static bool ReanudarOP(int numero)
        {
            var op = (RepositorioOP.Instancia.BuscarCodigo(numero));
            if (op.Estado != Estado.PAUSADA)
                return false; // MessageBox.Show("OP no se puede reanudar", "Aviso");
            else
            {
                op.Reanudar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP reanudada", "Aviso");
            }
        }

        public static bool FinalizarOP(int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);
            if (op.Estado != Estado.PAUSADA)
                return false; // MessageBox.Show("OP no se puede finalizar", "Aviso");
            else
            {
                op.Finalizar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP finalizada", "Aviso");
            }
        }

        public static bool PausarOP(int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);
            if (op.Estado != Estado.EN_PROCESO)
                return false; // MessageBox.Show("OP no se puede pausar", "Aviso");
            else
            {
                op.Pausar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP pausada", "Aviso");
            }
        }
        public static bool ControlarTodasFinalizadas(int supervisor)
        {
            return RepositorioOP.Instancia.TodasFinalizadas(supervisor);
        }

        /*public GestorListaOPSupLinea( int codSup)
        {
            //this._presentador = presentador;
            this.Supervisor = RepositorioEmpleados.Instancia.BuscarCodigo(codSup);
            RepositorioOP.Suscribe(Actualizar); //me suscribo para recibir aaactualizaciones del repo
        }

        private void Actualizar()
        {
            //_presentador.Actualizar();//ROTO BUSCAR SOLUCION //OJO!
        }
        internal List<OP> ListarOPs()
        {
            return RepositorioOP.Instancia.BuscarSupervisorLinea(Supervisor);
        }

        internal bool ControlarTodasFinalizadas()
        {
            return RepositorioOP.Instancia.TodasFinalizadas(Supervisor);
        }

        internal bool ReanudarOP(int numero)
        {
            var op = (RepositorioOP.Instancia.BuscarCodigo(numero));
            if (op.Estado != Estado.PAUSADA) 
                return false; // MessageBox.Show("OP no se puede reanudar", "Aviso");
            else
            {
                op.Reanudar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP reanudada", "Aviso");
            }
        }

        internal bool FinalizarOP(int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);
            if (op.Estado != Estado.PAUSADA)
                return false; // MessageBox.Show("OP no se puede finalizar", "Aviso");
            else
            {
                op.Finalizar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP finalizada", "Aviso");
            }
        }

        internal bool PausarOP (int numero)
        {
            var op = RepositorioOP.Instancia.BuscarCodigo(numero);
            if (op.Estado != Estado.EN_PROCESO)
                return false; // MessageBox.Show("OP no se puede pausar", "Aviso");
            else
            {
                op.Pausar();
                RepositorioOP.Instancia.Actualizar(op); //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< REVISAR (falta implementar)
                return true; // MessageBox.Show("OP pausada", "Aviso");
            }
        }*/
    }
}
