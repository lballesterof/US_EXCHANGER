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
    
    public partial class OPE_DETALLE_PROGRAMACION_PAGO
    {
        public string CODIGO_EMPRESA { get; set; }
        public string CODIGO_SUCURSAL { get; set; }
        public string NUM { get; set; }
        public string TIPO_DOCUMENTO { get; set; }
        public string MONEDA { get; set; }
        public int ID_DOCUMENTO { get; set; }
        public string FORMA_PAGO { get; set; }
        public decimal TIPO_CAMBIO { get; set; }
        public System.DateTime FECHA_PAGO { get; set; }
        public decimal IMPORTE_PAGO { get; set; }
        public string ESTADO { get; set; }
        public Nullable<decimal> ID_PERSONA { get; set; }
        public string NUMERO { get; set; }
        public string BANCO { get; set; }
        public string NUMERO_CHEQUE { get; set; }
        public string CUENTA_BANCARIA { get; set; }
        public string RUC_PROV { get; set; }
        public string MONEDA_ORI { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}