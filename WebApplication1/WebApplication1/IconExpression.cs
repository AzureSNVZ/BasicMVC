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
    
    public partial class IconExpression
    {
        public int Id { get; set; }
        public int ExpressionTypeId { get; set; }
        public string Source { get; set; }
        public string Operator { get; set; }
        public string Value { get; set; }
        public string Icon { get; set; }
        public string IconDescription { get; set; }
    
        public virtual ExpressionType ExpressionType { get; set; }
    }
}
