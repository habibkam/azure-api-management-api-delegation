namespace ContosoWebApplication.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class ApimSubscriptionCreateOrUpdateContract
    {
        [DataMember(Name = "ownerId")]
        public string OwnerId { get; set; }
        [DataMember(Name = "scope")]
        public string Scope { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
    }

    [DataContract]
    public class ApimUserCreateOrUpdateContact
    {
        [DataMember(Name = "firstName")]
        public string FirstName { get; set; }
        [DataMember(Name = "lastName")]
        public string LastName { get; set; }
        [DataMember(Name = "email")]
        public string Email { get; set; }
        [DataMember(Name = "password")]
        public string Password { get; set; }
        [DataMember(Name = "state")]
        public string State { get; set; }
    }

    [DataContract]
    public class ApimSsoUrlResult
    {
        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}