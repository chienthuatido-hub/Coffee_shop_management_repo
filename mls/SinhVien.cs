using System;
using System.Collections.Generic;
using System.Text;

namespace mls
{
    class SinhVien:Nguoi
    {
        private int iToan, iNguVan, iAnhVan;
        public SinhVien(string ID = "", string Name = "", int Toan = 0, int NguVan = 0, int AnhVan = 0):base(ID,Name)
        {
            iToan = Toan;
            iNguVan = NguVan;
            iAnhVan = AnhVan;
        }

        public override bool isSinhVien()
        {
            return true;
        }

        public override bool isGiangVien()
        {
            return false;
        }

        public string ID
        {
            get
            {
                return sID;
            }
            set
            {
                sID = value;
            }
        }


        public string Name
        {
            get
            {
                return sName;
            }
            set
            {
                sName = value;
            }
        }
    }
}
