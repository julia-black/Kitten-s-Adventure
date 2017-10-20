using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{
    class Level4 : LevelAbstract
    {
        int material;
        const int LOCATION_LET_4LEVEL = 350;
    
        public override int GetMaterial()
        {
            return material;
        }
        public override void SetMaterial(int material)
        {
            this.material = material;
        }
        public Level4()
        {
        }
        public override string levelLabel()
        {
            return "Level IV";
        }
        public override bool completteLevel1(PictureBox Cat1, PictureBox Cat2) //прохождения уровня
        {
            if (Cat1.Location.X >= LOCATION_CRYSTAL || Cat2.Location.X >= LOCATION_CRYSTAL)
            {
                return true; //успешно завершился уровень
            }
            return false;
        }
        public override bool ExistLet(PictureBox Cat1, PictureBox Cat2)
        {
            if ((Cat1.Location.X >= LOCATION_LET_4LEVEL || Cat2.Location.X >= LOCATION_LET_4LEVEL))
            {
                return true;
            }
            else
                return false;
        }

    }
}