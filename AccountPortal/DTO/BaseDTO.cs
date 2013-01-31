using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Kiran.Accountportal.Common;
namespace Kiran.Accountportal.DTO
{
    [Serializable]
    public class BaseDTO
    {
        private SyncTransType transType = SyncTransType.Update;
        private bool isSynchronizataion = false;
        private String lastUpdateUser;
        private String lastUpdateTimestamp;
        ErrorCodes errorCode = ErrorCodes.NO_ERROR;
        Exception ex = null;

        private String currentUserID;
        public BaseDTO(String _currentUserID)
        {
            currentUserID = _currentUserID;
        }
        public SyncTransType TransType { get; set; }

        public bool IsSynchronizataion { get; set; }
        public String LastUpdateUser { get; set; }
        public String LastUpdateTimestamp { get; set; }
        public ErrorCodes ErrorCode { get; set; }
        public Exception SystemException
        {
            get { return ex; }
            set { ex = value; }
        }

        public virtual bool serializeDTO()
        {
            return true;
        }

        public virtual String getKeyInfo()
        {
            return "Base Class";
        }
    }
}
