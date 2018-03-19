using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangdeVolger
{
    class Level
    {
        private Image _image;
        private Bitmap _buffer;
        private Size _bufferSize;
        private Size _defaultSize;

        private Random _random = new Random();
        private int _sizeX = 50;
        private int _sizeY = 50;
        
        public int sizeX;
        public int sizeY;

        public Timer gameTimer;

        public int playerX;
        public int playerY;

        private Player _playerOne;
        private Enemy _enemy;

        public GameField[,] levelLayout;

        private void Read()
        {

        }

        public void Generate(Level level, Timer timer)
        {

            gameTimer = timer;
            EmptyLevel();
            // Iterate over 2D array levelLayout.
            for (int x = 0; x < levelLayout.GetLength(0); x++)
            {
                for (int y = 0; y < levelLayout.GetLength(1); y++)
                {
                    // Assign the Wall object to the borders of the map.
                    // TODO: Remove this and reimplement in a different way. Can't be a game object.
                    /*if (x == 0 || y == 0 || x == sizeX - 1 || y == sizeY - 1)
                    {
                        levelLayout[x, y].contains = new Wall();
                    }*/
                    //else
                    //{
                    // Generate a pseudo-random number to decide object placement.
                    int percentChance = _random.Next(100);

                    if (percentChance < 30 && levelLayout[x, y].contains == null)
                    {
                        levelLayout[x, y].contains = new Wall();
                    }
                    else if (percentChance > 30 && percentChance < 40 && levelLayout[x, y].contains == null)
                    {
                        levelLayout[x, y].contains = new Box(levelLayout[x, y]);

                    }
                    else if (percentChance > 40 && percentChance < 42 && levelLayout[x, y].contains == null)
                    {
                        levelLayout[x, y].contains = new Powerup(5, gameTimer._gameDuration);
                    }
                    /*else if (levelLayout[x, y].contains == null)
                    {
                        levelLayout[x, y].contains = null;
                    }*/
                    //}
                }
            }

            /* 
            * Generate random positions for player and enemy. 
            * We do this to make sure they are actually in the game, 
            * since the for-loop generator might not hit the numbers needed to generate them.
            */
            playerX = _random.Next(1, _sizeX - 1);
            playerY = _random.Next(1, _sizeY - 1);
            int enemyX = _random.Next(1, _sizeX - 1);
            int enemyY = _random.Next(1, _sizeY - 1);

            levelLayout[playerX, playerY].contains = _playerOne;
            _playerOne.SetLocation(levelLayout[playerX, playerY]);
            levelLayout[enemyX, enemyY].contains = _enemy;
            _enemy.SetLocation(levelLayout[enemyX, enemyY]);

            SetNeighbors();
            /* DEBUG ARRAY CHECKING
            int rowLength = levelLayout.GetLength(0);
            int colLength = levelLayout.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", levelLayout[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            */
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Frame"></param>
        public void Draw(PictureBox Frame)
        {
            //make a bitmap that we can draw to before displaying
            _buffer = new Bitmap(_bufferSize.Width, _bufferSize.Height);


            using (Graphics graphics = Graphics.FromImage(_buffer))
            {

                
                for (int x = 0; x < _sizeX; x++)
                {
                    for (int y = 0; y < _sizeY; y++)
                    {
                        if (levelLayout[x, y].contains is GameObject)
                        {
                            Image toBeDrawn = Image.FromFile(levelLayout[x, y].contains._image);
                            graphics.DrawImage(toBeDrawn, x * toBeDrawn.Width, y * toBeDrawn.Size.Height, toBeDrawn.Width, toBeDrawn.Size.Height);
                        }

                    }
                }

            }

            //set the given picture box to the buffer
            Frame.Image = _buffer;


        }
        public void GetPlayerPosition()
        {
            for (int x = 0; x < levelLayout.GetLength(0); x++)
            {
                for (int y = 0; y < levelLayout.GetLength(1); y++)
                {
                    if (levelLayout[x, y].contains is Player)
                    {

                    }
                }
            }
        }

        private void SetNeighbors()
        {
            // Set neighbors for every GameField
            for (int x = 0; x < levelLayout.GetLength(0); x++)
            {
                for (int y = 0; y < levelLayout.GetLength(1); y++)
                {
                    // Create a new GameField array in the neighbor variable of the GameField.
                    levelLayout[x, y].neighbor = new GameField[4];

                    // Check for every side if it goes out of range and add it to the array. ('null' if out of range).
                    for (int i = 0; i < levelLayout[x, y].neighbor.Length; i++)
                    {
                        if (i == 0 && y - 1 >= 0)
                            levelLayout[x, y].neighbor[i] = levelLayout[x, y - 1];
                        if (i == 1 && x + 1 < levelLayout.GetLength(0))
                            levelLayout[x, y].neighbor[i] = levelLayout[x + 1, y];
                        if (i == 2 && y + 1 < levelLayout.GetLength(1))
                            levelLayout[x, y].neighbor[i] = levelLayout[x, y + 1];
                        if (i == 3 && x - 1 >= 0)
                            levelLayout[x, y].neighbor[i] = levelLayout[x - 1, y];
                    }
                }
            }
        }

        private void EmptyLevel()
        {
            for (int x = 0; x < levelLayout.GetLength(0); x++)
            {
                for (int y = 0; y < levelLayout.GetLength(1); y++)
                {
                    levelLayout[x, y] = new GameField();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        public void SetSize(int X, int Y)
        {
            _sizeX = X;
            _sizeY = Y;
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        public Level(Player player, Enemy enemy)
        {
            //
            //make sure out buffer is equal to the playingfield
            _sizeX = 50;
            _sizeY = 50;


            _bufferSize = new Size(_sizeX * 10, _sizeY * 10);
            levelLayout = new GameField[_sizeX, _sizeY];

            this._playerOne = player;
            this._enemy = enemy;
            EmptyLevel();
        }
    }
}
