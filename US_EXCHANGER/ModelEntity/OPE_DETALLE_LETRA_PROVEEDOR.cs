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
    
    public partial class OPE_DETALLE_LETRA_PROVEEDOR
    {
        public string NUMERO_LETRA { get; set; }
        public int ID_PERSONA { get; set; }
        public string RUC_PROV { get; set; }
        public string BANCO { get; set; }
        public string NUMERO_CUENTA { get; set; }
        public string NUMERO_DOCUMENTO { get; set; }
        public string TIPO_DOCUMENTO { get; set; }
        public string MONEDA { get; set; }
        public int PLAZO { get; set; }
        public System.DateTime VENCIMIENTO { get; set; }
        public decimal IMPORTE { get; set; }
        public Nullable<System.DateTime> FECHA_GIRO { get; set; }
        public string LUGAR_GIRO { get; set; }
        public string REFERENCIA_GIRO { get; set; }
        public string NOMBRE_AVAL { get; set; }
        public string DIRECCION_AVAL { get; set; }
        public string RUC_AVAL { get; set; }
        public string TELEFONO_AVAL { get; set; }
        public string NUMERO_BANCO { get; set; }
        public string NUMERO_LORI { get; set; }
        public string ESTADO { get; set; }
        public string SECCION { get; set; }
        public string COR_LREN { get; set; }
        public string NUMERO_LREN { get; set; }
        public string NUM_ORIG { get; set; }
        public string NUM_VOUC { get; set; }
        public Nullable<decimal> IMPORTE_RET { get; set; }
        public decimal TIPO_CAMBIO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}
