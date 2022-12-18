using CenebLogistics.Domain.ViewModels.CenebTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenebLogistics.Application.Services.CenebTask
{
    public interface IEmailService
    {
        void SendAMailAsync(MailCredential message, EmailArguement credential);

    }
}
