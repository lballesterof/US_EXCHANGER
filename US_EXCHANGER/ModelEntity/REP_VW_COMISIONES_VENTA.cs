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
    
    public partial class REP_VW_COMISIONES_VENTA
    {
        public string VENDEDOR { get; set; }
        public string NUMERO_PEDIDO { get; set; }
        public string RUC { get; set; }
        public string CLIENTE { get; set; }
        public string TIPO_DOCUMENTO { get; set; }
        public string NUMERO_DOCU { get; set; }
        public string DD_FECHA_DOCUMENTO { get; set; }
        public string DD_FECHA_VENCIMIENTO { get; set; }
        public decimal IMPORTE_SOLES { get; set; }
        public decimal IMPORTE_DOLAR { get; set; }
        public decimal COBRADO { get; set; }
        public Nullable<decimal> POR_COBRAR { get; set; }
        public decimal IGV { get; set; }
        public Nullable<decimal> COMISION { get; set; }
        public Nullable<decimal> COMISION_PAGADA { get; set; }
        public Nullable<decimal> COMISION_POR_PAGAR { get; set; }
    }
}
