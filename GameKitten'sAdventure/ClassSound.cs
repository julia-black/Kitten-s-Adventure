using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameKitten_sAdventure
{
    public static class ClassSound
    {
        static SoundPlayer soundError = new SoundPlayer(Properties.Resources.error);
        static SoundPlayer soundWin = new SoundPlayer(Properties.Resources.win);
       
        static bool soundEnable = true;
        public static void playWin()
        {
            if (soundEnable)
                soundWin.Play();
        }
        public static void playError()
        {
            if (soundEnable)
                soundError.Play();
        }

        public static void SoudOn()
        {
            soundEnable = true;
        }
        public static void SoundOff()
        {
            soundEnable = false;
        }
    }
}
