using System;
using System.Collections.Generic;
using System.Text;

namespace SRPAderente
{
    class Logger : ILogger
    {
        public void GravaLog(string info)
        {
            Console.WriteLine(info);
        }
    }
}
