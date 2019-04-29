using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Pembayaran
    {
        public static string Bayar()
        {
            Menu menu = new Menu();
            List<string> daftar = new List<string>()
                {
                  "1.Makanan",
                  "2.Minuman",
                  "3.Kembali"
                };
                Console.Clear();
                Console.CursorVisible = false;
                while (true)
                {
                    string selecteddaftar = DropDownMenu.DrawMenu(daftar);
                    if (selecteddaftar == "1.Makanan")
                    {
                    transaksi:
                        Console.WriteLine();
                        Console.WriteLine("  Menu Pilihan  ");
                        Console.WriteLine(" 1.Magelangan");
                        Console.WriteLine(" 2.Nasi orak-arik");

                        // Deklarasi Variabel
                        string pilihan, ulang;
                        byte quantity = 0;
                        uint magelangan = 10000, nasiorakarik = 9000;
                        uint totalHarga, tunai, kembalian = 0;

                        Console.WriteLine();

                        Console.Write("Masukkan Angka Pilihan : ");
                        pilihan = Convert.ToString(Console.ReadLine());

                        // 1. input magelangan
                        if (pilihan == "1")
                        {
                            // 1. input quantity
                            Console.WriteLine();
                            Console.Write(" Masukkan jumlah beli : ");
                            quantity = Convert.ToByte(Console.ReadLine());

                            // 2. Proses total harga
                            totalHarga = magelangan * quantity;

                            // 3. Output total harga

                            Console.WriteLine();
                            Console.WriteLine(" #=================#==============# ");
                            Console.WriteLine("    Total Harga    : Rp {0}", totalHarga.ToString());

                            // 4. Input tunai
                            Console.Write("          Tunai    : Rp ");
                            tunai = Convert.ToUInt32(Console.ReadLine());

                            // 5. Proses kembalian
                            kembalian = tunai - totalHarga;

                            // 6. Output kembalian
                            if (tunai > totalHarga)
                            {
                                Console.WriteLine("      Kembalian    : Rp {0}", kembalian.ToString());
                                Console.WriteLine(" #=================#==============# ");
                                var process = new ProcessFile();
                                process.WriteFile();
                                Console.ReadLine();
                                Console.Clear();
                                menu.Display();
                            }
                            else if (tunai < totalHarga)
                            {
                                Console.WriteLine();
                                Console.WriteLine("|Nominal yang dimasukan salah!|");
                                Console.WriteLine();
                                Console.Write(" Apakah anda ingin mengulang transaksi ? [y/t] : ");
                                ulang = Convert.ToString(Console.ReadLine());
                                if (ulang == "y" || ulang == "Y")
                                    goto transaksi;
                                else if (ulang == "t" || ulang == "T")
                                {
                                    menu.Display();
                                }
                            }
                        }

                        // 2. input nasi orak-arik
                        if (pilihan == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" 2.Nasi orak-arik ");
                            Console.WriteLine("  ________________ ");

                            // 1. input quantity
                            Console.WriteLine();
                            Console.Write(" Masukkan jumlah beli : ");
                            quantity = Convert.ToByte(Console.ReadLine());

                            // 2. Proses total harga
                            totalHarga = nasiorakarik * quantity;

                            // 3. Output total harga

                            Console.WriteLine();
                            Console.WriteLine(" #=================#==============# ");
                            Console.WriteLine("    Total Harga    : Rp {0}", totalHarga.ToString());

                            // 4. Input tunai
                            Console.Write("          Tunai    : Rp ");
                            tunai = Convert.ToUInt32(Console.ReadLine());

                            // 5. Proses kembalian
                            kembalian = tunai - totalHarga;

                            // 6. Output kembalian
                            if (tunai > totalHarga)
                            {
                                Console.WriteLine("      Kembalian    : Rp {0}", kembalian.ToString());
                                Console.WriteLine(" #=================#==============# ");
                                var process = new ProcessFile();
                                process.WriteFile();
                                Console.ReadLine();
                                Console.Clear();
                                menu.Display();
                            }
                            if (tunai < totalHarga)
                            {
                                Console.WriteLine();
                                Console.WriteLine("|Nominal yang dimasukan salah!|");
                                Console.WriteLine();
                                Console.Write(" Apakah anda ingin mengulang transaksi ? [y/t] : ");
                                ulang = Convert.ToString(Console.ReadLine());
                                if (ulang == "y" || ulang == "Y")
                                    goto transaksi;
                                else if (ulang == "t" || ulang == "T")
                                {
                                menu.Display();
                            }
                            }
                        }
                        
                        // Penutup
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ========================================================");
                        Console.WriteLine();
                        Console.WriteLine("         Terimakasi Telah Melakukan Transaksi !!! ");
                        Console.WriteLine();
                        Console.WriteLine(" ========================================================");

                        Console.WriteLine();

                        Console.Write("Press any key to continue . . . ");
                        Console.ReadKey(true);
                    Console.Clear();
                    }

                    if (selecteddaftar == "2.Minuman")
                    {
                    transaksi:
                        Console.WriteLine();
                        Console.WriteLine("  Menu Pilihan  ");
                        Console.WriteLine(" 1.Good Day Vanilla");
                        Console.WriteLine(" 2.Good Day Freeze");
                        Console.WriteLine(" 3.Susu Coklat");

                        // Deklarasi Variabel
                        string pilihan, ulang;
                        byte quantity = 0;
                        uint gooddayvanilla = 3000, gooddayfreeze = 3500, susucoklat = 3000;
                        uint totalHarga, tunai, kembalian = 0;

                        Console.WriteLine();

                        Console.Write("Masukkan Angka Pilihan : ");
                        pilihan = Convert.ToString(Console.ReadLine());

                        // 1. input good day vanilla
                        if (pilihan == "1")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" 1.Good Day Vanilla ");
                            Console.WriteLine("  __________________ ");

                            // 1. input quantity
                            Console.WriteLine();
                            Console.Write(" Masukkan jumlah beli : ");
                            quantity = Convert.ToByte(Console.ReadLine());

                            // 2. Proses total harga
                            totalHarga = gooddayvanilla * quantity;

                            // 3. Output total harga

                            Console.WriteLine();
                            Console.WriteLine(" #=================#==============# ");
                            Console.WriteLine("    Total Harga    : Rp {0}", totalHarga.ToString());

                            // 4. Input tunai
                            Console.Write("          Tunai    : Rp ");
                            tunai = Convert.ToUInt32(Console.ReadLine());

                            // 5. Proses kembalian
                            kembalian = tunai - totalHarga;

                            // 6. Output kembalian
                            if (tunai > totalHarga)
                            {
                                Console.WriteLine("      Kembalian    : Rp {0}", kembalian.ToString());
                                Console.WriteLine(" #=================#==============# ");
                                var process = new ProcessFile();
                                process.WriteFile();
                                Console.ReadLine();
                                Console.Clear();
                                menu.Display();
                            }
                            if (tunai < totalHarga)
                            {
                                Console.WriteLine();
                                Console.WriteLine("|Nominal yang dimasukan salah!|");
                                Console.WriteLine();
                                Console.Write(" Apakah anda ingin mengulang transaksi ? [y/t] : ");
                                ulang = Convert.ToString(Console.ReadLine());
                                if (ulang == "y" || ulang == "Y")
                                    goto transaksi;
                                else if (ulang == "t" || ulang == "T")
                                {
                                menu.Display();
                            }
                            }
                        }
                        // 2. input good day freeze
                        if (pilihan == "2")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" 1.Good Day Freeze ");
                            Console.WriteLine("  _________________ ");

                            // 1. input quantity
                            Console.WriteLine();
                            Console.Write(" Masukkan jumlah beli : ");
                            quantity = Convert.ToByte(Console.ReadLine());

                            // 2. Proses total harga
                            totalHarga = gooddayfreeze * quantity;

                            // 3. Output total harga

                            Console.WriteLine();
                            Console.WriteLine(" #=================#==============# ");
                            Console.WriteLine("    Total Harga    : Rp {0}", totalHarga.ToString());

                            // 4. Input tunai
                            Console.Write("          Tunai    : Rp ");
                            tunai = Convert.ToUInt32(Console.ReadLine());

                            // 5. Proses kembalian
                            kembalian = tunai - totalHarga;

                            // 6. Output kembalian
                            if (tunai > totalHarga)
                            {
                                Console.WriteLine("      Kembalian    : Rp {0}", kembalian.ToString());
                                Console.WriteLine(" #=================#==============# ");
                                var process = new ProcessFile();
                                process.WriteFile();
                                Console.ReadLine();
                                Console.Clear();
                                menu.Display();
                            }
                            if (tunai < totalHarga)
                            {
                                Console.WriteLine();
                                Console.WriteLine("|Nominal yang dimasukan salah!|");
                                Console.WriteLine();
                                Console.Write(" Apakah anda ingin mengulang transaksi ? [y/t] : ");
                                ulang = Convert.ToString(Console.ReadLine());
                                if (ulang == "y" || ulang == "Y")
                                    goto transaksi;
                                else if (ulang == "t" || ulang == "T")
                                {
                                menu.Display();
                            }
                            }
                        }
                        // 3. input susu coklat
                        if (pilihan == "3")
                        {
                            Console.WriteLine();
                            Console.WriteLine(" 3.Susu Coklat ");
                            Console.WriteLine("  ______________ ");

                            // 1. input quantity
                            Console.WriteLine();
                            Console.Write(" Masukkan jumlah beli : ");
                            quantity = Convert.ToByte(Console.ReadLine());

                            // 2. Proses total harga
                            totalHarga = susucoklat * quantity;

                            // 3. Output total harga

                            Console.WriteLine();
                            Console.WriteLine(" #=================#==============# ");
                            Console.WriteLine("    Total Harga    : Rp {0}", totalHarga.ToString());

                            // 4. Input tunai
                            Console.Write("          Tunai    : Rp ");
                            tunai = Convert.ToUInt32(Console.ReadLine());

                            // 5. Proses kembalian
                            kembalian = tunai - totalHarga;

                            // 6. Output kembalian
                            if (tunai > totalHarga)
                            {
                                Console.WriteLine("      Kembalian    : Rp {0}", kembalian.ToString());
                                Console.WriteLine(" #=================#==============# ");
                                var process = new ProcessFile();
                                process.WriteFile();
                                Console.ReadLine();
                                Console.Clear();
                                menu.Display();
                            }
                            if (tunai < totalHarga)
                            {
                                Console.WriteLine();
                                Console.WriteLine("|Nominal yang dimasukan salah!|");
                                Console.WriteLine();
                                Console.Write(" Apakah anda ingin mengulang transaksi ? [y/t] : ");
                                ulang = Convert.ToString(Console.ReadLine());
                                if (ulang == "y" || ulang == "Y")
                                    goto transaksi;
                                else if (ulang == "t" || ulang == "T")
                                {
                                menu.Display();
                            }
                            }
                        }

                    }
                    if (selecteddaftar == "3.Kembali")
                    {
                    menu.Display();
                }
                }
        }
    }
}
