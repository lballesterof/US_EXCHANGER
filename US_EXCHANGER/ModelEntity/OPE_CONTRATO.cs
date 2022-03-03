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
    
    public partial class OPE_CONTRATO
    {
        public decimal ID_CONTRATO { get; set; }
        public decimal ID_PERSONA { get; set; }
        public decimal ID_PERSONA_ARRENDADOR { get; set; }
        public decimal ID_PERSONA_COPROPIETARIO { get; set; }
        public decimal ID_PERSONA_GARANTE { get; set; }
        public decimal ID_PERSONA_RESPONSABLE_PAGO { get; set; }
        public decimal ID_PERSONA_OTRO { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public string MONEDA { get; set; }
        public decimal PRECIO { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal IMPORTE { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_G { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_G { get; set; }
        public Nullable<decimal> PRECIO_G { get; set; }
        public Nullable<decimal> CANTIDAD_G { get; set; }
        public Nullable<decimal> IMPORTE_G { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_RP { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_RP { get; set; }
        public Nullable<decimal> PRECIO_RP { get; set; }
        public Nullable<decimal> CANTIDAD_RP { get; set; }
        public Nullable<decimal> IMPORTE_RP { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_OT { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_OT { get; set; }
        public Nullable<decimal> PRECIO_OT { get; set; }
        public Nullable<decimal> CANTIDAD_OT { get; set; }
        public Nullable<decimal> IMPORTE_OT { get; set; }
        public Nullable<decimal> ID_PRODUCTO { get; set; }
        public string FACTURA { get; set; }
        public string OPERADOR { get; set; }
        public string ESTADO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}
