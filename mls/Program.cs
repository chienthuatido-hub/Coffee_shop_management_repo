using System;
using System.Collections.Generic;

namespace mls
{
    class Program
    {
        public static void Find(string sID, string sName)
        {

        }

        public static void AddGV(string ID, string Name, string Khoa)
        {

        }

        public static void AddSV(string ID, string Name, string Toan, string Van, string AnhVan)
        {

        }

        public static void Top(int x)
        {

        }

        public static void Export(string path)
        {

        }
        static void Main(string[] args)
        {
            int iLength = args.Length;
            if (iLength == 3 && args[0] == "find")
                Find(args[1], args[2]);
            else if (args[0] == "add")
                if (args[1] == "1")
                    AddGV(args[2], args[3], args[4]);
                else
                {
                    if (args[1] == "2")
                        AddSV(args[2], args[3], args[4], args[5], args[6]);
                }
            else if (iLength == 2 && (int.Parse(args[1]) > 0))
                Top(int.Parse(args[1]));
            else if (iLength == 2 && args[0] == "export")
                Export(args[1]);
        }
    }
}
