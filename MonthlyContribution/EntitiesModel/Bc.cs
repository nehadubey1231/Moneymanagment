//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonthlyContribution.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bc
    {
        public int id { get; set; }
        public string fullName { get; set; }
        public string totalAmount { get; set; }
        public string duration { get; set; }
        public string monthlyContryPerPerson { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<bool> statusCode { get; set; }
        public Nullable<System.DateTime> createdAt { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public string totalMember { get; set; }
    }
}
