using System;
using System.Collections.Generic;
using System.Text;

namespace mls
{
    abstract class Nguoi
    {
        protected string sID;
        protected string sName;
        public Nguoi(string sID = "", string sName = "")
        {
            this.sID = sID;
            this.sName = sName;
        }

        public abstract bool isSinhVien();
        public abstract bool isGiangVien();

    }
}
