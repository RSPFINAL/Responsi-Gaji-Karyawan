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
        {
        
        }
        // overload constructor 
        public Karyawan(string Nama, string Nik, int GajiBulanan)
        {
            NAMA = Nama;
            NIK = Nik;
            GajiBulanan = GajiBulanan;
        }
        // properties
        public string NAMA { get; set; }
        public string NIK { get; set; }
        public int GajiBulanan { get; set; }


    }
}
    
