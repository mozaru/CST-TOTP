using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST___CarteiraSenhasTemporais
{
    public class AccessCode
    {
        public string Name { get; set; } = "";
        public string Key{ get; set; } = "";
        public bool Steam { get; set; } = false;
        public long T0 { get; set; } = 0;
        public long Interval { get; set; } = 30;
        public int Digits { get; set; } = 6;
        public string Note { get; set; } = "";
       
    }
}
