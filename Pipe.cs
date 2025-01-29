using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Pipe: GameEntity
{
	private Texture2D PipeSprite;
	private Rectangle collider;
	private Vector2 position;
	private float speed;

    
    Game GameManager;

    public Pipe(Game game, Vector2 StartPosition) : base(game, StartPosition)
    {

    }

    public void DrawPipe()
    {
        /*
        Rectangle playerDestination = new Rectangle((int)playerPosition.X, (int)playerPosition.Y, 20, 20);
        Rectangle rectangleA = new Rectangle(1, 1, 5, 5);
        Rectangle.Intersect(playerDestination, rectangleA);

        GameManager.GraphicsDevice.Clear(Color.HotPink);

        _spriteBatch.Begin();



        _spriteBatch.Draw(myPlayerSprite, playerDestination, Color.LightPink);

        _spriteBatch.End();
        */
    }
}
