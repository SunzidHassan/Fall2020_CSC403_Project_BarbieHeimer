using System.Drawing;

namespace Fall2020_CSC403_Project.code
{
    public class Player : BattleCharacter
    {
        public Image Img { get; set; }
     
        public Player(Vector2 initPos, Collider collider) : base(initPos, collider)
        {

        }
    }
}
