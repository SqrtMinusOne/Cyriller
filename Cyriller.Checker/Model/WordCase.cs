//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cyriller.Checker.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class WordCase
    {
        public int ID { get; set; }
        public int WordID { get; set; }
        public int CaseID { get; set; }
        public int NumberID { get; set; }
        public string Name { get; set; }
        public Nullable<int> AnimateID { get; set; }
        public Nullable<int> GenderID { get; set; }
        public bool Error { get; set; }
        public bool Checked { get; set; }
    
        public virtual Animate Animate { get; set; }
        public virtual Case Case { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Number Number { get; set; }
        public virtual Word Word { get; set; }
    }
}