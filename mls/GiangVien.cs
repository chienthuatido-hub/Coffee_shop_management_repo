using System;
using System.Collections.Generic;
using System.Text;

namespace mls
{
    class GiangVien:Nguoi
    {
        private string sKhoaTrucThuoc;
        public GiangVien(string ID, string Name, string Khoa):base(ID,Name)
        {
            sKhoaTrucThuoc = Khoa;
        }

        public override bool isSinhVien()
        {
            return false;
        }

        public override bool isGiangVien()
        {
            return true;
        }
    }
}
