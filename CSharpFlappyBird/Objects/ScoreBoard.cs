using CSharpFlappyBird.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFlappyBird.Objects
{
    public partial class ScoreBoard : UserControl
    {
        public ScoreBoard()
        {
            InitializeComponent();
        }

        public void UpdateScore(int score)
        {
            int leftNumber = score / 10;
            int rightNumber = score % 10;

            UpdateScoreBoard(pctLeftNumber, leftNumber);
            UpdateScoreBoard(pctRightNumber, rightNumber);
        }

        private void UpdateScoreBoard(PictureBox pctNumber, int number)
        {
            switch (number)
            {
                case 0:
                    pctNumber.BackgroundImage = Resources._0;
                    break;
                case 1:
                    pctNumber.BackgroundImage = Resources._1;
                    break;
                case 2:
                    pctNumber.BackgroundImage = Resources._2;
                    break;
                case 3:
                    pctNumber.BackgroundImage = Resources._3;
                    break;
                case 4:
                    pctNumber.BackgroundImage = Resources._4;
                    break;
                case 5:
                    pctNumber.BackgroundImage = Resources._5;
                    break;
                case 6:
                    pctNumber.BackgroundImage = Resources._6;
                    break;
                case 7:
                    pctNumber.BackgroundImage = Resources._7;
                    break;
                case 8:
                    pctNumber.BackgroundImage = Resources._8;
                    break;
                case 9:
                    pctNumber.BackgroundImage = Resources._9;
                    break;
            }
        }
    }
}
