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
    
    public partial class stock
    {
        public stock()
        {
            this.forecasts = new HashSet<forecast>();
            this.user_stocks = new HashSet<user_stocks>();
        }
    
        public int stock_id { get; set; }
        public decimal price { get; set; }
        public decimal stock_price { get; set; }
        public int user_count { get; set; }
    
        public virtual ICollection<forecast> forecasts { get; set; }
        public virtual ICollection<user_stocks> user_stocks { get; set; }
    }
}