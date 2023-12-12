using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_3_Monogame___Animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D tribbleGreyTexture, tribbleCreamTexture, tribbleBrownTexture, tribbleOrangeTexture;
        Rectangle greyTribbleRect, tribbleCreamRect, tribbleBrownRect, tribbleOrangeRect;
        Vector2 tribbleGreySpeed, tribbleCreamSpeed, tribbleBrownSpeed, tribbleOrangeSpeed;
        Color bgColor = Color.White;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            greyTribbleRect = new Rectangle(300, 10, 100, 100);
            tribbleCreamRect = new Rectangle(300, 10, 100, 100);
            tribbleBrownRect = new Rectangle(300, 10, 100, 100);
            tribbleOrangeRect = new Rectangle(300, 10 , 100, 100);
            tribbleGreySpeed = new Vector2(2, 2);
            tribbleCreamSpeed = new Vector2(-4, 1);
            tribbleOrangeSpeed = new Vector2(3, -5);
            tribbleBrownSpeed = new Vector2(-2, 4);
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
            greyTribbleRect.X += (int)tribbleGreySpeed.X;
            greyTribbleRect.Y += (int)tribbleGreySpeed.Y;
            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;
            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;
            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;
            if (greyTribbleRect.Right > _graphics.PreferredBackBufferWidth || greyTribbleRect.Left < 0)
            {
                tribbleGreySpeed.X *= -1;
                bgColor = Color.LightBlue;
            }
            if (greyTribbleRect.Bottom > _graphics.PreferredBackBufferHeight || greyTribbleRect.Top < 0)
            {
                tribbleGreySpeed.Y *= -1;
                bgColor = Color.LightGreen;
            }
            if (tribbleCreamRect.Right > _graphics.PreferredBackBufferWidth || tribbleCreamRect.Left < 0)
            {
                tribbleCreamSpeed.X *= -1;
                bgColor = Color.LightCyan;
            }
            if (tribbleCreamRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleCreamRect.Top < 0)
            {
                tribbleCreamSpeed.Y *= -1;
                bgColor = Color.Goldenrod;
            }
            if (tribbleBrownRect.Right > _graphics.PreferredBackBufferWidth || tribbleBrownRect.Left < 0)
            {
                tribbleBrownSpeed.X *= -1;
                bgColor = Color.YellowGreen;
            }
            if (tribbleBrownRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleBrownRect.Top < 0)
            {
                tribbleBrownSpeed.Y *= -1;
                bgColor = Color.Pink;
            }
            if (tribbleOrangeRect.Right > _graphics.PreferredBackBufferWidth || tribbleOrangeRect.Left < 0)
            {
                tribbleOrangeSpeed.X *= -1;
                bgColor = Color.CornflowerBlue;
            }
            if (tribbleOrangeRect.Bottom > _graphics.PreferredBackBufferHeight || tribbleOrangeRect.Top < 0)
            {
                tribbleOrangeSpeed.Y *= -1;
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(bgColor);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
            _spriteBatch.Begin();
            _spriteBatch.Draw(tribbleGreyTexture, greyTribbleRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);
            _spriteBatch.End();
        }
    }
}