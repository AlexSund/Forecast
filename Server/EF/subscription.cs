//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class subscription
    {
        public int subscription_id { get; set; }
        public int user_id { get; set; }
        public int subscription_type_id { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime finish_date { get; set; }
    
        public virtual subscription_types subscription_types { get; set; }
        public virtual user user { get; set; }
    }
}