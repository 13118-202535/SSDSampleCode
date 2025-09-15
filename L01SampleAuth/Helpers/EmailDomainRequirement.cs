using Microsoft.AspNetCore.Authorization;

namespace L01SampleAuth.Helpers
{
    public class EmailDomainRequirement : IAuthorizationRequirement
    {
        public string EmailDomain { get; }

        public EmailDomainRequirement(string emailDomain)
        {
            EmailDomain = emailDomain;
        }
    }
}