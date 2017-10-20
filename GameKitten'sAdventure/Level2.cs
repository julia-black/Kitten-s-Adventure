using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{
    class Level2 : LevelAbstract
    {
        const int LOCATION_LET_2LEVEL = 440;
        public Level2()
        {
        }
        public override string levelLabel()
        {
            return "Level II";
        }
        public override bool completteLevel1(PictureBox Cat1, PictureBox Cat2) //прохождения уровня 1
        {
            if (Cat1.Location.X >= LOCATION_CRYSTAL || Cat2.Location.X >= LOCATION_CRYSTAL)
            {
                return true; //успешно завершился уровень
            }
            return false;
        }


        public override bool ExistLet(PictureBox Cat1, PictureBox Cat2) //Если обнаружено препятсвие из 2 уровня
        {
            if ((Cat1.Location.X >= LOCATION_LET_2LEVEL || Cat2.Location.X >= LOCATION_LET_2LEVEL))
            {
                return true;
            }
            else
                return false;
        }
        public override int GetMaterial()
        {
            return 1; //камень
        }
        public override void SetMaterial(int material)
        {
            
        }
    }
}
