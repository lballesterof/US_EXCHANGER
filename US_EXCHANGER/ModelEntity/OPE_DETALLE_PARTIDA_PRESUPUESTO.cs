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
    
    public partial class OPE_DETALLE_PARTIDA_PRESUPUESTO
    {
        public decimal ID_PRESUPUESTO { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal ID_ITEM { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal HORAS { get; set; }
        public decimal PRECIO_UNITARIO { get; set; }
        public decimal TOTAL { get; set; }
        public decimal SECUENCIA { get; set; }
        public string TIPO { get; set; }
        public Nullable<decimal> SEC_PROD { get; set; }
        public Nullable<decimal> PRECIO_UNITARIO_ORI { get; set; }
    }
}
