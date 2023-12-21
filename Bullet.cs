
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace OOP
{
    public class Bullet:Entity
    {
        private Vector2 direction;

        private float speed= 8;

        public Bullet(Texture2D texture, Vector2 startPosition):base (texture){
            position=startPosition;
            hitbox.Width=10;
            hitbox.Height=10;
            
            MouseState mouse=Mouse.GetState();
            direction=mouse.Position.ToVector2()-startPosition;
            direction.Normalize();

        }
        public void Update(){
        position += direction*speed;

        }

    }
}