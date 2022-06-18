using System;
using System.Collections.Generic;
using System.Text;

namespace SRPAderente
{
    class EnviarEmail
    {
        public string EMailBody { get; private set; }
        public string EMailFrom { get; private set; }
        public string EMailSubject { get; private set; }
        public string EMailTo { get; private set; }

        public EnviarEmail(string EMailBody, string EMailFrom, string EMailSubject, string EMailTo)
        {
            this.EMailBody = EMailBody;
            this.EMailFrom = EMailFrom;
            this.EMailSubject = EMailSubject;
            this.EMailTo = EMailTo;
        }

        public void Enviar()
        {
            //envia o email
        }

    }
}
