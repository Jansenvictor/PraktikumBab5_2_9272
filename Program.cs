Console.WriteLine("Masukkan tarif per jam: ");
int TarifPerJam = int.Parse(Console.ReadLine());

Console.WriteLine("Masukkan lama penggunaan: ");
int LamaPenggunaan = int.Parse(Console.ReadLine());

int TotalBiaya = TarifPerJam * LamaPenggunaan;

Console.WriteLine($"Lama penggunaan: {LamaPenggunaan} jam");
Console.WriteLine($"Tarif per jam: {TarifPerJam}");
Console.WriteLine($"Total biaya: {TotalBiaya}");
