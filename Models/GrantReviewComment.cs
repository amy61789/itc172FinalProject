//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCAssignment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GrantReviewComment
    {
        public int GrantReviewCommentKey { get; set; }
        public Nullable<int> GrantReviewKey { get; set; }
        public Nullable<int> EmployeeKey { get; set; }
        public System.DateTime GrantReviewCommentDate { get; set; }
        public string GrantReviewNote { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual GrantReview GrantReview { get; set; }
    }
}
