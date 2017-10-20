using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{
    class Level3 : LevelAbstract
    {
        const int LOCATION_LET_3LEVEL = 270;
        bool ruinBlock; //Разрушено ли препятствие
        public Level3()
        {
            ruinBlock = false;
        }
        public override string levelLabel()
        {
            return "Level III";
        }
        public override bool completteLevel1(PictureBox Cat1, PictureBox Cat2) //прохождения уровня 1
        {
            if (Cat1.Location.X >= LOCATION_CRYSTAL || Cat2.Location.X >= LOCATION_CRYSTAL)
            {
                return true; //успешно завершился уровень
            }
            return false;
        }
        public override bool  ExistLet(PictureBox Cat1, PictureBox Cat2)
        {
            if ((Cat1.Location.X >= LOCATION_LET_3LEVEL || Cat2.Location.X >= LOCATION_LET_3LEVEL))
            {
                return true;
            }
            else
                return false;
        }
        public bool GetRuinBlock()
        {
            return ruinBlock;
        }
        public override int GetMaterial()
        {
            return 2; //дерево
        }
        public override void SetMaterial(int material)
        {      
        }
       
    }
}
