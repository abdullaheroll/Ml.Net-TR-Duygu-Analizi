using MyMLApp;
using static System.Net.Mime.MediaTypeNames;
Console.Title = "Ml.Net Duygu Analizi";
// Başlığı ortalamak için konsol genişliğini hesapla
int consoleWidth = Console.WindowWidth;
Console.Write("\n");
string title = "ML.NET(Makine Öğrenimi) TR DUYGU ANALİZİ";
string etic = "(Daha çok e-ticaret için uygundur.)";
string github = "GitHub: @abdullaheroll";
int padding = (consoleWidth - title.Length) / 2;
int padding2 = (consoleWidth - github.Length) / 2;
int padding3 = (consoleWidth - etic.Length) / 2;


// Başlığı ekrana yazdır
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"{new string(' ', padding)}{title}");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"{new string(' ', padding3)}{etic}");
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"{new string(' ', padding2)}{github}");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine(new string('-', consoleWidth));
bool clearScreen = false;

while (true)
{
    if (clearScreen)
    {
        Console.Clear();
        clearScreen = false;
    }

    // Kullanıcıdan cümle girdisini al
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("\n");
    Console.Write("Cümle Girin (Çıkmak için 'exit' yazın, ekranı temizlemek için 'clear' yazın): ");
    var input = Console.ReadLine();
    Console.WriteLine("**************************************");


    if (input.ToLower() == "exit")
    {
        // 'exit' yazıldığında döngüyü sonlandır
        break;
    }

    if (input.ToLower() == "clear")
    {
        // 'clear' yazıldığında ekranı temizle
        clearScreen = true;
        continue;
    }

    // Model girdisi için örnek veri oluştur
    var sampleData = new Mlmodelim.ModelInput()
    {
        Görüş = input,
    };

    // Modeli kullanarak sonucu tahmin et
    var result = Mlmodelim.Predict(sampleData);

    // Tahmin edilen etiketi belirle
    var predictedLabel = result.PredictedLabel == "Olumlu" ? "Olumlu" : "Olumsuz";

    // Sonucun doğruluk skorunu yüzdelik olarak hesapla
    var PositiveScore = result.Score[1] * 100;
    var NegativeScore = result.Score[0] * 100;

    // Doğruluk skorunu formatlayarak yüzdelik olarak tut
    var formattedPositiveScore = $"{PositiveScore:00.00}%";
    var formattedNegativeScore = $"{NegativeScore:00.00}%";

    // Sonuçları ekrana yazdır
    Console.Write("\n");
    Console.ForegroundColor = ConsoleColor.Blue;
    if (predictedLabel == "Olumlu")
    {
        Console.WriteLine($"Durum: {predictedLabel}\nSkor: {formattedPositiveScore}\n");

    }
    else
    {
        Console.WriteLine($"Durum: {predictedLabel}\nSkor: {formattedNegativeScore}\n");
    }

  
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("**************************************");
}

Console.WriteLine("Program sonlandırıldı.");
