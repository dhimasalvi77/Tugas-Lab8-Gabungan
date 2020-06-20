using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Your code get here
            Console.WriteLine("Nama\t: DHIMAS ALVI HIDAYAH");
            Console.WriteLine("NIM\t: 19.11.2805");
            Console.WriteLine("Kelas\t: 19 IF 04");

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "2805";
            karyawanTetap.Nama = "DHIMAS";
            karyawanTetap.GajiBulanan = 3000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "3457";
            karyawanHarian.Nama = "DIAN NUR";
            karyawanHarian.UpahPerJam = 10000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "4854";
            sales.Nama = "SYAFITRI";
            sales.JumlahPenjualan = 10;
            sales.Komisi = 50000;

            List<Karyawan> karyawan = new List<Karyawan>();

            karyawan.Add(karyawanTetap);
            karyawan.Add(karyawanHarian);
            karyawan.Add(sales);


            Console.WriteLine("==================================================");
            Console.WriteLine(" NO | NIK / NAMA\t\t\t\t | Gaji\t\t |");
            Console.WriteLine("==================================================");
            for (int i = 0; i < karyawan.Count; i++)
            {

                Console.WriteLine(" {0}. | {1} {2} \t\t| {3} \t |", i + 1, karyawan[i].NIK, karyawan[i].Nama, karyawan[i].Gaji());
            }

            Console.ReadKey();
        }
    }

    public abstract class Karyawan
    {
        public string NIK;
        public string Nama;
        public abstract double Gaji();
    }

    public class KaryawanTetap : Karyawan
    {
        public double GajiBulanan;
        public override double Gaji()
        {
            return this.GajiBulanan;
        }
    }

    public class KaryawanHarian : Karyawan
    {
        public double UpahPerJam;
        public double JumlahJamKerja;
        public override double Gaji()
        {
            return this.UpahPerJam * this.JumlahJamKerja;
        }
    }

    public class Sales : Karyawan
    {
        public double JumlahPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            return this.JumlahPenjualan * this.Komisi;
        }
    }
}