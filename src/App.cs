namespace ExtraAccurateClock
{
    using Raylib_CsLo;
    using static Raylib_CsLo.Raylib;

    class App
    {
        private static Clock clock = new Clock();

        private const int WINDOW_WIDTH = 1600;
        private int WINDOW_HEIGHT = 900;
        private const int WINDOW_FRAMERATE = 60;

        private const string WINDOW_TITLE = "Extra Accurate Clock";

        public App()
        {
            InitWindow(WINDOW_WIDTH, WINDOW_HEIGHT, WINDOW_TITLE);
            SetTargetFPS(WINDOW_FRAMERATE);
        }

        public void Run()
        {
            while (!WindowShouldClose())
            {
                OnApplicationUpdate();

                BeginDrawing();

                ClearBackground(BLACK);

                OnApplicationRender();

                EndDrawing();
            }

            OnApplicationExit();
        }

        private void OnApplicationUpdate()
        {
            clock.Update();
        }

        private void OnApplicationRender()
        {
            clock.Render();
        }

        private void OnApplicationExit()
        {
            CloseWindow();
        }
    }
}