using H_M_20;


Del1 ShowAllCurrentValues = new Del1(CurrentValues.ShowRuCurrentValuesToDollar);
ShowAllCurrentValues += CurrentValues.ShowSumCurrentValueToDollar;
ShowAllCurrentValues += CurrentValues.ShowWonCurrentValuesToDollar;
ShowAllCurrentValues += CurrentValues.ShowTengeCurrentValuesToDollar;

ShowAllCurrentValues();

Func<double, double, string> AnyToDoll = ConverterMethods.AnyValuesToUs;
Func<double, double, string> DollToAny = ConverterMethods.UsToAnyValues;
do
{
    Console.WriteLine("Aqsh dollarini sotib olish xizmatidan foydalanish uchun ( 1 ) ni bosing");
    Console.WriteLine("Aqsh  dollarini  sotish  xizmatidan  foydalanish  uchun ( 2 ) ni bosing");
    Console.WriteLine("                                 Yakunlash uchun  uchun ( 0 ) ni bosing");
    var userChoose = Console.ReadLine();
    if (userChoose != null && userChoose == "1")
    {
        Console.WriteLine("Qaysi Valutada xaridni amalga oshirmog`chisiz?");
        Console.WriteLine("'Rub' (Rossiya)  'Uzs' (Uzbekistan)  'Won' (Koreya)  'Ten' (Kozog`iston) ");
        userChoose = Console.ReadLine();
        try
        {
            userChoose = userChoose.ToLower();
            double currentValue = userChoose == "rub" ? CurrentValues.Rub : userChoose == "ten" ? CurrentValues.Ten : userChoose == "won" ? CurrentValues.Won : CurrentValues.Sum;
            Console.WriteLine($"Siz {userChoose} valutasini tanladingiz!\nXarid qilish uchun summani kiriting!");
            double userValueEnter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(AnyToDoll(userValueEnter, currentValue) + "$");
            Console.WriteLine("Bizning xizmatimizdan foydalanganingiz uchun raxmat!!\nDavom ettirish uchun ( 1 ) ni bosing");
            userChoose = Console.ReadLine();
            if (userChoose != null && userChoose == "1")
            {
                continue;
            }
            else
                break;
        }
        catch
        {
            Console.WriteLine("Tizimda hatolik administratsiyaga uchrang!");
        }
    }
    else if (userChoose != null && userChoose == "2")
    {
        Console.WriteLine("Qaysi Valutani xarid qilmog`chisiz?");
        Console.WriteLine("'Rub' (Rossiya)  'Uzs' (Uzbekistan)  'Won' (Koreya)  'Ten' (Kozog`iston) ");
        userChoose = Console.ReadLine();
        try
        {
            userChoose = userChoose.ToLower();
            double currentValue = userChoose == "rub" ? CurrentValues.Rub : userChoose == "ten" ? CurrentValues.Ten : userChoose == "won" ? CurrentValues.Won : CurrentValues.Sum;
            Console.WriteLine($"Siz {userChoose} valutasini tanladingiz!\nXarid qilish uchun summani kiriting!");
            double userValueEnter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(DollToAny(userValueEnter, currentValue) + userChoose);
            Console.WriteLine("Bizning xizmatimizdan foydalanganingiz uchun raxmat!!\nDavom ettirish uchun ( 1 ) ni bosing");
            userChoose = Console.ReadLine();
            if (userChoose != null && userChoose == "1")
            {
                continue;
            }
            else
                break;
            
        }
        catch
        {
            Console.WriteLine("Tizimda hatolik administratsiyaga uchrang!");
        }
    }
    if(userChoose=="0")
        break;
}
while (true);