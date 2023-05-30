namespace ExtraAccurateClock
{
    using System.Numerics;
    using Raylib_CsLo;
    using static Raylib_CsLo.Raylib;

    class ClockUnit
    {
        private static Font font_fredoka = LoadFont(@"assets\fonts\Fredoka\Fredoka-VariableFont_wdth,wght.ttf");

        public static int font_size = 64;

        private string text = "";

        public void Render(int x, int y)
        {
            DrawTextPro(font_fredoka, text, new Vector2(x, y), Vector2.Zero, 0F, font_size, 2, RAYWHITE);
        }

        public void SetTextureFiltering(TextureFilter filter)
        {
            SetTextureFilter(font_fredoka.texture, filter);
        }

        public void SetUnitsText(object target)
        {
            this.text = target.ToString();
        }

        public void SetUnitsTextFontSize(int size)
        {
            font_size = size;
        }

        public int GetTextWidth()
        {
            return (int)MeasureTextEx(font_fredoka, text, font_size, 2).X;
        }

        public int GetTextHeight()
        {
            return (int)MeasureTextEx(font_fredoka, text, font_size, 2).Y;
        }
    }
}