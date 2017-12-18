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
    
    public partial class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program()
        {
            this.News = new HashSet<News>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string StartTime { get; set; }
        public string RunTime { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public Nullable<int> ChannelId { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
    
        public virtual Channel Channel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<News> News { get; set; }
    }
}
