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
    
    public partial class tbl_action
    {
        public tbl_action()
        {
            this.tbl_user_data = new HashSet<tbl_user_data>();
        }
    
        public int ID_ACTION { get; set; }
        public string ACTION_NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string STATUS { get; set; }
        public System.DateTime UPDATED_DATE_TIME { get; set; }
    
        public virtual ICollection<tbl_user_data> tbl_user_data { get; set; }
    }
}
