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
    
    public partial class OPE_DETALLE_HABITACION
    {
        public decimal ID_SECUENCIA { get; set; }
        public decimal ID_HABITACION { get; set; }
        public Nullable<decimal> ID_EMPLEADO { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO { get; set; }
        public string HORA { get; set; }
        public Nullable<System.DateTime> FECHA_FIN { get; set; }
        public string OBSERVACION { get; set; }
        public string TIPO_DETALLE { get; set; }
    }
}
