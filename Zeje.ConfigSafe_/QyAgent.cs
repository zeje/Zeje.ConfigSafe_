//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zeje.ConfigSafe_
{
    using System;
    using System.Collections.Generic;
    
    public partial class QyAgent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QyAgent()
        {
            this.QyAdmin = new HashSet<QyAdmin>();
            this.QyUser = new HashSet<QyUser>();
        }
    
        public int agentid { get; set; }
        public string name { get; set; }
        public string square_logo_url { get; set; }
        public string round_logo_url { get; set; }
        public string description { get; set; }
        public bool close { get; set; }
        public string redirect_domain { get; set; }
        public Nullable<int> report_location_flag { get; set; }
        public bool isreportuser { get; set; }
        public bool isreportenter { get; set; }
        public int type { get; set; }
        public System.DateTime syntime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QyAdmin> QyAdmin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QyUser> QyUser { get; set; }
    }
}