//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HKSTP.TalentPool.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_JOB_APPLICANT_CV_ACTION_HISTORY
    {
        public int ID { get; set; }
        public Nullable<int> JobSeeker_CV_ID { get; set; }
        public Nullable<int> Action { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<int> Employer_ID { get; set; }
    
        public virtual TB_JOB_SEEKER_CV TB_JOB_SEEKER_CV { get; set; }
    }
}