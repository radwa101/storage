//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Setting
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int OptionID { get; set; }
        public string Value { get; set; }
    
        public virtual Option Option { get; set; }
        public virtual Option Option1 { get; set; }
        public virtual User User { get; set; }
    }
}
