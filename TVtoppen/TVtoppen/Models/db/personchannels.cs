//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TVtoppen.Models.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class personchannels
    {
        public int personfavid { get; set; }
        public Nullable<int> channelid { get; set; }
        public Nullable<int> personid { get; set; }
    
        public virtual Channel Channel { get; set; }
        public virtual Person Person { get; set; }
    }
}
