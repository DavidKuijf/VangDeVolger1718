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

        private float _imageSizeX;
        private float _imageSizeY;

        private Random _random = new Random();

        private int _sizeX = 50;
        private int _sizeY = 50;

        private int _wallPercent;
        private int _boxPercent;
        private int _powerUpPercent;

        public List<Powerup> powerupList = new List<Powerup>();

        public int playerX;
        public int playerY;

        //public Timer gameTimer;

        private Player _playerOne;
        private Enemy _enemy;

        public GameField[,] levelLayout;

       

        private void Read()
        {

        }

        public void Generate()
        {

            EmptyLevel();
            // Iterate over 2D array levelLayout.
            for (int x = 0; x < levelLayout.GetLength(0); x++)
            {
                for (int y = 0; y < levelLayout.GetLength(1); y++)
                {
                    
                    // Generate a pseudo-random number to decide object placement.
                    int percentChance = _random.Next(100);

                    if (percentChance < _wallPercent && levelLayout[x, y].contains == null)
                    {
                        //create Wall
                        levelLayout[x, y].contains = new Wall();
                        levelLayout[x, y].contains.SetLocation(levelLayout[x,y]);
                    }
                    else if (percentChance > _wallPercent && percentChance < (_wallPercent + _boxPercent) && levelLayout[x, y].contains == null)
                    {
                        //Create Box
                        levelLayout[x, y].contains = new Box(levelLayout[x, y]);
                        levelLayout[x, y].contains.SetLocation(levelLayout[x, y]);

                    }
                    else if (percentChance > (_wallPercent + _boxPercent) && percentChance < (_wallPercent + _boxPercent + _powerUpPercent) && levelLayout[x, y].contains == null)
                    {
                        //Create Powerup

                        levelLayout[x, y].contains = new Powerup(5);
                        powerupList.Add((Powerup)levelLayout[x, y].contains);
                        levelLayout[x, y].contains.SetLocation(levelLayout[x, y]);
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
            int enemyX = -1;
            int enemyY = -1;

            // Make sure the player and the enemy do not get generated in the same spots.
            while ((enemyX == -1 && enemyY == -1) || (enemyX == playerX && enemyY == playerY))
            {
                enemyX = _random.Next(1, _sizeX - 1);
                enemyY = _random.Next(1, _sizeY - 1);
            }

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

            float imageSizeX = Frame.Width / _sizeX;
            float imageSizeY = Frame.Height / _sizeY;

            using (Graphics graphics = Graphics.FromImage(_buffer))
            {


                for (int x = 0; x < _sizeX; x++)
                {
                    for (int y = 0; y < _sizeY; y++)
                    {
                        if (levelLayout[x, y].contains is GameObject)
                        {
                            Image toBeDrawn = Image.FromFile(levelLayout[x, y].contains._image);
                            graphics.DrawImage(toBeDrawn, x * imageSizeX, y * imageSizeY, imageSizeX, imageSizeY);
                        }

                    }
                }

            }

            //set the given picture box to the buffer
            Frame.Image = _buffer;


        }
      

        /// <summary>
        /// 
        /// </summary>
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
        
        /// <summary>
        /// 
        /// </summary>
        private void EmptyLevel()
        {
            levelLayout = new GameField[_sizeX, _sizeY];
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

        public void SetWallChance(int chance)
        {
            _wallPercent = chance;
        }

        public void SetBoxChance(int chance)
        {
            _boxPercent = chance;
        }

        public void SetPowerUpChance(int chance)
        {
            _powerUpPercent = chance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player"></param>
        /// <param name="enemy"></param>
        public Level(Player player, Enemy enemy)
        {
            //make sure out buffer is equal to the playingfield
            _sizeX = 10;
            _sizeY = 10;

            _imageSizeX = _defaultSize.Width;
            _imageSizeY = _defaultSize.Height;

            _wallPercent = 5;
            _boxPercent = 20;
            _powerUpPercent = 2;

            _bufferSize = new Size(500, 500);

            _playerOne = player;
            _enemy = enemy;
            EmptyLevel();
        }
    }
}
