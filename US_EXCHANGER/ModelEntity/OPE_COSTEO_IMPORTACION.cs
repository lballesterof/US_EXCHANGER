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
    
    public partial class OPE_COSTEO_IMPORTACION
    {
        public string ci_file_importacion { get; set; }
        public string ci_numero_ingreso { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal ci_cantidad { get; set; }
        public decimal ci_precio_compra { get; set; }
        public decimal ci_precio_estandar { get; set; }
        public decimal ci_precio_real { get; set; }
        public decimal ci_ano { get; set; }
        public decimal ci_mes { get; set; }
        public System.DateTime ci_fecha { get; set; }
        public string usuario_creacion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public string usuario_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public string ci_estado { get; set; }
        public string cdg_costeo { get; set; }
        public Nullable<decimal> ci_porcentaje_fob { get; set; }
        public Nullable<decimal> ci_incremento_real { get; set; }
        public Nullable<decimal> ci_costo_total { get; set; }
        public Nullable<decimal> ci_ratio_importacion { get; set; }
        public Nullable<decimal> ci_incremento_real_d { get; set; }
        public Nullable<decimal> ci_precio_real_d { get; set; }
        public Nullable<decimal> ci_costo_total_d { get; set; }
    }
}