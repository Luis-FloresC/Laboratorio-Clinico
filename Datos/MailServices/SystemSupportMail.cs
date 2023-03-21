using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.MailServices
{
    class SystemSupportMail: MasterMailService
    {
        public SystemSupportMail()
        {
            
            senderMail = "LaboratorioClinicoSupport@gmail.com";
            user = "d8475b7531e4b8";
            password = "5b42c657fe47ce";
            host = "sandbox.smtp.mailtrap.io";
            port = 2525;
            ssl = true;
            initializeSmtpClient();
            
        }
    }
}
