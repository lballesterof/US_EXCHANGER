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
    
    public partial class RRHH_SEMANA
    {
        public string ANO { get; set; }
        public decimal MES { get; set; }
        public decimal SEMANA { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public System.DateTime FECHA_PAGO { get; set; }
        public decimal NUMERO_HORA { get; set; }
        public Nullable<decimal> NUMERO_FERIADO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string CDG_PROY { get; set; }
        public Nullable<decimal> DIAS_FERIADO { get; set; }
    }
}
