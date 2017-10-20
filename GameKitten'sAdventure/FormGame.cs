using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace GameKitten_sAdventure
{
    public partial class FormGame : Form
    {
        PrivateFontCollection font;

        private void fontsProjects()
        {
            this.font = new PrivateFontCollection();
            font.AddFontFile("font/Dpix_8pt.ttf");
        }
        private void aligmentCompanent()
        {
            labelLevel.SetBounds(this.Width / 2 - 60,  labelLevel.Height - 50 , labelLevel.Width, labelLevel.Height);
            labelHelp.SetBounds(this.Width - labelHelp.Width - 10, labelHelp.Height - 50, labelHelp.Width, labelHelp.Height);
           // buttonRun.SetBounds(this.Width - labelHelp.Width - 10, labelHelp.Height - 50, labelHelp.Width, labelHelp.Height);
            //label1.SetBounds(label1.Location.X - 10, label1.Location.Y,)
        }
        private void fonts()
        {
            this.labelINFO.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoIf.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoMagicBlock.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoAttack.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoHolzBlock.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoSteinBlock.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNextLevel.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoJump.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToMainForm.Font = new System.Drawing.Font(font.Families[0], 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Font = new System.Drawing.Font(font.Families[0], 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRun.Font = new System.Drawing.Font(font.Families[0], 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBack.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo1.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo2.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Font = new System.Drawing.Font(font.Families[0], 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Font = new System.Drawing.Font(font.Families[0], 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp.Font = new System.Drawing.Font(font.Families[0], 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevelComplette.Font = new System.Drawing.Font(font.Families[0], 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevel.Font = new System.Drawing.Font(font.Families[0], 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));


        }
        public int param;
        LevelAbstract level;
        Controller contr;
        public bool clickStop;

        public FormGame(LevelAbstract level)
        {
            this.level = level;
            InitializeComponent();
            fontsProjects();
            fonts();
            aligmentCompanent();
            contr = new Controller(level, ref labelLevel, ref let, ref holzBlock, ref magicBlock);
            contr.Stay(ref CatStay, ref Cat1, ref Cat2);
            param = -1;
            clickStop = false; //Не остановлено 
        }
        private void labelHelp_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = GameKitten_sAdventure.Properties.Resources.helpScreen;
            Cat1.Visible = false;
            labelNextLevel.Visible = false;
            Cat2.Visible = false;
            CatStay.Visible = false;
            textBox1.Visible = false;
            labelToMainForm.Visible = false;
            buttonRun.Visible = false;
            buttonStop.Visible = false;
            pictureBox1.Visible = false;
            label1.Visible = false;
            labelLevel.Visible = false;

            labelHelp.Visible = false;
            let.Visible = false;
            labelInfo1.Visible = true;
            labelInfo2.Visible = true;
            labelBack.Visible = true;
            holzBlock.Visible = false;

            if (labelLevel.Text.Equals("Level II"))
            {
                labelInfoJump.Visible = true;
                pictureInfoSteinBlock.Visible = true;
                labelInfoSteinBlock.Visible = true;

            }
            if (labelLevel.Text.Equals("Level III"))
            {
                labelInfoJump.Visible = true;
                pictureInfoSteinBlock.Visible = true;
                labelInfoSteinBlock.Visible = true;
                pictureInfoHolzBlock.Visible = true;
                labelInfoHolzBlock.Visible = true;
                labelInfoAttack.Visible = true;
            }
            if (labelLevel.Text.Equals("Level IV"))
            {
                labelInfoJump.Visible = true;
                pictureInfoSteinBlock.Visible = true;
                labelInfoSteinBlock.Visible = true;
                pictureInfoHolzBlock.Visible = true;
                labelInfoHolzBlock.Visible = true;
                labelInfoAttack.Visible = true;
                labelInfoMagicBlock.Visible = true;
                pictureInfoMagixBlock.Visible = true;
                magicBlock.Visible = false;
                magicHolz.Visible = false;
                magicStein.Visible = false;
                labelInfoIf.Visible = true;
            }
        }
        private void labelBack_Click(object sender, EventArgs e)
        {
            labelInfo1.Visible = false;
            labelInfo2.Visible = false;
            labelBack.Visible = false;
            labelInfoJump.Visible = false;
            pictureInfoSteinBlock.Visible = false;
            labelInfoSteinBlock.Visible = false;

            this.BackgroundImage = GameKitten_sAdventure.Properties.Resources.GameScreen1;
            labelHelp.Visible = true;
            label1.Visible = true;
            CatStay.Visible = true;
            textBox1.Visible = true;
            labelToMainForm.Visible = true;
            buttonRun.Visible = true;
            pictureBox1.Visible = true;
            buttonStop.Visible = true;
            if (labelLevel.Text.Equals("Level II"))
            {
                let.Visible = true;
            }
            labelLevel.Visible = true;

            labelInfoJump.Visible = false;
            pictureInfoSteinBlock.Visible = false;
            labelInfoSteinBlock.Visible = false;
            pictureInfoHolzBlock.Visible = false;
            labelInfoAttack.Visible = false;

            labelInfoHolzBlock.Visible = false;

            labelInfoMagicBlock.Visible = true;
            pictureInfoMagixBlock.Visible = true;
            labelInfoMagicBlock.Visible = false;
            pictureInfoMagixBlock.Visible = false;

            labelInfoIf.Visible = false;

            if (labelLevel.Text.Equals("Level III"))
            {
                holzBlock.Visible = true;
            }
            if (labelLevel.Text.Equals("Level IV"))
            {
                magicBlock.Visible = true;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void Wait(double seconds)
        {
            int ticks = System.Environment.TickCount + (int)Math.Round(seconds * 1000.0);
            while (System.Environment.TickCount < ticks)
            {
                Application.DoEvents();
            }
        }
        private void ChangeMagicBlock(int materialInt)
        {
            magicBlock.Visible = false;
            if (materialInt == 2)
            {
                magicHolz.Visible = true;
            }
            if (materialInt == 1)
            {
                magicStein.Visible = true;
            }
        }
        private bool DoIt(string command, int materialInt, ref bool complette, ref bool clickStop)
        {
            if (string.Compare(command, "Go();", StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                // param = 1; // один шаг
                // contr.Move(ref Cat1, ref Cat2, this.Size.Width, ref complette, ref CatStay, ref param, ref clickStop, ref materialInt);   
                contr.MoveOneStep(ref Cat1, ref Cat2, this.Size.Width, ref complette, ref CatStay, ref clickStop, ref materialInt, ref labelINFO);
            }
            else
                if (string.Compare(command, "Jump();", StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    int mat = level.GetMaterial();
                    contr.Jump(ref Cat1, ref Cat2, this.Size.Width, ref complette, ref CatStay, ref clickStop, mat);
                }
                else if (string.Compare(command, "Attack();", StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    Cat1.Visible = false;
                    Cat2.Visible = false;
                    CatStay.Location = Cat2.Location;
                    CatStay.Visible = true;

                    bool existHolzBlock;

                    contr.Attack(ref CatStay, ref clickStop, out existHolzBlock, ref labelINFO);

                    if (level.GetMaterial() == 2 && existHolzBlock)
                    {
                        holzBlock.Visible = false;
                        if (level.levelLabel().Equals("Level IV"))
                        {
                            magicHolz.Visible = false;
                        }
                    }
                }
                else
                {
                    ClassSound.playError();
                    labelError.Visible = true;
                    labelError.Text += "\nНеизвестная команда " + command;
                    labelError.Visible = true;
                    timer1.Enabled = false;
                    clickStop = true;
                    return false;
                }
            return true; //выполнилась без ошибок
        }
        private void buttonRun_Click(object sender, EventArgs e)
        {
            labelNextLevel.Visible = false;
            if (labelLevel.Text.Equals("Level III"))
            {
                holzBlock.Visible = true;
            }
            clickStop = false;
            labelLevelComplette.Visible = false;
            pictureBox1.Image = GameKitten_sAdventure.Properties.Resources.diamant2;
            contr.ReturnBeginPosition(ref CatStay, this.Width);
            contr.ReturnBeginPosition(ref Cat1, this.Width);
            contr.ReturnBeginPosition(ref Cat2, this.Width);
            int materialIntIf = 0;
            string command;
            String[] s = textBox1.Text.Split(new String[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            labelINFO.Visible = true;
            labelINFO.Text = "";

            bool complette = false;
            for (int i = 0; i < s.Length; i++)
            {
                command = "";
                materialIntIf = 0;//неизвестно, какой материал
                if (!complette || !clickStop)
                {
                    //if (...) then
                    Regex regexIf = new Regex(@"if\s*\(\s*(wooden block|stone block)\s*\)\sthen\s*[A-Z|a-z|;|(|)]*$", RegexOptions.IgnoreCase);

                    //if (...) then ... else ...  
                    Regex regexIfElse = new Regex(@"if\s*\(\s*(wooden block|stone block)\s*\)\s*then\s*[A-Z|a-z|;|(|)]*\s*else\s*[A-Z|a-z|;|(|)]*", RegexOptions.IgnoreCase);

                    //while (...) do { ... } 
                    Regex regexWhile = new Regex(@"while\s*\(\s*(free)\s*\)\s*do\s*{", RegexOptions.IgnoreCase);


                    s[i] = s[i].ToLower();
                    //s[i] = s[i].Replace(" ", "");
                    if (regexIf.IsMatch(s[i]))
                    {
                        int begPos = s[i].IndexOf("then");
                        int endPos = s[i].IndexOf(';');
                        int length = endPos - begPos - 4;
                        int temp = 0;
                        command = ""; //Команда, выполняемая, если условие выполнено
                        for (int j = begPos + 5; j < endPos; j++)
                        {
                            if (char.IsLetter(s[i][j]))
                            {
                                command = s[i].Substring(j, length - temp);
                                break;
                            }
                            temp++;
                        }
                        Match match = regexIf.Match(s[i]);
                        if (match.Groups[1].Value == "wooden block")
                        {
                            materialIntIf = 2;
                        }
                        if (match.Groups[1].Value == "stone block")
                        {
                            materialIntIf = 1;
                        }
                        if (level.GetMaterial() == materialIntIf)
                            DoIt(command, materialIntIf, ref complette, ref clickStop);
                    }
                    else
                        if (regexIfElse.IsMatch(s[i]))
                        {
                            int posThen = s[i].IndexOf("then");
                            int posElse = s[i].IndexOf("else");


                            string commandThen = s[i].Substring(posThen + 5, posElse - posThen - 6);
                            string commandElse = s[i].Substring(posElse + 5, s[i].Length - posElse - 5);

                            int begPosCond = s[i].IndexOf("(");
                            int endPosCond = s[i].IndexOf(")");
                            string condition = s[i].Substring(begPosCond + 1, endPosCond - begPosCond - 1);
                            if (condition == "wooden block")
                            {
                                materialIntIf = 2;
                            }
                            if (condition == "stone block")
                            {
                                materialIntIf = 1;
                            }
                            //labelINFO.Text = commandThen +" " + commandElse;

                            if (level.GetMaterial() == materialIntIf) //Если условие выполняется, то выполняем команду после then
                            {
                                DoIt(commandThen, materialIntIf, ref complette, ref clickStop);
                            }
                            else //иначе после else
                            {
                                DoIt(commandElse, materialIntIf, ref complette, ref clickStop);
                            }


                        }
                        else if (regexWhile.IsMatch(s[i]))
                        {
                            int begPos = s[i].IndexOf("{");
                            int endPos = s[i].IndexOf("}");
                            string allComand = s[i].Substring(begPos + 1, endPos - begPos - 1);

                            char[] delimiter = { ' ' };
                            string[] commands = allComand.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                            int begPosCond = s[i].IndexOf("(");
                            int endPosCond = s[i].IndexOf(")");

                            string condition = s[i].Substring(begPosCond + 1, endPosCond - begPosCond - 1);
                            condition = condition.Replace(" ", "");
                            materialIntIf = 0;
                            if (condition == "free")
                            {
                                while (!clickStop && !contr.IsExistLet(level, ref labelLevel, ref Cat1, ref Cat2) && !contr.IsExistDiamond(level, ref labelLevel, ref Cat1, ref Cat2))
                                // while (!clickStop && !contr.IsExistDiamond(level, ref labelLevel, ref Cat1, ref Cat2))
                                {
                                    for (int j = 0; j < commands.Length; j++)
                                    {
                                        //  if (!clickStop && !contr.IsExistDiamond(level, ref labelLevel, ref Cat1, ref Cat2))
                                        if (!clickStop && !contr.IsExistLet(level, ref labelLevel, ref Cat1, ref Cat2) && !contr.IsExistDiamond(level, ref labelLevel, ref Cat1, ref Cat2))
                                        {

                                            commands[j] = commands[j].Replace(" ", "");
                                            DoIt(commands[j], materialIntIf, ref complette, ref clickStop);
                                        }
                                    }
                                }
                                CatStay.Location = Cat1.Location;
                                CatStay.Location = Cat2.Location;
                                Cat1.Visible = false;
                                Cat2.Visible = false;
                                CatStay.Visible = true;

                                if (labelLevel.Text.Equals("Level IV"))
                                {
                                    if (level.ExistLet(Cat1, Cat2) && !contr.GetRuinBlock4())
                                    {
                                        Random rnd = new Random();
                                        int materialInt = rnd.Next(1, 3);
                                        ChangeMagicBlock(materialInt);
                                        level.SetMaterial(materialInt);
                                    }
                                }
                            }
                        }
                        else
                            DoIt(s[i], materialIntIf, ref complette, ref clickStop);
                }
            }
            if (complette)
            {
                ClassSound.playWin();
                pictureBox1.Image = GameKitten_sAdventure.Properties.Resources.diamantComplette;
                labelLevelComplette.Visible = true;
                labelNextLevel.Visible = true;

                if (labelLevel.Text.Equals("Level IV"))
                {
                    labelNextLevel.Text = "Следующие уровни - скоро!";
                }
            }
            CatStay.Location = Cat1.Location;
            CatStay.Location = Cat2.Location;
            Cat1.Visible = false;
            Cat2.Visible = false;
            CatStay.Visible = true;
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            level.SetMaterial(0);
            contr.SetFalseStayOnLet();
            labelNextLevel.Visible = false;
            clickStop = true;
            contr.Stay(ref CatStay, ref Cat1, ref Cat2);
            labelError.Visible = false;
            pictureBox1.Image = GameKitten_sAdventure.Properties.Resources.diamant2;
            labelLevelComplette.Visible = false;
            labelError.Text = "Ошибка!";
            if (labelLevel.Text.Equals("Level III"))
            {
                holzBlock.Visible = true;
            }
            if (labelLevel.Text.Equals("Level IV"))
            {
                magicBlock.Visible = true;
                magicHolz.Visible = false;
                magicStein.Visible = false;
            }
            contr.ReturnBeginPosition(ref CatStay, this.Width);

        }

        private void labelToMainForm_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
        }

        private void labelNextLevel_Click(object sender, EventArgs e)
        {
            if (labelLevel.Text.Equals("Level I"))
            {
                FormGame formGameNextLevel = new FormGame(new Level2());
                formGameNextLevel.Show();
                this.Hide();
            }
            else
                if (labelLevel.Text.Equals("Level II"))
                {
                    FormGame formGameNextLevel = new FormGame(new Level3());
                    formGameNextLevel.Show();
                    this.Hide();
                }
                else
                    if (labelLevel.Text.Equals("Level III"))
                    {
                        FormGame formGameNextLevel = new FormGame(new Level4());
                        formGameNextLevel.Show();
                        this.Hide();
                    }
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void FormGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void labelCompletteLevelNew_Click(object sender, EventArgs e)
        {
            if (labelLevel.Text.Equals("Level I"))
            {
                FormGame formGameNextLevel = new FormGame(new Level2());
                formGameNextLevel.Show();
                this.Hide();
            }
            else
                if (labelLevel.Text.Equals("Level II"))
                {
                    FormGame formGameNextLevel = new FormGame(new Level3());
                    formGameNextLevel.Show();
                    this.Hide();
                }
                else
                    if (labelLevel.Text.Equals("Level III"))
                    {
                        FormGame formGameNextLevel = new FormGame(new Level4());
                        formGameNextLevel.Show();
                        this.Hide();
                    }

        }

        private void labelInfo1_Click(object sender, EventArgs e)
        {

        }

        private void labelInfoIf_Click(object sender, EventArgs e)
        {

        }
    }
}
