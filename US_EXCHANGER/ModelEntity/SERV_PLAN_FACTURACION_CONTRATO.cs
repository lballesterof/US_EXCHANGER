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
    
    public partial class SERV_PLAN_FACTURACION_CONTRATO
    {
        public string CDG_SERVICIO { get; set; }
        public decimal ID_PEDIDO { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal SECUENCIA { get; set; }
        public string DESCRIPCION_FACTURA { get; set; }
        public System.DateTime FECHA_FACTURACION { get; set; }
        public string CDG_RESPONSABLE { get; set; }
        public string CDG_MONEDA { get; set; }
        public decimal IMPORTE { get; set; }
        public string ESTADO { get; set; }
        public string TIPO_CUOTA { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}