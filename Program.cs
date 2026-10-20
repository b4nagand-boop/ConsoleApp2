// HashSet<string> halmaz = new() { "A", "B", "C" };
// halmaz.Add("D");
// bool bennevan = halmaz.Contains("DD");
// foreach (string item in halmaz) {
//     Console.WriteLine(item);
// }

Dictionary<int, string> szotar = new();
szotar[55] = "Usain Bolt";
szotar[67] = "Tulkán Jeremiás Fábiusz";
Console.WriteLine(szotar[55]);

foreach (KeyValuePair<int, string> item in szotar) {
    Console.WriteLine($"Kulcs > {item.Key} | Érték > {item.Value}");
}