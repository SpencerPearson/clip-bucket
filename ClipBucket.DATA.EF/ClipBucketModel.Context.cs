//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClipBucket.DATA.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ClipSlitEntities : DbContext
    {
        public ClipSlitEntities()
            : base("name=ClipSlitEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Clip> Clips { get; set; }
        public virtual DbSet<ClipSpeaker> ClipSpeakers { get; set; }
        public virtual DbSet<ClipTag> ClipTags { get; set; }
        public virtual DbSet<Medium> Mediums { get; set; }
        public virtual DbSet<Source> Sources { get; set; }
        public virtual DbSet<Speaker> Speakers { get; set; }
        public virtual DbSet<SubmitterDetail> SubmitterDetails { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    }
}
