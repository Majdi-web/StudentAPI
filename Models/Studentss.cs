using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kubernetes12.Models
{
    public class studentss
    {





        public int MasterStudentId { get; set; }
        public string MasterStudentName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
        public string Occupation { get; set; }

        public string Company { get; set; }

        internal static object Equals(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
