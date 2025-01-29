using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameEntity
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D mySprite;

    private Vector2 Position = new Vector2(100, 100);

    protected Vector2 movementDirection;

    private Rectangle Collider;

    private Game GameManager;
     public GameEntity(Game game,Vector2 StartPosition)
    {
        GameManager = game;
        Position = StartPosition;
    }
    public void Update(float deltaTime)
    {
        Position += movementDirection * deltaTime;
    }
    public void draw ()
    {
        Rectangle entityDestination = new Rectangle((int)Position.X, (int)Position.Y, 20, 20);
        Rectangle rectangleA = new Rectangle(1, 1, 5, 5);
        //Rectangle.Intersect(playerDestination, rectangleA);

        //GameManager.GraphicsDevice.Clear(Color.HotPink);

        _spriteBatch.Begin();

        _spriteBatch.Draw(mySprite, entityDestination, Color.LightPink);

        _spriteBatch.End();
    }
}
