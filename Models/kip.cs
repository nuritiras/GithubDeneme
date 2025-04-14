using System;

namespace GithubDeneme.Models
{
    public class Kitap
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public DateTime YayimTarihi { get; set; }
        public string Tur { get; set; }
        public decimal Fiyat { get; set; }
    }
}