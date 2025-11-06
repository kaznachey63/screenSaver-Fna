namespace ScreenSaverFna
{
    static class Program
    {
        /// <summary>
        /// Точка входа в пограмму
        /// </summary>
        static void Main()
        {
            using var screenSaver = new General.ScreenSaver();
            screenSaver.Run();
        }
    }
}