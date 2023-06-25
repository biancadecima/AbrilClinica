using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Utilities
{
    public abstract class Parser
    {
        /// <summary>
        /// convert object to string
        /// </summary>
        /// <returns></returns>
        public abstract string ObjectToString();
    }
}
