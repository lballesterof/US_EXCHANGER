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
    
    public partial class OPE_TICKET
    {
        public decimal ID_DOCUMENTO { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public string NUM_TICKET { get; set; }
        public Nullable<System.DateTime> FECHA_ATENCION { get; set; }
        public string CODIGO_TURNO { get; set; }
        public string ESTADO { get; set; }
        public string OBSERVACION { get; set; }
        public System.DateTime FECHA_CREACION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
    }
}
