using System;
using System.Collections.Generic;
using TugasOOP.Anak;
using TugasOOP.Induk;

namespace TugasOOP
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //deklarasi objek
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.Nik = "19.11.2721";
            karyawanTetap.Nama = "Havid";
            karyawanTetap.GajiBulanan = 14500000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.Nik = "59234923";
            karyawanHarian.Nama = "Pradipta";
            karyawanHarian.JumlahJamKerja = 6;
            karyawanHarian.UpahPerJam = 120000;

            Sales sales = new Sales();
            sales.Nik = "46345345";
            sales.Nama = "Husada";
            sales.JumlahPenjualan = 80;
            sales.Komisi = 1500;
            

            //object class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);
            

            //loop
            int nomor = 1;
            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine(" {0}.NIK: {1}\nNama: {2} \nGaji: {3:N0}\n",
                    nomor, karyawan.Nik, karyawan.Nama, karyawan.Gaji());
                nomor++;
            }
            

           

        }
    }
}