// HashSet<string> halmaz = new() { "A", "B", "C" };
// halmaz.Add("D");
// bool bennevan = halmaz.Contains("DD");
// foreach (string item in halmaz) {
//     Console.WriteLine(item);
// }

// Dictionary<int, string> szotar = new();
// szotar[55] = "Usain Bolt";
// szotar[67] = "Tulkán Jeremiás Fábiusz";
// Console.WriteLine(szotar[55]);

// foreach (KeyValuePair<int, string> item in szotar) {
//     Console.WriteLine($"Kulcs > {item.Key} | Érték > {item.Value}");
// }


Dictionary<int, string> sportolok = new();
int cMezszam;
string cNev;
for (int i = 1; i <= 5; i++) {
    Console.Write($"Add meg a(z) {i}. sportoló mezszámát > ");
    cMezszam = int.Parse(Console.ReadLine());
    Console.Write($"Add meg a(z) {i}. sportoló nevét > ");
    cNev = Console.ReadLine();
    sportolok[cMezszam] = cNev;
    Console.WriteLine();
}

foreach (KeyValuePair<int, string> item in sportolok) {
    Console.WriteLine($"Sportoló mezszáma > {item.Key} | Sportoló neve > {item.Value}");
}