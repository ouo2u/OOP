using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace OOP
{
    public class Wernow : Enemy
    {
     


         
        public Wernow(Texture2D texture, Player target):base(texture,target){
            position=new Vector2(500,500);
            color=Color.Red;
            hitbox=new Rectangle(0,0,25,50);
        }
        public override void update(){
            Vector2 direction=target.Position-position;
            direction.Normalize();

            position += direction;
        }
    }
    
}