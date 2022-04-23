using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legend_of_cortana_cmnd_line_test
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int levelNum = 0;
            int difficultyPoints = 10;
            string[] enemies = {"Enemy 15", "Enemy 14", "Enemy 13", "Enemy 12", "Enemy 11", "Enemy 10", "Enemy 9", "Enemy 8", "Enemy 7", "Enemy 6", "Enemy 5", "Enemy 4", "Enemy 3", "Enemy 2", "Enemy 1"};
            int[] enemyBaseLevel = {1000000, 800000, 500000, 200000, 50000, 10000, 5000, 1000, 800, 600, 500, 300, 150, 70, 10};
            int enemyCurrentLevel = 1;
 

            // functions
            void newLevel()
            {
                // Changing variables and determinging difficulty points
                string currentEnemy1 = " "; string currentEnemy2 = " "; string currentEnemy3 = " ";
                levelNum += 1;
                difficultyPoints = difficultyPoints * (levelNum / 10 + 1) + 15;
                enemyCurrentLevel = enemyCurrentLevel * (50/100 + 1) + 1;
                int tempDifficultyPoints = difficultyPoints - enemyCurrentLevel;
                Console.WriteLine("Level: " + levelNum);
                Console.WriteLine("Difficulty Points: " + difficultyPoints);
                Console.WriteLine("Enemy Level: " + enemyCurrentLevel);

                // Choosing and spawning amounts of enemies based of their level
                for(int i = 0; i<3; i++)
                {
                    for (int e = 0; e < 15; e++)
                    {
                        int tempPoints = tempDifficultyPoints - enemyBaseLevel[e];
                        if (tempPoints > 0)
                        {
                            if (currentEnemy1 == " ")
                            {
                                currentEnemy1 = enemies[e];
                                tempDifficultyPoints -= enemyBaseLevel[e];
                            }
                            else if (currentEnemy2 == " ")
                            {
                                currentEnemy2 = enemies[e];
                                tempDifficultyPoints -= enemyBaseLevel[e];
                            }
                            else if (currentEnemy3 == " ")
                            {
                                currentEnemy3 = enemies[e];
                                tempDifficultyPoints -= enemyBaseLevel[e];
                            }
                        }
                    }
                }
                Console.WriteLine("Enemies: " + currentEnemy1 + "|" + currentEnemy2 + "|" + currentEnemy3 + Environment.NewLine);
            }

            //running the code
            for(int i = 0; i < 25; i++)
            {
                newLevel();
            }
            string end = Console.ReadLine();

        }
    }
}
