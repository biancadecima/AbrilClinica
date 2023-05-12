using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.Models
{
    public abstract class Parser
    {
        public abstract string ObjectToString();
        
        public abstract Parser Parse(string line);
        //public List<Parser> CreateList(List<string> lines)
        //{
        //    List<Parser> list = new List<Parser>();
        //    foreach (string row in lines)
        //    {
        //        list.Add(Parse(row));
        //    }

        //    return list;

        //}
    }
}
