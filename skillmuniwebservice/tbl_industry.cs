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
    
    public partial class tbl_industry
    {
        public tbl_industry()
        {
            this.tbl_organization = new HashSet<tbl_organization>();
        }
    
        public int ID_INDUSTRY { get; set; }
        public string INDUSTRYNAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string STATUS { get; set; }
        public System.DateTime UPDATED_DATE_TIME { get; set; }
    
        public virtual ICollection<tbl_organization> tbl_organization { get; set; }
    }
}
