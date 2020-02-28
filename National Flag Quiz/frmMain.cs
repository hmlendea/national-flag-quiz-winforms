using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace National_Flag_Quiz
{
    public partial class frmMain : Form
    {
        FlagCollection flag = new FlagCollection();

        int Flag1
        {
            get { return flag1; }
            set
            {
                flag1 = value;
                pbFlag1.Image = flag[value].Image;
                pbFlag1.Tag = value;
            }
        } int flag1;
        int Flag2
        {
            get { return flag2; }
            set
            {
                flag2 = value;
                pbFlag2.Image = flag[value].Image;
                pbFlag2.Tag = value;
            }
        } int flag2;
        int Flag3
        {
            get { return flag3; }
            set
            {
                flag3 = value;
                pbFlag3.Image = flag[value].Image;
                pbFlag3.Tag = value;
            }
        } int flag3;
        int Flag4
        {
            get { return flag4; }
            set
            {
                flag4 = value;
                pbFlag4.Image = flag[value].Image;
                pbFlag4.Tag = value;
            }
        } int flag4;
        int FlagTarget
        {
            get { return flagTarget; }
            set
            {
                flagTarget = value;
                lblFlagTarget.Text = flag[value].Name;
            }
        } int flagTarget;
        int Correct
        {
            get { return correct; }
            set
            {
                correct = value;
                lblCorrect.Text = "Correct: " + value.ToString();
            }
        } int correct;
        int Wrong
        {
            get { return wrong; }
            set
            {
                wrong = value;
                lblWrong.Text = "Wrong: " + value.ToString();
            }
        } int wrong;
        int Score
        {
            get { return 3 * correct - 2 * wrong; }
        }

        public frmMain()
        {
            InitializeComponent();

            foreach (string s in Directory.GetFiles("Flags", "*.png"))
                flag.Add(new Flag(Path.GetFileNameWithoutExtension(s), Image.FromFile(s)));

            GetRandomFlags();
            sss();
        }
        private void sss()
        {
            System.Collections.Specialized.StringCollection sc = new System.Collections.Specialized.StringCollection();
            foreach (string s in File.ReadAllLines("sss.txt"))
                sc.Add(s);

            foreach (string s in sc)
                if (File.Exists("Flags\\" + s + ".png") == false)
                    Console.WriteLine(s);
        }
        private void GetRandomFlags()
        {
            Random rnd = new Random();

            Flag1 = Flag2 = Flag3 = Flag4 = rnd.Next(0, flag.Count);

            while (Flag2 == Flag1 || Flag2 == Flag3 || Flag2 == Flag4)
                Flag2 = rnd.Next(0, flag.Count);
            while (Flag3 == Flag1 || Flag3 == Flag2 || Flag3 == Flag4)
                Flag3 = rnd.Next(0, flag.Count);
            while (Flag4 == Flag1 || Flag4 == Flag3 || Flag4 == Flag2)
                Flag4 = rnd.Next(0, flag.Count);

            FlagTarget = rnd.Next(1, 4);
            switch(FlagTarget)
            {
                case 1: FlagTarget = Flag1; break;
                case 2: FlagTarget = Flag2; break;
                case 3: FlagTarget = Flag3; break;
                case 4: FlagTarget = Flag4; break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetRandomFlags();
        }

        private void pbFlag_Click(object sender, EventArgs e)
        {
            PictureBox pbFlag = (PictureBox)sender;

            if (Convert.ToInt32(pbFlag.Tag) == FlagTarget)
            {
                MessageBox.Show("Correct!");
                Correct += 1;
            }
            else
            {
                MessageBox.Show("Wrong!");
                Wrong += 1;
            }

            GetRandomFlags();
            lblScore.Text = "Score: " + Score;
        }
    }
}
