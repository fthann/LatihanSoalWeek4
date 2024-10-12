// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Program {
    static void Main(string[] args) {

        decimal hargaNike = 1800000;
        decimal hargaNewBalance = 1200000;
        decimal hargaConverse = 1400000;
        decimal hargaBarang = 0;

        Console.WriteLine("======== Welcome to Footlocker Shoes Store ======== ");
        Console.WriteLine("\n");

        Console.WriteLine("Daftar Sepatu Sneakers Favorit 2024: ");
        Console.WriteLine("---------------------");
        Console.WriteLine("1. Sepatu Balance 990v7 - Rp 1.800.000");
        Console.WriteLine("2. Sepatu Asics Gel-Kayano 30 - Rp 1.200.000");
        Console.WriteLine("3. Sepatu Converse Chuck 70s - Rp 1.400.000");
        Console.WriteLine("---------------------");
        Console.WriteLine("Pilih barang yang ingin Anda beli bejir");

        Console.Write("Masukkan pilihan (1-3): ");
        int pilihan = int.Parse(Console.ReadLine());

            if (pilihan == 1) {
                hargaBarang = hargaNike;
            } else if (pilihan == 2) {
                hargaBarang = hargaNewBalance;
            } else if (pilihan == 3) {
                hargaBarang = hargaConverse;
            } else {
                Console.WriteLine("Pilihan tidak valid.");
                return;
            } if (hargaBarang > 1500000) {
                decimal diskon = hargaBarang * 0.20m;
                decimal hargaSetelahDiskon = hargaBarang - diskon;
                Console.WriteLine($"Anda mendapatkan diskon 20%! dari Rp {hargaBarang:N0}, menjadi: Rp {hargaSetelahDiskon:N0}");
            } else {
                Console.WriteLine($"Harga: Rp {hargaBarang:N0}. Anda tidak mendapatkan diskon buset dah.");
            }
    } 
}