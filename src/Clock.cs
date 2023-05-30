namespace ExtraAccurateClock
{
    using System;
    using Raylib_CsLo;
    using static Raylib_CsLo.Raylib;

    class Clock
    {
        public ClockUnit[] units = new ClockUnit[12];

        public Clock()
        {
            for (int i = 0; i < units.Length; i++)
            {
                units[i] = new ClockUnit();
                units[i].SetTextureFiltering(TextureFilter.TEXTURE_FILTER_TRILINEAR);
            }
        }

        public void Update()
        {
            units[0].SetUnitsText("Milenium: " + GetMileniumTime());
            units[1].SetUnitsText("Century: " + GetCenturyTime());
            units[2].SetUnitsText("Decade: " + GetDecadeTime());
            units[3].SetUnitsText("Year: " + GetYearTime());
            units[4].SetUnitsText("Month: " + GetMonthTime());
            units[5].SetUnitsText("Day: " + GetDayTime());
            units[6].SetUnitsText("Hour: " + GetHourTime());
            units[7].SetUnitsText("Minute: " + GetMinuteTime());
            units[8].SetUnitsText("Second: " + GetSecondTime());
            units[9].SetUnitsText("Milisecond: " + GetMilisecondTime());
            units[10].SetUnitsText("Microsecond: " + GetMicrosecondTime());
            units[11].SetUnitsText(GetMileniumTime() + "/" + GetCenturyTime() + "/" + GetDecadeTime() + " " + GetYearTime() + ":" + GetMonthTime() + ":" + GetDayTime() + " " + GetHourTime() + ":" + GetMinuteTime() + "." + GetSecondTime() + "(" + GetMilisecondTime() + " / " + GetMicrosecondTime() + ")");
        }

        public void Render()
        {
            for (int i = 0; i < units.Length; i++)
            {
                int x = (GetScreenWidth() - units[i].GetTextWidth()) / 2;
                int y = ClockUnit.font_size * i;

                units[i].Render(x, y);
            }
        }

        private int GetMileniumTime()
        {
            return DateTime.Now.Year / 1000 + 1;
        }

        private int GetCenturyTime()
        {
            return DateTime.Now.Year / 100 + 1;
        }

        private int GetDecadeTime()
        {
            return (DateTime.Now.Year - (DateTime.Today.Year / 100) * 100) / 10 + 1;
        }

        private int GetYearTime()
        {
            return DateTime.Now.Year;
        }

        private int GetMonthTime()
        {
            return DateTime.Now.Month;
        }

        private int GetDayTime()
        {
            return DateTime.Now.Day;
        }

        private int GetHourTime()
        {
            return DateTime.Now.Hour;
        }

        private int GetMinuteTime()
        {
            return DateTime.Now.Minute;
        }

        private int GetSecondTime()
        {
            return DateTime.Now.Second;
        }

        private int GetMilisecondTime()
        {
            return DateTime.Now.Millisecond;
        }

        private int GetMicrosecondTime()
        {
            return DateTime.Now.Microsecond;
        }
    }
}