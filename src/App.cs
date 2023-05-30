namespace ExtraAccurateClock
{
    using Raylib_CsLo;
    using static Raylib_CsLo.Raylib;

    class App
    {
        private static Clock clock = new Clock();

        private const int WINDOW_WIDTH = 1024;
        private const int WINDOW_HEIGHT = 768;
        private const int WINDOW_FRAMERATE = 60;

        private const string WINDOW_TITLE = "Extra Accurate Clock!";

        private bool debugEnabled = false;

        public App()
        {
            InitWindow(WINDOW_WIDTH, WINDOW_HEIGHT, WINDOW_TITLE);
            SetTargetFPS(WINDOW_FRAMERATE);
            SetWindowIcon(LoadImage(@"assets\graphics\icons\clock.png"));
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
            EnableDebug();

            if (debugEnabled)
                SetWindowTitle(WINDOW_TITLE + " (FPS: " + GetFPS() + ")");

            else
                SetWindowTitle(WINDOW_TITLE);
        }

        private void OnApplicationRender()
        {
            clock.Render();
        }

        private void OnApplicationExit()
        {
            CloseWindow();
        }

        private void EnableDebug()
        {
            if (IsKeyPressed(KeyboardKey.KEY_F3))
            {
                if (debugEnabled)
                    debugEnabled = false;

                else if (!debugEnabled)
                    debugEnabled = true;
            }
        }
    }
}