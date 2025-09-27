using CSharpFlappyBird.Properties;
using CSharpFlappyBird.Scripts;
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
    public partial class Bird : UserControl
    {
        private Animation _animation;
        private System.Windows.Forms.Timer _gravityTimer;
        private int _interval = 100;
        public int gravity = 10;

        public Bird()
        {
            InitializeComponent();
            _animation = new Animation(pctBird);
            _animation.Interval = 100;

            _animation.Sprites.Add(Resources.yellowbird_upflap);
            _animation.Sprites.Add(Resources.yellowbird_midflap);
            _animation.Sprites.Add(Resources.yellowbird_downflap);
            _animation.Sprites.Add(Resources.yellowbird_midflap);

            _gravityTimer = new System.Windows.Forms.Timer();
            _gravityTimer.Interval = _interval;
            _gravityTimer.Tick += _gravityTimer_Tick;
        }

        private void _gravityTimer_Tick(object? sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y + gravity);
        }

        private void Bird_Load(object sender, EventArgs e)
        {
            _animation.Start();
        }

        public void Start()
        {
            _animation.Start();
            _gravityTimer.Start();
        }

        public void Stop()
        {
            _animation.Stop();
            _gravityTimer.Stop();
        }
    }
}
