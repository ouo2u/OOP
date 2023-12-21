
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOP
{
    public abstract class Enemy:Entity
    {

        protected Player target;

        

          public Enemy(Texture2D texture, Player target): base (texture){
            this.texture=texture;  
            this.target=target;

            position=new Vector2(500,500);
            
        }

        public abstract void update();

          

    }
}