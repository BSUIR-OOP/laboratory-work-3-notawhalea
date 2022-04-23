using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork3
{
    internal abstract class MemberOfUnic
    {
        public abstract string FIO { get; set; }

        public abstract int Age { get; set; }

        public abstract string Work();
    }
}
