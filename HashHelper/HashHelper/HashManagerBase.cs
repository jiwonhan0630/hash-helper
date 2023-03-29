using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashHelper.Base
{
    internal class HashManagerBase
    {
        public virtual string CreateHash(string fullPath)
        {
            return string.Empty;
        }
    }
}
