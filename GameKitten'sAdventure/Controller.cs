using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{
    class Controller
    {
        const int LOCATION_FLOOR = 232;
        Random rnd;
        bool stayOnLet1;
        bool stayOnLet2; 
        bool flag;
        public LevelAbstract level;
        bool ruinBlock3; //Разрушен ли блок 3
        bool ruinBlock4; //Разрушен ли магический блок 4

        public bool GetRuinBlock4()
        {
            return ruinBlock4;
        }
        public bool IsExistLet(LevelAbstract level, ref Label levelNum, ref PictureBox cat1, ref PictureBox cat2)
        {
            if (level.ExistLet(cat1, cat2) && (ruinBlock3 || ruinBlock4))
            {
                return false;
            }
            if (stayOnLet1 || stayOnLet2)
            {
                return false;
            }
            return level.ExistLet(cat1, cat2);
        }
        public bool IsExistDiamond(LevelAbstract level, ref Label levelNum, ref PictureBox cat1, ref PictureBox cat2)
        {
            return level.completteLevel1(cat1, cat2);
        }

        public Controller(LevelAbstract level, ref Label levelNum, ref PictureBox let, ref PictureBox holzBlock, ref PictureBox magicBlock)
        {
            //walkLet = false;//пройдено ли препятствие
            rnd = new Random();
            levelNum.Visible = true;
            levelNum.Text = level.levelLabel();
            this.level = level;
            flag = true;
            if (levelNum.Text == "Level II")
            {
                let.Visible = true;
            }
            stayOnLet1 = false;
            if (levelNum.Text == "Level III")
            {
                holzBlock.Visible = true;
                ruinBlock3 = false;
            }
            if (levelNum.Text == "Level IV")
            {
                magicBlock.Visible = true;
                ruinBlock4 = false;
            }
        }
        public void SetFalseStayOnLet()
        {
            stayOnLet1 = false;
            stayOnLet2 = false;
        }
        private void Wait(double seconds)
        {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks)
            {
                Application.DoEvents();
            }
        }
        public void Stay(ref PictureBox catStay, ref PictureBox cat1, ref PictureBox cat2)
        {
            catStay.Visible = true;
            cat1.Visible = false;
            cat2.Visible = false;
            catStay.Location = new Point(39, 260);
            cat1.Location = new Point(39, 260);
            cat2.Location = new Point(39, 260);
        }
        public void ReturnBeginPosition(ref PictureBox cat, int width)
        {
            ruinBlock3 = false;
            ruinBlock4 = false;
            cat.Location = new Point(39, 260);
        }

        public void Jump(ref PictureBox Cat1, ref PictureBox Cat2, int width, ref bool complette, ref PictureBox CatStay, ref bool stop, int materialInt)
        {
            int x = 5; //число на которое увеличиваем X
            int y = -7;
            if (!level.completteLevel1(Cat1, Cat2))
            {
                if (level.levelLabel().Equals("Level II"))
                {
                    if (level.ExistLet(Cat1, Cat2))
                    {
                        CatStay.Visible = false;
                        stayOnLet1 = true;
                        for (int i = 0; i < 5; i++)
                        {

                            if (flag)
                            {
                                Cat1.Visible = true;
                                Cat2.Visible = false;
                                Cat1.Left += x;
                                Cat2.Left += x;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = false;
                            }
                            else
                            {
                                Cat2.Visible = true;
                                Cat1.Visible = false;
                                Cat1.Left += x;
                                Cat2.Left += x;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = true;
                            }
                            Wait(0.1);
                            x += 9;
                            if (i < 2)
                                y = -30;
                            if (i == 2)
                                y = 0;
                        }
                    }
                }
                else if (level.levelLabel().Equals("Level III"))
                {
                    if (level.ExistLet(Cat1, Cat2))
                    {
                        y = 0;
                        x = 0;
                        CatStay.Visible = false;
                        for (int i = 0; i < 4; i++)
                        {
                            if (flag)
                            {
                                Cat1.Visible = true;
                                Cat2.Visible = false;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = false;
                            }
                            else
                            {
                                Cat2.Visible = true;
                                Cat1.Visible = false;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = true;
                            }
                            Wait(0.1);
                            if (i < 2)
                                y -= 10;
                            if (i >= 2)
                                y += 45;
                        }

                        CatStay.Location = Cat1.Location;
                        CatStay.Location = Cat2.Location;
                        Cat1.Visible = false;
                        Cat2.Visible = false;
                        CatStay.Visible = true;
                        return;
                    }
                }
                else if (level.levelLabel().Equals("Level IV"))
                {
                    if (materialInt == 1 && level.ExistLet(Cat1, Cat2)) //Если препятствие каменное, то перепрыгиваем его
                    {
                        CatStay.Visible = false;
                        stayOnLet2 = true;
                        for (int i = 0; i < 5; i++)
                        {
                            if (flag)
                            {
                                Cat1.Visible = true;
                                Cat2.Visible = false;
                                Cat1.Left += x;
                                Cat2.Left += x;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = false;
                            }
                            else
                            {
                                Cat2.Visible = true;
                                Cat1.Visible = false;
                                Cat1.Left += x;
                                Cat2.Left += x;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = true;
                            }
                            Wait(0.1);
                            x += 9;
                            if (i < 2)
                                y = -30;
                            if (i == 2)
                                y = 0;
                        }
                    }
                    else if (materialInt == 2 && level.ExistLet(Cat1, Cat2)) //Если препятствие - деревянное, прыгаем на месте
                    {
                        y = 0;
                        x = 0;
                        CatStay.Visible = false;
                        for (int i = 0; i < 4; i++)
                        {

                            if (flag)
                            {
                                Cat1.Visible = true;
                                Cat2.Visible = false;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = false;
                            }
                            else
                            {
                                Cat2.Visible = true;
                                Cat1.Visible = false;
                                Cat1.Top += y;
                                Cat2.Top += y;
                                flag = true;
                            }
                            Wait(0.1);
                            if (i < 2)
                                y -= 10;
                            if (i >= 2)
                                y += 45;
                        }

                        CatStay.Location = Cat1.Location;
                        CatStay.Location = Cat2.Location;
                        Cat1.Visible = false;
                        Cat2.Visible = false;
                        CatStay.Visible = true;
                        return;
                    }
                }
                if (!level.ExistLet(Cat1, Cat2))
                {
                    CatStay.Visible = false;
                    for (int i = 0; i < 5; i++)
                    {
                        if (flag)
                        {
                            Cat1.Visible = true;
                            Cat2.Visible = false;
                            Cat1.Left += x;
                            Cat2.Left += x;
                            Cat1.Top += y;
                            Cat2.Top += y;
                            flag = false;
                        }
                        else
                        {
                            Cat2.Visible = true;
                            Cat1.Visible = false;
                            Cat1.Left += x;
                            Cat2.Left += x;
                            Cat1.Top += y;
                            Cat2.Top += y;
                            flag = true;
                        }
                        Wait(0.1);
                        x += 2;
                        if (i < 2)
                        {
                            y -= 5;
                        }
                        if (i == 2)
                        {
                            y += 30;
                        }
                        if (i > 2)
                        {
                            y += 10;
                        }
                    }
                }
            }
            CatStay.Location = Cat1.Location;
            CatStay.Visible = true;
            Cat1.Visible = false;
            Cat2.Visible = false;
            complette = level.completteLevel1(Cat1, Cat2);
        }

        public void Attack(ref PictureBox CatStay, ref bool clickStop, out bool existHolzBlock, ref Label labelInfo)
        {
            existHolzBlock = false;
            if (level.levelLabel().Equals("Level III"))
            {
                existHolzBlock = level.ExistLet(CatStay, CatStay);
            }
            if (level.levelLabel().Equals("Level IV"))
            {
                if (level.GetMaterial() == 2)
                {
                    existHolzBlock = level.ExistLet(CatStay, CatStay);
                }
            }
            if (existHolzBlock)
            {
                ruinBlock3 = true; //Блок будет разрушен
                ruinBlock4 = true;
            }
            CatStay.Image = GameKitten_sAdventure.Properties.Resources.catAttackStay;
            Wait(1.7);
            CatStay.Image = GameKitten_sAdventure.Properties.Resources.catInverse;
        }

        public void MoveOneStep(ref PictureBox Cat1, ref PictureBox Cat2, int width, ref bool complette, ref PictureBox CatStay, ref bool clickStop, ref int material, ref Label labelInfo)
        {
            if (clickStop)
            {
                return;
            }
            else
            {
                if (level.levelLabel().Equals("Level II"))
                {
                    if (level.ExistLet(Cat1, Cat2) && !stayOnLet1)
                    {
                        CatStay.Location = Cat1.Location;
                        CatStay.Location = Cat2.Location;
                        Cat1.Visible = false;
                        Cat2.Visible = false;
                        CatStay.Visible = true;
                        return;
                    }
                    if (stayOnLet1)
                    {
                        CatStay.Visible = false;
                        int x = 10;
                        int y = 0;
                        int indx = 0;
                        while (Cat1.Location.Y <= 232)// Пока локация кота не достигнет земли
                        {

                            Cat1.Visible = true;
                            Cat2.Visible = false;
                            Cat1.Left += x;
                            Cat2.Left += x;
                            Cat1.Top += y;
                            Cat2.Top += y;
                            Wait(0.1);
                            if (indx > 2)
                            {
                                y += 8;
                            }

                            Cat2.Visible = true;
                            Cat1.Visible = false;
                            Cat1.Left += x;
                            Cat2.Left += x;
                            Cat1.Top += y;
                            Cat2.Top += y;
                            Wait(0.1);
                            indx++;
                        }
                    }
                }
                else
                    if (level.levelLabel().Equals("Level III"))
                    {
                        if (level.ExistLet(Cat1, Cat2) && !ruinBlock3)
                        {
                            labelInfo.Text = "Exist Let";
                            CatStay.Location = Cat1.Location;
                            CatStay.Location = Cat2.Location;
                            Cat1.Visible = false;
                            Cat2.Visible = false;
                            CatStay.Visible = true;
                            return;
                        }
                    }
                    else if (level.levelLabel().Equals("Level IV"))
                    {
                        if (level.ExistLet(Cat1, Cat2) && !ruinBlock4 && !stayOnLet2)
                        {
                            material = rnd.Next(1, 3);
                            CatStay.Location = Cat1.Location;
                            CatStay.Location = Cat2.Location;
                            Cat1.Visible = false;
                            Cat2.Visible = false;
                            CatStay.Visible = true;
                            return;
                        }
                        else
                            if (stayOnLet2)
                            {
                                CatStay.Visible = false;
                                int x = 10;
                                int y = 0;
                                int indx = 0;
                                while (Cat1.Location.Y <= 232)// Пока локация кота не достигнет земли
                                {

                                    Cat1.Visible = true;
                                    Cat2.Visible = false;
                                    Cat1.Left += x;
                                    Cat2.Left += x;
                                    Cat1.Top += y;
                                    Cat2.Top += y;
                                    Wait(0.1);
                                    if (indx > 2)
                                    {
                                        y += 8;
                                    }

                                    Cat2.Visible = true;
                                    Cat1.Visible = false;
                                    Cat1.Left += x;
                                    Cat2.Left += x;
                                    Cat1.Top += y;
                                    Cat2.Top += y;
                                    Wait(0.1);
                                    indx++;
                                }
                            }
                    }
                CatStay.Visible = false;
                if (flag)
                {
                    CatStay.Visible = false;
                    Cat1.Visible = true;
                    Cat2.Visible = false;
                    Cat1.Left += 12;
                    Cat2.Left += 12;
                    flag = false;
                }
                else
                {
                    Cat2.Visible = true;
                    Cat1.Visible = false;
                    Cat1.Left += 12;
                    Cat2.Left += 12;
                    flag = true;
                }
                Wait(0.1);
            }

            if (level.completteLevel1(Cat1, Cat2) && !clickStop)
            {
                CatStay.Location = Cat1.Location;
                CatStay.Location = Cat2.Location;
                CatStay.Visible = true;
                complette = true;
            }
        }
    }
}
