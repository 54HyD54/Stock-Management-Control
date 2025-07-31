using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stok_Yönetim_Kontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] malzemeler = { "Taş", "Tahta", "Demir", "Altın" };
            int[] malzemeMiktar = new int[4];
            char işlem = ' ';
            int tasMiktar = 0;
            int demirMiktar = 0;
            int altınMiktar = 0;
            int tahtaMiktar = 0;

            //Malzeme Ekleme Metotları

            int TasEkle(int tas)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Eklemek İstediğiniz Taş Miktarını Giriniz: ");
                Console.ResetColor();

                tas = int.Parse(Console.ReadLine());
                tas += malzemeMiktar[0];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Başarıyla Eklendi!!");
                Console.ResetColor();

                return tas;
            }
            int TahtaEkle(int tahta)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Eklemek İstediğiniz Tahta Miktarını Giriniz: ");
                Console.ResetColor();

                tahta = int.Parse(Console.ReadLine());
                tahta += malzemeMiktar[1];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Başarıyla Eklendi!!");
                Console.ResetColor();

                return tahta;
            }
            int DemirEkle(int demir)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Eklemek İstediğiniz Demir Miktarını Giriniz: ");
                Console.ResetColor();

                demir = int.Parse(Console.ReadLine());
                demir += malzemeMiktar[2];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Başarıyla Eklendi!!");
                Console.ResetColor();

                return demir;
            }
            int AltınEkle(int altın)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Eklemek İstediğiniz Altın Miktarını Giriniz: ");
                Console.ResetColor();

                altın = int.Parse(Console.ReadLine());
                altın += malzemeMiktar[3];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Başarıyla Eklendi!!");
                Console.ResetColor();

                return altın;
            }

            //Malzeme Kullanma Metotları

            int TasKullan(int tas)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Kullanmak İstediğiniz Taş Miktarını Giriniz: ");
                Console.ResetColor();

                tas = int.Parse(Console.ReadLine());

                if (malzemeMiktar[0] < tas)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Kullanmak İstediğiniz Taş Mıktarı Yetersiz");
                    Console.ResetColor();

                    return tas;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Başarıyla Kullanıldı!!");
                    Console.ResetColor();

                    tas -= malzemeMiktar[0];
                    return tas;
                }
            }
            int TahtaKullan(int tahta)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Kullanmak İstediğiniz Tahta Miktarını Giriniz: ");
                Console.ResetColor();

                tahta = int.Parse(Console.ReadLine());
                
                if (malzemeMiktar[1] < tahta)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Kullanmak İstediğiniz Tahta Mıktarı Yetersiz");
                    Console.ResetColor();

                    return tahta;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Başarıyla Kullanıldı!!");
                    Console.ResetColor();

                    tahta -= malzemeMiktar[1];
                    return tahta;
                }
            }
            int DemirKullan(int  demir)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Kullanmak İstediğiniz Demir Miktarını Giriniz: ");
                Console.ResetColor();

                demir = int.Parse(Console.ReadLine());

                if (malzemeMiktar[2] < demir)
                {
                    Console.ForegroundColor= ConsoleColor.DarkRed;
                    Console.WriteLine("Kullanmak İstediğiniz Demir Mıktarı Yetersiz");
                    Console.ResetColor();

                    return demir;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Başarıyla Kullanıldı!!");
                    Console.ResetColor();

                    demir -= malzemeMiktar[2];
                    return demir;
                }
            }
            int AltınKullan(int altın)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("Kullanmak İstediğiniz Altın Miktarını Giriniz: ");
                Console.ResetColor();

                altın = int.Parse(Console.ReadLine());

                if (malzemeMiktar[3] < altın)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Kullanmak İstediğiniz Altın Mıktarı Yetersiz");
                    Console.ResetColor();

                    return altın;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Başarıyla Kullanıldı!!");
                    Console.ResetColor();

                    altın -= malzemeMiktar[3];
                    return altın;
                }
            }

            //İşlemler

            bool devam = true;

            while (devam)
            {
                İşlemler();

                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Yapmak İstediğiniz İşlemi Seçiniz: ");
                işlem = char.Parse(Console.ReadLine());
                Console.ResetColor();

                Console.WriteLine();

                if(işlem == '1')
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Ürün Stokları: ");
                    Console.ResetColor();

                    Console.WriteLine();

                    for(int i = 0; i < malzemeler.Length; i++)
                    {
                        Console.WriteLine($"Malzeme: {malzemeler[i]}\nMiktar: {malzemeMiktar[i]}");
                        Console.WriteLine();
                    }
                }
                else if(işlem == '2')
                {
                    MalzemeListe();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Eklemek İstediğiniz Malzemenin Sıra Numarasını Yazınız: ");
                    Console.ResetColor();

                    char secim = char.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if(secim == '1')
                    {
                        malzemeMiktar[0] = TasEkle(tasMiktar);
                    }
                    else if(secim == '2')
                    {
                        malzemeMiktar[1] = TahtaEkle(tahtaMiktar);
                    }
                    else if(secim == '3')
                    {
                        malzemeMiktar[2] = DemirEkle(demirMiktar);
                    }
                    else if(secim == '4')
                    {
                        malzemeMiktar[3] = AltınEkle(altınMiktar);
                    }
                    Console.WriteLine("");
                }
                else if(işlem == '3')
                {
                    MalzemeListe();

                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Kullanmak İstediğiniz Malzemenin Sıra Numarasını Yazınız: ");
                    Console.ResetColor();

                    char secim = char.Parse(Console.ReadLine());

                    Console.WriteLine();

                    if (secim == '1')
                    {
                        malzemeMiktar[0] = TasKullan(tasMiktar);
                    }
                    else if (secim == '2')
                    {
                        malzemeMiktar[1] = TahtaKullan(tahtaMiktar);
                    }
                    else if (secim == '3')
                    {
                        malzemeMiktar[2] = DemirKullan(demirMiktar);
                    }
                    else if (secim == '4')
                    {
                        malzemeMiktar[3] = AltınKullan(altınMiktar);
                    }
                    Console.WriteLine();
                }
                else if(işlem == '4')
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Çıkış Yapılıyor...");
                    Console.ResetColor();
                    devam = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Hatalı Seçim Yaptınız!!!");
                    Console.WriteLine();
                }
            }


        }
        static void İşlemler()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--MENÜLER--");
            Console.WriteLine("1)Stok Görüntüle");
            Console.WriteLine("2)Malzeme Ekle");
            Console.WriteLine("3)Malzeme Kullan");
            Console.WriteLine("4)Çıkış");
            Console.ResetColor();
        }
        static void MalzemeListe()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1)Taş");
            Console.WriteLine("2)Tahta");
            Console.WriteLine("3)Demir");
            Console.WriteLine("4)Altın");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
