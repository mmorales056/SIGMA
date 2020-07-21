using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sigma_api.Model
{
    public class Contacts
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string state { get; set; }
        public string city { get; set; }
    }
}
