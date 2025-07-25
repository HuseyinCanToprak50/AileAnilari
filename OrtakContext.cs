using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AileAnilari
{
    public class OrtakContext
    {
        private static AileAnilariDbContext _context; // Veritabanı bağlamını tutan statik değişken

        public static AileAnilariDbContext Baglanti
        {
            get
            {
                // Eğer bağlam nesnesi henüz oluşturulmamışsa
                if (_context == null)
                {
                    // Yeni bir AileAnilariDbContext nesnesi oluşturur
                    _context = new AileAnilariDbContext();
                }
                // Mevcut veya yeni oluşturulan bağlam nesnesini döndürür
                return _context;
            }
        }
    }
}
