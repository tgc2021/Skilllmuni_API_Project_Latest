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
    
    public partial class tbl_brief_b2c_right_audit
    {
        public int id_brief_b2c_right_audit { get; set; }
        public Nullable<int> data_index { get; set; }
        public Nullable<int> id_organization { get; set; }
        public Nullable<int> id_user { get; set; }
        public Nullable<int> id_brief_question { get; set; }
        public Nullable<int> question_complexity { get; set; }
        public Nullable<System.DateTime> datetime_stamp { get; set; }
        public Nullable<int> value_count { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> updated_date_time { get; set; }
    }
}
