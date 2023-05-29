namespace ExtraAccurateClock
{
    using System;
    using System.Numerics;
    using static Raylib_CsLo.Raylib;

    class Clock
    {
        private string?[] clock_strings = new string[11];


        private int font_size = 32;

        public Clock()
        {

        }

        public void Update()
        {
            clock_strings[0] = GetMileniumTime().ToString();
            clock_strings[1] = GetCenturyTime().ToString();
            clock_strings[2] = GetDecadeTime().ToString();
            clock_strings[3] = DateTime.Now.Year.ToString();
            clock_strings[4] = DateTime.Now.Month.ToString();
            clock_strings[5] = DateTime.Now.Day.ToString();
            clock_strings[6] = DateTime.Now.Hour.ToString();
            clock_strings[7] = DateTime.Now.Minute.ToString();
            clock_strings[8] = DateTime.Now.Second.ToString();
            clock_strings[9] = DateTime.Now.Millisecond.ToString();
            clock_strings[10] = DateTime.Now.Microsecond.ToString();
        }

        public void Render()
        {
            float position_spacing = GetScreenHeight() / clock_strings.Length;

            for (int i = 0; i < clock_strings.Length; i++)
            {
                DrawText(clock_strings[i], GetScreenWidth() / 2 - font_size / 2, position_spacing * i, font_size, RAYWHITE);
            }
        }

        private int GetMileniumTime()
        {
            return DateTime.Today.Year / 1000 + 1;
        }

        private int GetCenturyTime()
        {
            return DateTime.Today.Year / 100 + 1;
        }

        private int GetDecadeTime()
        {
            return (DateTime.Today.Year - (DateTime.Today.Year / 100) * 100) / 10 + 1;
        }
    }
}