using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{

    
    class Level1 : LevelAbstract
    {  
        public Level1()
        {
        }
        public override string levelLabel()
        {
            return "Level I";
        }
        public override bool completteLevel1(PictureBox Cat1, PictureBox Cat2) //прохождения уровня 1
        {
            if (Cat1.Location.X >= LOCATION_CRYSTAL || Cat2.Location.X >= LOCATION_CRYSTAL)
            {
                return true; //успешно завершился уровень
            }
            return false;
        }
        public override bool ExistLet(PictureBox Cat1, PictureBox Cat2)
        {
            return false;
        }
        public override void SetMaterial(int material)
        {
            
        }
        public override int GetMaterial()
        {
            return 0;
        }
    }
}
