using FluentEmail.Core;

namespace Progetto_BE_S6.Services
{
    public class EmailServices
    {
        private readonly IFluentEmail _fluentEmail;
        public EmailServices(IFluentEmail fluentEmail)
        {
            _fluentEmail = fluentEmail;
        }



    }
}
