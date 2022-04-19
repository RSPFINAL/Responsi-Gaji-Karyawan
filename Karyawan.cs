using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemprograman4371
{
    class Karyawan
    {
        // constructor default
        public Karyawan()
        {}
        // overload constructor 
        public Karyawan(string Nama, string Nik, int GajiBln)
        {
            NAMA = Nama;
            NIK = Nik;
            if (GajiBln < 0)
                {GajiBulanan = 0;}
            else {GajiBulanan = GajiBln;}
        }
        // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }
    }
}
    
