using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAbstractFactory.Lib
{
    public abstract class SchoolAbstractFactory
    {
        public abstract IEducation CreateEducation();
    }
}
