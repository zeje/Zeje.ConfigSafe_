﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QYEntities : DbContext
    {
        public QYEntities()
            : base("name=QYEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<QyAdmin> QyAdmin { get; set; }
        public virtual DbSet<QyAgent> QyAgent { get; set; }
        public virtual DbSet<QyAgentSet> QyAgentSet { get; set; }
        public virtual DbSet<QyDepartment> QyDepartment { get; set; }
        public virtual DbSet<QyEventLocation> QyEventLocation { get; set; }
        public virtual DbSet<QyGetImage> QyGetImage { get; set; }
        public virtual DbSet<QyGetLocation> QyGetLocation { get; set; }
        public virtual DbSet<QyGetText> QyGetText { get; set; }
        public virtual DbSet<QyGetVideo> QyGetVideo { get; set; }
        public virtual DbSet<QyGetVoice> QyGetVoice { get; set; }
        public virtual DbSet<QySetFile> QySetFile { get; set; }
        public virtual DbSet<QySetImage> QySetImage { get; set; }
        public virtual DbSet<QySetMpNews> QySetMpNews { get; set; }
        public virtual DbSet<QySetNews> QySetNews { get; set; }
        public virtual DbSet<QySetText> QySetText { get; set; }
        public virtual DbSet<QySetVideo> QySetVideo { get; set; }
        public virtual DbSet<QySetVoice> QySetVoice { get; set; }
        public virtual DbSet<QySourceMedia> QySourceMedia { get; set; }
        public virtual DbSet<QySourceMpNews> QySourceMpNews { get; set; }
        public virtual DbSet<QyTag> QyTag { get; set; }
        public virtual DbSet<QyUser> QyUser { get; set; }
        public virtual DbSet<QyUserConfig> QyUserConfig { get; set; }
        public virtual DbSet<QyUserConfigRecord> QyUserConfigRecord { get; set; }
    }
}
