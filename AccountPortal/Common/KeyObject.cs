using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kiran.Accountportal.Common
{
     [Serializable]
    public class KeyObject
    {
        private int rid;

        public KeyObject()
        {

        }

        public KeyObject(int _rid)
        {
            rid = _rid;
        }

        public int Rid
        {
            get { return rid; }
            set { rid = value; }
        }

    }
     [Serializable]
     public class KeyNameObject : KeyObject
     {
         private String name;

         public String Name
         {
             get { return name; }
             set { name = value; }
         }

         public KeyNameObject(int _rid, String _name)
             : base(_rid)
         {
             name = _name;
         }

         public KeyNameObject()
         {

         }
     }
}
