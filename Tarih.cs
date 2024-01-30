using System;
using System.Globalization;

public class Tarih
{
    public static string TarihTR()
    {
        string _GunuVer_TR = 
            CultureInfo.
            GetCultureInfo("tr-TR").
            DateTimeFormat.DayNames
            [
                    (int)DateTime.
                    Now.
                    DayOfWeek
            ];

        string _AyıVerTR = 
            CultureInfo.GetCultureInfo("tr-TR").
            DateTimeFormat.
            MonthNames
            [
                (int)DateTime.
                Now.
                Month-1
            ];

        string dateTime2 = 
            DateTime.Now.ToString("dd ") + 
            _AyıVerTR + 
            DateTime.Now.ToString(" yyyy") + 
            " " + 
            _GunuVer_TR + 
            "\n" + 
            DateTime.Now.ToString("HH:mm");

        return dateTime2;
    }
}
