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
    
    public partial class OPE_CIERRE_DIARIO_CAJA
    {
        public string CODIGO_SUCURSAL { get; set; }
        public System.DateTime FECHA_CAJA { get; set; }
        public decimal SALDO_ANTERIOR { get; set; }
        public decimal INGRESO { get; set; }
        public decimal EGRESO { get; set; }
        public decimal SALDO_FINAL { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string CDG_CAJA { get; set; }
        public string CODIGO_TURNO { get; set; }
        public string CODIGO_MONEDA { get; set; }
        public string CODIGO_CAJERO { get; set; }
    }
}
