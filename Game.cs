using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace FlappyBird
{
    public class FlappyGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private Texture2D myPlayerSprite;

        private Player player;
        private Pipe pipe;
        private GameEntity entity;

        public GraphicsDeviceManager Graphics => _graphics;

        public SpriteBatch Sprite => _spriteBatch;

        public FlappyGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        public bool isCollison(GameEntity Check)
        {
            //Want a return true for game over
            foreach (var enitiy in Check)
            {

            }
        }

        protected override void Initialize()
        {
            Player player = new Player(this,new Vector2 (100,100));
            Pipe pipe = new Pipe(this, new Vector2(50,50));
            // TODO: Add your initialization logic here
            //Player player = new Player;
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
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            KeyboardState keyState = Keyboard.GetState();

            // TODO: Add your update logic here
            //int Height = Window
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            //This is used to resize my player sprite
            //Rectangle playerDestination = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, myPlayerSprite.Width, myPlayerSprite.Height);

            pipe.draw();
            player.draw();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}