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
    
    public partial class OPE_CONTRATO_PARQUEO
    {
        public decimal ID_CONTRATO { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public decimal ID_PERSONA { get; set; }
        public string ESTADO { get; set; }
        public decimal IMPORTE { get; set; }
        public string OBSERVACION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public Nullable<decimal> NRO_CUOTA { get; set; }
        public Nullable<decimal> ANO_INICIO { get; set; }
        public Nullable<decimal> MES_INICIO { get; set; }
        public string TIPO_TARIFA { get; set; }
        public string TIPO_VECHICULO { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FIN { get; set; }
        public Nullable<decimal> IMPORTE_PRORRATEO { get; set; }
        public Nullable<decimal> NUM_ESPACIO { get; set; }
        public string REFERENCIA { get; set; }
    }
}
