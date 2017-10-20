using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{
    public abstract class LevelAbstract
    {
        public int LOCATION_CRYSTAL = 710;
        public static int locationCrystal; 

        public abstract string levelLabel();
        public abstract bool completteLevel1(PictureBox Cat1, PictureBox Cat2);
        public abstract bool ExistLet(PictureBox Cat1, PictureBox Cat2);
        public abstract int GetMaterial();
        public abstract void SetMaterial(int material);
        public static void SetLocationCrystal(int location) //по X
        {
            locationCrystal = location; 
        }
        public static int GetLocationCrystal()
        {
            return locationCrystal;
        }
    }
}
