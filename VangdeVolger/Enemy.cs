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
        /// <summary>
        /// Checks aal reachable squares for the closest player and then moves a single step in the direction of that player
        /// By making a list of all gamefields and the amount of steps it takes to get there and then when it has found the player
        /// looking for which step is neigbours with the previous step creating a path
        /// then we take the first step of that path and move in the apropriate direaction
        /// </summary>
        /// <returns></returns>
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

            //while we havent found the player and we havent exhausted the list of considered squares
            while (!playerFound && tentativeSquares.Count != 0)
            {
                //loopcount is the counter to see what step we are at
                loopCount++;

                //walk through all the tentatives we currently have
                for (int i = tentativeSquares.Count - 1; i >= 0; i--)
                {
                    //Walk through all the neighbours of these tentative squares
                    for (int j = 0; j < tentativeSquares[i].neighbor.Length; j++)
                    {   
                        //If the square we want to look at isn't of the edge
                        if (tentativeSquares[i].neighbor[j] != null)
                        {
                            //Make a list of all the currently visited squares
                            List<GameField> tempList = new List<GameField>();
                            foreach (KeyValuePair<int, GameField> item in visitedSquares)
                            {
                                tempList.Add(item.Value);
                            }

                            //If the neighbour is unoccupied, not already under consideration and not already visited
                            if (tentativeSquares[i].neighbor[j].contains == null && !tentativeSquares.Contains(tentativeSquares[i].neighbor[j]) && !tempList.Contains(tentativeSquares[i].neighbor[j]))
                            {
                                //add the neigbour to the list of considered squares
                                tentativeSquares.Add(tentativeSquares[i].neighbor[j]);
                                
                            }
                            //add the considered square to visited squares
                            visitedSquares.Add(new KeyValuePair<int, GameField>(loopCount, tentativeSquares[i]));

                            //if the neigbour of the considered square is a player
                            if (tentativeSquares[i].neighbor[j].contains is Player)
                            {
                                
                                playerFound = true;
                                break;
                            }
                        }
                    }
                    //Remove this square from the list of considered square
                    tentativeSquares.RemoveAt(i);
                }
            }
            
            GameField lastHit = null;
            int currentstep = loopCount;
            //Walk through all steps we need
            for (int i = currentstep; i > 0; i--)
            {
                //Walk through all visitedSquares
                for (int j = visitedSquares.Count - 1; j >= 0; j--)
                {
                    //if the steps required to the reach the current square is equal to the step we are currently at
                    if (visitedSquares[j].Key == i)
                    {
                        //Walk through all the neigbours of this square
                        for (int k = 0; k < visitedSquares[j].Value.neighbor.Length; k++)
                        {
                            //check if the neigbour we are looking at isnt the edge
                            if (visitedSquares[j].Value.neighbor[k] != null)
                            {
                                //if this neighbour contains a player or equals the last step
                                if (visitedSquares[j].Value.neighbor[k].contains is Player || visitedSquares[j].Value.neighbor[k] == lastHit)
                                {
                                    //set the last hit to this square
                                    lastHit = visitedSquares[j].Value;
                                    //add the square to the path
                                    path.Add(visitedSquares[j].Value);
                                }
                            }
                        }
                    }
                }
            }
            //walk through all the current neighbours of the enemy
            for (int i = 0; i < _location.neighbor.Length; i++)
            {
                if (path.Count - 1 >= 0)
                {
                    //if the first step of path equals this neigbour
                    if (_location.neighbor[i] == path[path.Count - 1])
                    {
                        //move in that direction
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
