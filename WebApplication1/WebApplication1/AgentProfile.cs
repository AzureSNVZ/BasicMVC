//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgentProfile
    {
        public int Id { get; set; }
        public int AgentId { get; set; }
        public int ProfileId { get; set; }
        public bool IsDefault { get; set; }
        public string TargetDescription { get; set; }
        public string SkinCode { get; set; }
        public string AvatarCode { get; set; }
        public bool Active { get; set; }
    
        public virtual Profile Profile { get; set; }
        public virtual Agent Agent { get; set; }
    }
}