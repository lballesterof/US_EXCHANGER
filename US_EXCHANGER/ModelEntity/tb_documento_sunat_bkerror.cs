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
    
    public partial class tb_documento_sunat_bkerror
    {
        public string codi_empr { get; set; }
        public string tipo_docu { get; set; }
        public string nume_docu { get; set; }
        public string tipo_docu_clie { get; set; }
        public string nume_docu_clie { get; set; }
        public string nomb_clie { get; set; }
        public Nullable<System.DateTime> fech_docu { get; set; }
        public string moneda { get; set; }
        public Nullable<decimal> valo_vent { get; set; }
        public Nullable<decimal> valo_igv { get; set; }
        public Nullable<decimal> valo_tota { get; set; }
        public byte[] xml_file { get; set; }
        public byte[] zip_file { get; set; }
        public byte[] pdf_file { get; set; }
        public byte[] zip_rpta { get; set; }
        public byte[] codi_barra { get; set; }
        public string nume_ticket { get; set; }
        public string mensaje { get; set; }
        public bool flag_error { get; set; }
        public bool flag_envio { get; set; }
        public string usua_crea { get; set; }
        public System.DateTime fech_crea { get; set; }
        public string usua_modi { get; set; }
        public Nullable<System.DateTime> fech_modi { get; set; }
        public string estado { get; set; }
    }
}
