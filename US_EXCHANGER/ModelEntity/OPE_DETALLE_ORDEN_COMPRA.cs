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
    
    public partial class OPE_DETALLE_ORDEN_COMPRA
    {
        public int ID_PRODUCTO { get; set; }
        public int ID_OC { get; set; }
        public decimal PRECIO { get; set; }
        public decimal CANTIDAD { get; set; }
        public string AFECTO { get; set; }
        public int SECUENCIA { get; set; }
        public decimal IMPORTE { get; set; }
        public decimal CANTIDAD_INGRESADA { get; set; }
        public decimal CANTIDAD_FACTURADA { get; set; }
        public string CODIGO_UNIDAD { get; set; }
        public string DESCRIPCION_EXTENDIDA { get; set; }
        public Nullable<decimal> DSCTO { get; set; }
        public Nullable<decimal> PRECIO_ORI { get; set; }
        public Nullable<System.DateTime> FECHA_ENTREGA { get; set; }
        public Nullable<int> SEC_REQ { get; set; }
        public string REQ { get; set; }
        public string AI { get; set; }
        public string CDG_CC { get; set; }
        public Nullable<decimal> POR_DETRACCION { get; set; }
        public Nullable<decimal> DETRACCION { get; set; }
        public Nullable<decimal> FACTOR_CONVERSION { get; set; }
        public string SCDG_CC { get; set; }
        public Nullable<decimal> ID_REQ { get; set; }
    
        public virtual OPE_ORDEN_COMPRA OPE_ORDEN_COMPRA { get; set; }
    }
}
