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
    
    public partial class OPE_ESTADO_HABITACION
    {
        public Nullable<decimal> ID_RESERVA { get; set; }
        public Nullable<decimal> ID_CHECKIN { get; set; }
        public decimal ID_HABITACION { get; set; }
        public string ABREVIATURA { get; set; }
        public System.DateTime FECHA { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string SWT_SUCIO { get; set; }
        public Nullable<decimal> ID_DOCUMENTO { get; set; }
    }
}
