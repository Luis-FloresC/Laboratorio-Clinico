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
            user = "319e92345f67a7";
            password = "0a110133da1ab6";
            host = "sandbox.smtp.mailtrap.io";
            port = 2525;
            ssl = true;
            initializeSmtpClient();
            
        }
    }
}
