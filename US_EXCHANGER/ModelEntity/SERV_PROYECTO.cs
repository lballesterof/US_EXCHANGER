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
    
    public partial class SERV_PROYECTO
    {
        public decimal ID_PROYECTO { get; set; }
        public string CODIGO { get; set; }
        public Nullable<decimal> ID_CLIENTE { get; set; }
        public System.DateTime FECHA_REGISTRO { get; set; }
        public string NOMBRE { get; set; }
        public string OBSERVACION { get; set; }
        public string DIRECCION_SERVICIO { get; set; }
        public System.DateTime FECHA_INICIO_ESTIMADA { get; set; }
        public System.DateTime FECHA_FIN_ESTIMADA { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_REAL { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_REAL { get; set; }
        public string ESTADO { get; set; }
        public string RESPONSABLE1 { get; set; }
        public string RESPONSABLE2 { get; set; }
        public string MONEDA { get; set; }
        public Nullable<decimal> COSTO { get; set; }
        public Nullable<decimal> MARGEN { get; set; }
        public Nullable<decimal> VALOR_VENTA { get; set; }
        public string REFERENCIA1 { get; set; }
        public string REFERENCIA2 { get; set; }
        public Nullable<decimal> ID_PRESUPUESTO { get; set; }
        public string DEPARTAMENTO { get; set; }
        public string PROVINCIA { get; set; }
        public string DISTRITO { get; set; }
        public Nullable<decimal> LATITUD { get; set; }
        public Nullable<decimal> LONGITUD { get; set; }
        public string PRIORIDAD { get; set; }
        public string TIPO_OT { get; set; }
        public Nullable<System.DateTime> FECHA_AMPLIACION { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_REAL_AMPLIACION1 { get; set; }
        public string MOTIVO_AMPLIACION1 { get; set; }
        public Nullable<System.DateTime> FECHA_FIN_REAL_AMPLIACION2 { get; set; }
        public string MOTIVO_AMPLIACION2 { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string USUARIO_APROBACION { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION { get; set; }
        public string USUARIO_APROBACION_A1 { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION_A1 { get; set; }
        public string USUARIO_APROBACION_A2 { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION_A2 { get; set; }
        public string ESTADO_AMPLIACION { get; set; }
        public string ESTADO_PROYECTO { get; set; }
        public Nullable<decimal> ID_PEDIDO { get; set; }
        public string NUMCOR { get; set; }
    }
}
