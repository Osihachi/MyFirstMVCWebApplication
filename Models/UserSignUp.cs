//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyFirstWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserSignUp
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> State_id { get; set; }
    
        public virtual StateOfOrigination StateOfOrigination { get; set; }
    }
}
