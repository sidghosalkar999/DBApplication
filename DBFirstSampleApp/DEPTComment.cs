//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirstSampleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEPTComment
    {
        public int DEPTID { get; set; }
        public string title { get; set; }
        public string Comments { get; set; }
    
        public virtual DEPTComment DEPTComment1 { get; set; }
        public virtual DEPTComment DEPTComment2 { get; set; }
    }
}
