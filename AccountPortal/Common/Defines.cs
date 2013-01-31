using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiran.Accountportal.Common
{
    public enum ErrorCodes
    {
        NO_ERROR = 0,
        SYSTEM_ERROR = 100,
        INVALID_USER_CREDENTIALS = 1000,
        AUTH_FAILED = 1001,
        MESSAGES_FETCH_ERROR = 1002,
        AUTH_LIST_FETCH_ERROR = 1003,
        CHANGE_PASSWORD_FAILED = 1004
    }
}
