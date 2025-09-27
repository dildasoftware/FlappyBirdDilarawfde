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
    public partial class Pipes : UserControl
    {
        private int _topPipeLocationY = -140;
        private int _bottomPipeLocationY = 262;
        private int _offsetRange = 80;
        private Random _random = new Random();

        private System.Windows.Forms.Timer _moveTimer;
        private int _interval = 50;
        private int _movement = 5;

        public int Offset { get; set; }
        public bool IsPassed { get; set; }

        public Pipes()
        {
            InitializeComponent();

            Bitmap topPipe = Resources.pipe_green;
            topPipe.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pctTopPipe.BackgroundImage = topPipe;

            _moveTimer = new System.Windows.Forms.Timer();
            _moveTimer.Interval = _interval;
            _moveTimer.Tick += _moveTimer_Tick;

            IsPassed = false;

            SetOffset();
        }

        private void Pipes_Load(object sender, EventArgs e)
        {
            _moveTimer.Start();
        }

        private void _moveTimer_Tick(object? sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X - _movement, this.Location.Y);
        }

        private void SetOffset()
        {
            Offset = _random.Next(-_offsetRange, _offsetRange + 1);
            pctTopPipe.Location = new Point(0, _topPipeLocationY + Offset);
            pctBottomPipe.Location = new Point(0, _bottomPipeLocationY + Offset);
        }

        public void Stop()
        {
            _moveTimer.Stop();
        }
    }
}
