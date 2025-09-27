using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFlappyBird.Scripts
{
    public class Animation
    {
        public List<Bitmap> Sprites { get; set; }
        public int Interval { set { _timer.Interval = value; } }

        private PictureBox _target;
        private System.Windows.Forms.Timer _timer;
        private int _index;

        public Animation(PictureBox target)
        {
            Sprites = new List<Bitmap>();
            _target = target;
            _timer = new System.Windows.Forms.Timer();
            _timer.Tick += _timer_Tick;
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }

        private void _timer_Tick(object? sender, EventArgs e)
        {
            _target.BackgroundImage = Sprites[_index];
            _index++;

            if (_index == Sprites.Count)
            {
                _index = 0;
            }
        }
    }
}
