//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace m2ostnextservice
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_survey_bank
    {
        public tbl_survey_bank()
        {
            this.tbl_survey_bank_link = new HashSet<tbl_survey_bank_link>();
            this.tbl_survey_data = new HashSet<tbl_survey_data>();
        }
    
        public int ID_SURVEY_BANK { get; set; }
        public string SURVEY_QUESTION { get; set; }
        public string SURVEY_CHOICES { get; set; }
        public string STATUS { get; set; }
        public System.DateTime UPDATED_DATE_TIME { get; set; }
    
        public virtual ICollection<tbl_survey_bank_link> tbl_survey_bank_link { get; set; }
        public virtual ICollection<tbl_survey_data> tbl_survey_data { get; set; }
    }
}
