using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D myPlayerSprite;

        private Vector2 playerPosition = new Vector2(100, 100);

        private bool isJumpPressed;

        float Gravity = 3.0f;

        float maxGravity = 3.0f;

        float GravityFallSpeed = 1.0f;

        float FlappyForce = 10.0f;


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
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            myPlayerSprite = Content.Load<Texture2D>("Donut");

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            float deltaTime = gameTime.ElapsedGameTime.Milliseconds * GravityFallSpeed;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.Space))
            {
                if (!isJumpPressed)
                {
                    Gravity -= FlappyForce;

                    playerPosition.Y -= FlappyForce;

                    isJumpPressed = true;
                }
            }
            else
            {
                isJumpPressed = false;
            }

            playerPosition.Y += Gravity ;

            if (Gravity < maxGravity)
            {
                Gravity = maxGravity;
            }

            // TODO: Add your update logic here
            //int Height = Window
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //This is used to resize my player sprite
            //Rectangle playerDestination = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, myPlayerSprite.Width, myPlayerSprite.Height);

            Rectangle playerDestination = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, 20, 20);
            GraphicsDevice.Clear(Color.HotPink);

            _spriteBatch.Begin();



            _spriteBatch.Draw(myPlayerSprite, playerDestination, Color.LightPink);

            _spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}