namespace ExtraAccurateClock
{
    using System.Numerics;
    using Raylib_CsLo;
    using static Raylib_CsLo.Raylib;

    class ClockUnit
    {
        private static Font font_fredoka = LoadFont(@"assets\fonts\Fredoka\Fredoka-VariableFont_wdth,wght.ttf");

        public static int font_size = 64;

        private string? text;

        public void Render(int x, int y)
        {
            DrawTextPro(font_fredoka, text, new Vector2(x, y), Vector2.Zero, 0F, font_size, 2, RAYWHITE);
        }

        public void SetUnitsText(object text)
        {
            this.text = text.ToString();
        }

        public void SetUnitsTextFontSize(int size)
        {
            font_size = size;
        }
    }
}