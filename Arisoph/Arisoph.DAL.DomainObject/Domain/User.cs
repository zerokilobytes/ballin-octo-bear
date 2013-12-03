using System;
using System.Text;
using System.Collections.Generic;


namespace Arisoph.DAL.DomainObject.Domain {
    
    public class User {
        public User() { }
        public virtual long UserID { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Gender { get; set; }
        public virtual string EmailAddress { get; set; }
        public virtual System.Nullable<System.Guid> GUID { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual DateTime? DOB { get; set; }
        public virtual string Password { get; set; }
        public virtual string Verified { get; set; }
        public virtual string Active { get; set; }
        public virtual string MobilePhone { get; set; }
        public virtual DateTime? CreationDate { get; set; }
        public virtual string Domain { get; set; }
    }
}
