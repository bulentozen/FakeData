using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriGetir
{
    public static class isim
    {
        static Random rnd = new Random();
        public static string Ad()
        {
            string[] Ad = { "Bülent", "Mehmet", "Mustafa", "Ahmet", "Ali", "Hüseyin", "Hasan", "İbrahim", "İsmail", "Osman", "Yusuf", "Murat", "Ömer", "Ramazan", "Halil", "Süleyman", "Abdullah", "Mahmut", "Recep", "Salih", "Fatih", "Kadir", "Emre", "Mehmet Ali", "Hakan", "Adem", "Kemal", "Yasar", "Bekir", "Musa", "Metin", "Bayram", "Serkan", "Orhan", "Burak", "Furkan", "Gökhan", "Yasin", "Uğur", "Yakup", "Muhammet", "Muhammed", "Şükrü", "Cemal", "Enes", "Yunus", "Arif", "Onur", "Yılmaz", "Şaban", "Halil", "İbrahim", "Fatma", "Ayşe", "Emine", "Hatice", "Zeynep", "Elif", "Meryem", "Şerife", "Zehra", "Sultan", "Hanife", "Merve", "Havva", "Zeliha", "Esra", "Fadime", "Özlem", "Hacer", "Yasemin", "Melek", "Rabia", "Hülya", "Cemile", "Sevim", "Gülsüm", "Leyla", "Dilek", "Büşra", "Aysel", "Songül", "Kübra", "Halime", "Esma", "Aynur", "Hayriye", "Kadriye", "Tuba", "Sevgi", "Rukiye", "Hava", "Sibel", "Derya", "Asiye", "Filiz", "Kezban", "Ebru", "Aysegul", "Dondu", "Selma", "Ayten" };
            return Ad[rnd.Next(0, Ad.Length)];
        }
        public static string Soyad()
        {
            string[] Soyadlar = { "ÖZEN", "YILMAZ", "KAYA", "DEMİR", "ÇELİK", "ŞAHİN", "YILDIZ", "YILDIRIM", "ÖZTÜRK", "AYDIN", "ÖZDEMİR", "ARSLAN", "DOĞAN", "KILIÇ", "ASLAN", "ÇETİN", "KARA", "KOÇ", "KURT", "ÖZKAN", "ŞİMŞEK", "POLAT", "ÖZCAN", "KORKMAZ", "ÇAKIR", "ERDOĞAN", "YAVUZ", "CAN", "ACAR", "ŞEN", "AKTAŞ", "GÜLER", "YALÇIN", "GÜNEŞ", "BOZKURT", "BULUT", "KESKİN", "ÜNAL", "TURAN", "GÜL", "ÖZER", "IŞIK", "KAPLAN", "AVCI", "SARI", "TEKİN", "TAŞ", "KÖSE", "YÜKSEL", "ATEŞ", "AKSOY" };
            return Soyadlar[rnd.Next(0, Soyadlar.Length)];
        }

        public static string UrunAdi()
        {
            string[] Soyadlar = {"LENOVO", "Dell","ASUS","ACER","MSI", "TOSHIBA" };
            return Soyadlar[rnd.Next(0, Soyadlar.Length)];
        }
    }
}
