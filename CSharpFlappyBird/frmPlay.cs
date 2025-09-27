using CSharpFlappyBird.Objects;
using CSharpFlappyBird.Properties;
using CSharpFlappyBird.Scripts;
using System.Net.NetworkInformation;

namespace CSharpFlappyBird
{
    public partial class frmPlay : Form
    {
        private Point _birdSpawnPoint = new Point(127, 244);
        private Point _pipeSpawnPoint = new Point(288 + 52, 0);
        private Bird _bird;
        private List<Pipes> _pipes;
        private ScoreBoard _scoreBoard;

        private System.Windows.Forms.Timer _gameTimer;
        private int _tickCounter = 0;

        private bool _isGameStarted = true;
        private bool _isGameFinished = false;
        private StartScreen _startScreen;
        private int _score = 0;

        public frmPlay()
        {
            InitializeComponent();

            _scoreBoard = new ScoreBoard();
            _bird = new Bird();
            _pipes = new List<Pipes>();
            _startScreen = new StartScreen();

            _gameTimer = new System.Windows.Forms.Timer();
            _gameTimer.Interval = 20;
            _gameTimer.Tick += _gameTimer_Tick;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void _gameTimer_Tick(object? sender, EventArgs e)
        {
            CheckGameStatus();
            CheckAndRemovePipes();
            GroundAnimation();

            _tickCounter++;
            if (_tickCounter == 75)
            {
                GeneratePipes();
                _tickCounter = 0;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (_isGameStarted)
            {
                if (e.KeyCode == Keys.Space)
                {
                    _bird.Location = new Point(_bird.Location.X, _bird.Location.Y - 20);
                    _bird.gravity = 0;
                }
            }

            else
            {
                if (_isGameFinished)
                {
                    ResetGame();
                    _isGameFinished = false;
                }

                else
                {
                    pnlCanvas.Controls.Remove(_startScreen);
                    _gameTimer.Start();
                    _bird.Start();
                    _isGameStarted = true;
                }
            }
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (_isGameStarted)
            {
                if (e.KeyCode == Keys.Space)
                {
                    _bird.gravity = 10;
                }
            }
        }

        private void GeneratePipes()
        {
            Pipes pipe = new Pipes();
            pipe.Location = _pipeSpawnPoint;
            _pipes.Add(pipe);
            pnlCanvas.Controls.Add(pipe);
        }

        private void CheckAndRemovePipes()
        {
           
            if (pnlCanvas.Controls.Count >= 4)
            {
                if (pnlCanvas.Controls[3].Location.X < -52)
                    pnlCanvas.Controls.RemoveAt(3);
            }
        }

        private void CheckGameStatus()
        {
            if (_bird.Bounds.IntersectsWith(pnlGround.Bounds))
            {
                _bird.Location = new Point(_bird.Location.X, pnlGround.Location.Y - _bird.Height);
                GameOver();
            }

            foreach (Pipes pipes in _pipes)
            {
                if (_bird.Bounds.IntersectsWith(pipes.Bounds))
                {
                    int topPipeY = pipes.pctTopPipe.Location.Y + pipes.pctTopPipe.Height;
                    int bottomPipeY = pipes.pctBottomPipe.Location.Y;

                    if (_bird.Location.Y <= topPipeY)
                    {
                        _bird.Location = new Point(_bird.Location.X, topPipeY);
                        GameOver();
                    }

                    else if (_bird.Location.Y + _bird.Height >= bottomPipeY)
                    {
                        _bird.Location = new Point(_bird.Location.X, bottomPipeY - _bird.Height);
                        GameOver();
                    }

                    else if (_bird.Location.X + (_bird.Width / 2) >= pipes.Location.X + (pipes.Width / 2))
                    {
                        if (!pipes.IsPassed)
                        {
                            _score++;
                            _scoreBoard.UpdateScore(_score);
                            pipes.IsPassed = true;
                        }
                    }
                }
            }
        }

        private void GameOver()
        {
            _bird.Stop();
            _gameTimer.Stop();

            foreach (Pipes pipes in _pipes)
            {
                pipes.Stop();
            }

            GameOverTitle gameOver = new GameOverTitle();
            gameOver.Location = new Point(48, 150);
            pnlCanvas.Controls.Add(gameOver);
            pnlCanvas.Controls.SetChildIndex(gameOver, 0);

            _isGameStarted = false;
            _isGameFinished = true;
        }

        private void ResetGame()
        {
            _isGameStarted = false;
            _score = 0;
            _tickCounter = 0;

            pnlCanvas.Controls.Clear();
            _pipes.Clear();

            pnlCanvas.Controls.Add(pnlGround);

            _scoreBoard.Location = new Point(120, 25);
            _scoreBoard.UpdateScore(_score);
            pnlCanvas.Controls.Add(_scoreBoard);

            _bird.Location = _birdSpawnPoint;
            pnlCanvas.Controls.Add(_bird);

            _startScreen.Location = new Point(52, 74);
            pnlCanvas.Controls.Add(_startScreen);
        }

        private void GroundAnimation()
        {
            if (pnlGround.Location.X <= -288)
            {
                pnlGround.Location = new Point(0, pnlGround.Location.Y);
            }

            pnlGround.Location = new Point(pnlGround.Location.X - 4, pnlGround.Location.Y);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
