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
    
    public partial class OPE_DETALLE_CHECKINOUT
    {
        public decimal ID_CHECKINOUT { get; set; }
        public string ID_HABITACION { get; set; }
        public string ID_CONCEPTO { get; set; }
        public decimal UNIDAD { get; set; }
        public decimal DIAS { get; set; }
        public System.DateTime FECHA { get; set; }
        public decimal PRECIO { get; set; }
        public decimal DSCTO { get; set; }
        public decimal IMPORTE { get; set; }
        public string TIPO { get; set; }
        public string SWT_FACT { get; set; }
        public Nullable<decimal> SECUENCIA { get; set; }
        public string SUPLEMENTO { get; set; }
        public string SWT_AUTO { get; set; }
        public Nullable<decimal> ID_PRODUCTO { get; set; }
        public Nullable<decimal> ID_PEDIDO { get; set; }
    }
}