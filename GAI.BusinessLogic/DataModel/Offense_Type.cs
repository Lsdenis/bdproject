//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAI.BusinessLogic.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offense_Type
    {
        public Offense_Type()
        {
            this.Offenses = new HashSet<Offense>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<bool> Deleted { get; set; }
    
        public virtual ICollection<Offense> Offenses { get; set; }
    }
}
