using System;
using System.Globalization;

public class Tarih
{
    public static string TarihTR()
    {
        string gunuVer_TR = 
            CultureInfo.
            GetCultureInfo("tr-TR").
            DateTimeFormat.DayNames
            [
                    (int)DateTime.
                    Now.
                    DayOfWeek
            ];

        string ayiVerTR = 
            CultureInfo.GetCultureInfo("tr-TR").
            DateTimeFormat.
            MonthNames
            [
                (int)DateTime.
                Now.
                Month-1
            ];

        string dateTimeTR = 
            DateTime.Now.ToString("dd ") + 
            ayiVerTR + 
            DateTime.Now.ToString(" yyyy") + 
            " " + 
            gunuVer_TR + 
            "\n" + 
            DateTime.Now.ToString("HH:mm");

        return dateTimeTR;
    }
}
