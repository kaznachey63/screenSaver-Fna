using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ScreenSaverFna.Additions;

namespace ScreenSaverFna.General
{
    /// <summary>
    /// Основной класс программы
    /// </summary>
    public class ScreenSaver : Game
    {
        private readonly GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch = null!;
        private Core core = null!;

        public ScreenSaver()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = Constants.WindowWidth;
            graphics.PreferredBackBufferHeight = Constants.WindowHeight;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
        }

        /// <summary>
        /// Автоматически вызывается при запуске игры для загрузки любых игровых ресурсов (графики, звука и т. д.).
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            core = new(graphics, Content);
        }

        /// <summary>
        /// Вызывается каждый кадр для обновления игры. Игры обычно работают со скоростью 60 кадров в секунду.
        /// Каждый кадр функция Update будет выполнять логику, например, обновление мира,
        /// проверку столкновений, сбор ввода и воспроизведение звука.
        /// </summary>
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            core.OffsetSnowflake();
        }

        /// <summary>
        /// Вызывается, когда игра готова к отрисовке на экране, также вызывается каждый кадр.
        /// </summary>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            core.ShowBg(spriteBatch);
            core.ShowSnoflakes(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}