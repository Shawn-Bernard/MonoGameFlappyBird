using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Player: GameEntity
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
   // private Texture2D myPlayerSprite;

    private Vector2 playerPosition = new Vector2(100, 100);

    private Rectangle Collider;

    private bool isJumpPressed;

    float Gravity = 3.0f;

    float maxGravity = 3.0f;

    float GravityFallSpeed = 1.0f;

    float FlappyForce = 10.0f;

    int MaxHealth;

    Game GameManager;

    public Player(Game game, Vector2 StartPosition) : base(game, StartPosition)
    {
        GameManager = game;
        playerPosition = StartPosition;
    }

    public void Update(float deltaTime)
    {
        base.Update(deltaTime);
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

        playerPosition.Y += Gravity;

        if (Gravity < maxGravity)
        {
            Gravity = maxGravity;
        }
    }
    
}
