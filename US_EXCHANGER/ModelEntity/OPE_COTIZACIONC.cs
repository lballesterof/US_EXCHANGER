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
    
    public partial class OPE_COTIZACIONC
    {
        public string CODIGO { get; set; }
        public System.DateTime FECHA { get; set; }
        public Nullable<System.DateTime> FECHA_ENTREGA { get; set; }
        public string LUGAR_ENTREGA { get; set; }
        public string CONDICION_PAGO { get; set; }
        public string MONEDA { get; set; }
        public Nullable<int> ID_PERSONA { get; set; }
        public Nullable<decimal> SUB_TOTAL { get; set; }
        public Nullable<decimal> DSCTO { get; set; }
        public Nullable<decimal> PORCENTAJE_DSCTO { get; set; }
        public Nullable<decimal> IGV { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string ESTADO { get; set; }
        public string OBSERVACION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string SWT_COTI { get; set; }
        public Nullable<decimal> TIPO_CAMBIO { get; set; }
        public string RESPONSABLE { get; set; }
        public Nullable<decimal> VALOR_COMPRA { get; set; }
        public string NUM_REQ { get; set; }
    }
}
