//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace US_EXCHANGER.ModelEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPE_CHECKINOUT
    {
        public decimal ID_CHECKINOUT { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECHA_ENTRADA { get; set; }
        public string HORA { get; set; }
        public System.DateTime FECHA_SALIDA_PREVISTA { get; set; }
        public decimal CANT_NOCHES { get; set; }
        public string NO_PRESENTADO { get; set; }
        public string REGIMEN { get; set; }
        public string COMIDA { get; set; }
        public decimal ADULTO { get; set; }
        public decimal NINO { get; set; }
        public decimal BEBE { get; set; }
        public Nullable<decimal> ID_CLIENTE { get; set; }
        public Nullable<decimal> ID_EMPRESA { get; set; }
        public Nullable<decimal> ID_AGENCIA { get; set; }
        public Nullable<decimal> ID_TOUR_OPERADOR { get; set; }
        public Nullable<decimal> ID_CLIENTE_FACTURAR { get; set; }
        public string TIPO_TARIFA { get; set; }
        public string TIPO_HABITACION { get; set; }
        public string HABITACION { get; set; }
        public string SWT_TIPO_HABITACION { get; set; }
        public Nullable<decimal> ID_RESERVA { get; set; }
        public string OBSERVACION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string SWT_CHECKINOUT { get; set; }
        public Nullable<decimal> ID_CHECKINOUT_PARENT { get; set; }
        public string HORA_SALIDA { get; set; }
        public string TURNO { get; set; }
        public string TIPO_HABITACIONC { get; set; }
    }
}
