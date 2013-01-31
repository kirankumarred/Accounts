using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiran.Accountportal.Common
{
    public enum SyncTransType { Insert = 0, Update = 1, Delete = 2 };
    public enum Authority { None = 0, Deny = 1, Allow = 2, ReadOnly = 3, Modify = 4, Delete = 5 };

}
