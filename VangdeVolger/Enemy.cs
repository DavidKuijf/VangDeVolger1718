using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangdeVolger
{
    class Enemy : Movable
    {
        private Random random = new Random();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool CheckWin()
        {
            int winCount = 0;

            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (!(_location.neighbor[i] == null))
                {
                    //check if the field in the specified direction is empty
                    if (_location.neighbor[i].contains != null && !(_location.neighbor[i].contains is Player))
                    {
                        winCount++;
                    }
                }
                else
                {
                    winCount++;
                }
            }

            if (winCount == _location.neighbor.Length)
                return true;
            else
                return false;
        }

        

        private bool CheckPlayer(Directions direction)
        {
            if (_location.neighbor[(int)direction] != null)
            {
                //check if the field in the specified direction is empty
                if (_location.neighbor[(int)direction].contains is Player)
                {
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Decide first checks wheter there is a player in range to kill
        /// if there is it kills that player
        /// else it moves in a random direction
        /// if this is not possible it declares the player has won
        /// </summary>
        /// <param name="won"></param>
        /// <param name="lost"></param>
        /// <returns></returns>
        public void Decide(out bool won, out bool lost)
        {
            won = false;
            lost = false;
            bool moved = false;

            // Check all neighbors, kill and move to player if found.
            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (CheckPlayer((Directions)i))
                {
                    _location.neighbor[i].contains = null;
                    Move((Movable.Directions)i);
                    moved = true;
                    lost = true;
                    break;
                }
            }

            if (!moved)
            {
                moved = Pathfinding();
            }
            


            while (!moved && !CheckWin())
            {
                Directions direction = (Directions)random.Next(4);
                if (CheckDirection(direction) && !CheckWin() && !lost)
                {
                    Move(direction);
                    moved = true;
                    break;
                }
            }

            if (CheckWin())
            {
                won = true;
            }

           
        }

        private bool Pathfinding()
        {
            //Init all the vars
            List<KeyValuePair<int, GameField>> visitedSquares = new List<KeyValuePair<int, GameField>>();
            List<GameField> tentativeSquares = new List<GameField>();
            List<GameField> path = new List<GameField>();

            bool playerFound = false;
            int loopCount = 0;

            //Add the current location to visitedSquares as init
            visitedSquares.Add(new KeyValuePair<int, GameField>(0, _location));
            //Add the Neigbours of _location to tentativeSquares as init
            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (_location.neighbor[i] != null)
                {
                    if (_location.neighbor[i].contains == null)
                    {
                        tentativeSquares.Add(_location.neighbor[i]);
                    }
                }

            }

            //while we havent found the player and we havent visited all reachable squares yet
            while (!playerFound && tentativeSquares.Count != 0)
            {
                //loopcount is the counter to see what step we are at
                loopCount++;

                //walk through all the tentatives we currently have
                for (int i = tentativeSquares.Count - 1; i >= 0; i--)
                {
                    //check all the neighbours of these tentative squares
                    for (int j = 0; j < tentativeSquares[i].neighbor.Length; j++)
                    {
                        if (tentativeSquares[i].neighbor[j] != null)
                        {
                            List<GameField> tempList = new List<GameField>();

                            foreach (KeyValuePair<int, GameField> item in visitedSquares)
                            {
                                tempList.Add(item.Value);
                            }

                            if (tentativeSquares[i].neighbor[j].contains == null && !tentativeSquares.Contains(tentativeSquares[i].neighbor[j]) && !tempList.Contains(tentativeSquares[i].neighbor[j]))
                            {
                                tentativeSquares.Add(tentativeSquares[i].neighbor[j]);
                                visitedSquares.Add(new KeyValuePair<int, GameField>(loopCount, tentativeSquares[i]));                              

                            }

                            if (tentativeSquares[i].neighbor[j].contains is Player)
                            {
                                visitedSquares.Add(new KeyValuePair<int, GameField>(loopCount, tentativeSquares[i]));

                                playerFound = true;
                                break;
                            }
                        }
                    }

                    tentativeSquares.RemoveAt(i);
                }
            }

            GameField lastHit = null;
            int currentstep = loopCount;

            for (int i = currentstep; i > 0; i--)
            {
                for (int j = visitedSquares.Count - 1; j >= 0; j--)
                {
                    if (visitedSquares[j].Key == i)
                    {
                        for (int k = 0; k < visitedSquares[j].Value.neighbor.Length; k++)
                        {
                            if (visitedSquares[j].Value.neighbor[k] != null)
                            {
                                if (visitedSquares[j].Value.neighbor[k].contains is Player || visitedSquares[j].Value.neighbor[k] == lastHit)
                                {
                                    lastHit = visitedSquares[j].Value;
                                    path.Add(visitedSquares[j].Value);
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (path.Count - 1 >= 0)
                {
                    if (_location.neighbor[i] == path[path.Count - 1])
                    {
                        Move((Directions)i);
                    }
                }
            }
            return playerFound;
        }

        public Enemy()
        {
            this._image = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\Enemy.png");
        }
    }
}
