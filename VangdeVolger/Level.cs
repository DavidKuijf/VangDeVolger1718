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
        private Bitmap _buffer;
        private Random _random = new Random();

        private int _size;
        private int _wallPercent;
        private int _boxPercent;
        private int _powerUpPercent;

        public List<Powerup> powerupList = new List<Powerup>();

        public int playerX;
        public int playerY;

        public int enemyX;
        public int enemyY;

        private Player _playerOne;
        private Enemy _enemy;

        public GameField[,] levelLayout;

        /// <summary>
        /// Generate all elements of the game and fill the level layout.
        /// </summary>
        /// <param name="randomStartingPos">Optional for random starting position</param>
        public void Generate(bool randomStartingPos)
        {
            //call method to empty level 
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
                        levelLayout[x, y].contains = new Powerup();
                        powerupList.Add((Powerup)levelLayout[x, y].contains);
                        levelLayout[x, y].contains.SetLocation(levelLayout[x, y]);
                    }
                }
            }

            /* 
            * Generate random positions for player and enemy. 
            * We do this to make sure they are actually in the game, 
            * since the for-loop generator might not hit the numbers needed to generate them.
            */
            if (randomStartingPos)
            {
                playerX = _random.Next(1, _size- 1);
                playerY = _random.Next(1, _size - 1);
                enemyX = -1;
                enemyY = -1;

                // Make sure the player and the enemy do not get generated in the same spots.
                while ((enemyX == -1 && enemyY == -1) || (enemyX == playerX && enemyY == playerY))
                {
                    enemyX = _random.Next(1, _size - 1);
                    enemyY = _random.Next(1, _size - 1);
                }
            }

            else
            {
                //player in the top corner
                playerX = 0;
                playerY = 0;
                //enemy in the bewlow corner
                enemyX = _size - 1;
                enemyY = _size - 1;
            }

            //set player on the map
            levelLayout[playerX, playerY].contains = _playerOne;
            _playerOne.SetLocation(levelLayout[playerX, playerY]);

            //set enemy on the map
            levelLayout[enemyX, enemyY].contains = _enemy;
            _enemy.SetLocation(levelLayout[enemyX, enemyY]);
            
            //call method to set all the neighbors
            SetNeighbors();
        }

        /// <summary>
        /// Draw the entire game, (this can also be used when restarting the game)
        /// </summary>
        /// <param name="Frame">PictureBox of the 'gamefield'</param>
        public void Draw(PictureBox Frame)
        {
            //make a bitmap that we can draw to before displaying

            _buffer = new Bitmap(Frame.Width, Frame.Height);

            float imageSizeX = Frame.Width / _size;
            float imageSizeY = Frame.Height / _size;

           
           
            
            //draw 
            using (Graphics graphics = Graphics.FromImage(_buffer))
            {
                for (int x = 0; x < _size; x++)
                {
                    for (int y = 0; y < _size; y++)
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
        /// Set the neighbors for every gamefield
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
        /// override all the gamefield so the game is entirely empty
        /// </summary>
        private void EmptyLevel()
        {
            levelLayout = new GameField[_size, _size];

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
        /// <param name="X">X-Coordinate</param>
        /// <param name="Y">Y-Coordinate</param>
        public void SetSize(int temp)
        {
            _size = temp;
            _size = temp;

        }

        /// <summary>
        /// Set wall change with percentage
        /// </summary>
        /// <param name="chance">percentage int for the wall spawn chance</param>
        public void SetGenertionChances(int wallChance , int boxChance, int powerupChance)
        {
            _wallPercent = wallChance;
            _boxPercent = boxChance;
            _powerUpPercent = powerupChance;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="player">Player object</param>
        /// <param name="enemy">enemy object</param>
        public Level(Player player, Enemy enemy)
        {
            //make sure out buffer is equal to the playingfield
            _size = 10;
            _wallPercent = 5;
            _boxPercent = 20;
            _powerUpPercent = 2;
            _playerOne = player;
            _enemy = enemy;
            EmptyLevel();
        }
    }
}
