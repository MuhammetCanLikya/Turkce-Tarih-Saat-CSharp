using System;
using System.Globalization;

public class Tarih
{
    public static string TarihTR()
    {
        string gunuVerTR = 
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
            gunuVerTR + 
            "\n" + 
            DateTime.Now.ToString("HH:mm");

        return dateTimeTR;
    }
}
