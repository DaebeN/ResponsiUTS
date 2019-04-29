using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Menu
    {
        public void Display()
        {
        main_menu:
            List<string> menuItems = new List<string>()
            {
                "1.Daftar Menu",
                "2.Bayar",
                "3.Lihat Nota",
                "4.Print Nota",
                "5.Exit"
            };

            Console.Clear();
            Console.CursorVisible = false;
            while (true)
            {

                string selectedMenuItem = DropDownMenu.DrawMenu(menuItems);
                if (selectedMenuItem == "1.Daftar Menu")
                {
                    Console.Clear();
                    Console.WriteLine();

                    String line; try
                    {
                        StreamReader sr = new StreamReader("D:\\Bayu Alif\\project UTS\\3\\Program\\Menu.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        Console.Read();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }

                    Console.WriteLine("                           ");
                    Console.WriteLine("___________________________");
                    Console.WriteLine("tekan |Enter| untuk kembali");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (selectedMenuItem == "2.Bayar")
                {
                    string bayar = Pembayaran.Bayar();
                }
                if (selectedMenuItem == "3.Lihat Nota")
                {
                    Console.Clear();
                    Console.WriteLine();

                    String line; try
                    {
                        StreamReader sr = new StreamReader("D:\\Bayu Alif\\project UTS\\3\\Program\\data.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Console.WriteLine(line);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        Console.ReadKey();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }

                    Console.WriteLine("                           ");
                    Console.WriteLine("___________________________");
                    Console.WriteLine("tekan |Enter| untuk kembali");
                    Console.ReadLine();
                    Console.Clear();
                }
                if (selectedMenuItem == "4.Print Nota")
                {
                    Console.Clear();
                    var process = new ProcessFile();
                    Console.ReadLine();
                    process.ReadFile();
                }
                else if (selectedMenuItem == "5.Exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
