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
    
    public partial class RRHH_CONTRATO
    {
        public decimal ID_PERSONA { get; set; }
        public string TIPO_CONTRATO { get; set; }
        public Nullable<System.DateTime> INICIO_PRUEBA { get; set; }
        public Nullable<System.DateTime> FIN_PRUEBA { get; set; }
        public System.DateTime FECHA_INSCRIPCION { get; set; }
        public System.DateTime FECHA_INICIO { get; set; }
        public System.DateTime FECHA_FIN { get; set; }
        public string RENOVACION { get; set; }
        public byte[] CONTRATO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    }
}
