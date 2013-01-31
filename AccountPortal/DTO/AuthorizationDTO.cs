using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kiran.Accountportal.Common;
using System.Data;
namespace Kiran.Accountportal.DTO
{
    public class AuthorizationDTO:BaseDTO
    {
        
        private KeyObject reportsToUserKey;

        public AuthorizationDTO(String _currentUserID)
            : base(_currentUserID)
        {
            reportsToUserKey = new KeyObject();
        }
        public int UserRid { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String SurName { get; set; }
        public String LastLoginDate { get; set; }
        public KeyObject ReportsToUserKey { get; set; }
        public DataSet UsersList { get; set; }
        private Authority getAuthFromInt(String value)
        {
            switch (value)
            {
                case "0": return Authority.None;
                case "1": return Authority.Deny;
                case "2": return Authority.Allow;
                case "3": return Authority.ReadOnly;
                case "4": return Authority.Modify;
                case "5": return Authority.Delete;
            }
            return Authority.None;
        }
    }
}
