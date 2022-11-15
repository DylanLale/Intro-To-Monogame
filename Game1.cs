using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Intro_To_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D CapAmericaTexture;
        Texture2D IronManTexture;
        Texture2D HulkTexture;
        Texture2D SpiderManTexture;
        Texture2D AirportTexture;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "Marvel Pic";
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            CapAmericaTexture = Content.Load<Texture2D>("Captain America");
            IronManTexture = Content.Load<Texture2D>("Iron Man");
            HulkTexture = Content.Load<Texture2D>("Hulk");
            SpiderManTexture = Content.Load<Texture2D>("spiderman");
            AirportTexture = Content.Load<Texture2D>("Airport");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(AirportTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(IronManTexture,new Vector2(550, 50),Color.White);
            _spriteBatch.Draw(CapAmericaTexture, new Vector2(100, 330), Color.White);
            _spriteBatch.Draw(HulkTexture, new Vector2(200, 50), Color.White);
            _spriteBatch.Draw(SpiderManTexture, new Vector2(550, 200), Color.White);
            

            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}