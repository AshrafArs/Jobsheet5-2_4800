Console.WriteLine("Masukkan Nama Pelanggan: ");
string namaPelanggan = Console.ReadLine();

Console.WriteLine("Masukkan Nama Dokumen: ");
string namaDokumen = Console.ReadLine();

Console.WriteLine("Masukkan Jumlah Halaman: ");
int jumlahHalaman = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan Harga Per Halaman: ");
int hargaPerHalaman = int.Parse(Console.ReadLine());

const int biayaAdministrasi = 2000;

int subtotal = jumlahHalaman * hargaPerHalaman;
int totalBayar = subtotal + biayaAdministrasi;

Console.WriteLine();
Console.WriteLine("=== RINCIAN PENCETAKAN ===");
Console.WriteLine($"Nama Pelanggan: {namaPelanggan}");
Console.WriteLine($"Nama Dokumen:{namaDokumen}");
Console.WriteLine($"Jumlah Halaman: {jumlahHalaman}");
Console.WriteLine($"Harga Per Halaman: {hargaPerHalaman}");
Console.WriteLine($"Subtotal: {subtotal}");
Console.WriteLine($"Biaya Administrasi: {biayaAdministrasi}");
Console.WriteLine($"Total Bayar: {totalBayar}");