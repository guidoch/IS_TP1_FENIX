﻿using Servicio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Servicio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IServicio
    {
        [OperationContract]
        AutenticarDTO Autenticar(string user, string pass);
        [OperationContract]
        bool CerrarSesion(int sesion);
        [OperationContract]
        List<OPDTO> ListarOPs(int empleado);
        [OperationContract]
        bool ReanudarOP(int numero);
        [OperationContract]
        bool FinalizarOP(int numero);
        [OperationContract]
        bool PausarOP(int numero);
        [OperationContract]
        List<ModeloDTO> GetModelos();
        [OperationContract]
        List<ColorDTO> GetColores();
        [OperationContract]
        List<LineaTrabajoDTO> GetLineasLibres();
        [OperationContract]
        bool ControlarOPsTodasFinalizadas(int empleado);
        [OperationContract]
        bool IniciarOP(int numero, int linea, int modelo, int color, int empleado);
        [OperationContract]
        List<OPDTO> ListaOPs();
        [OperationContract]
        bool AptoCargarHermanado(int numero);
    }
}
