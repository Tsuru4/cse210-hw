using System;
//stretch challenge: created an outer menu, allowing Program to track several players at once and display a "scoreboard" at the end.
class Program
{
    static void Main(string[] args)
    {
        string name;
        List<GoalManager> players = new List<GoalManager>();
        do
        {
            GoalManager currentPlayer;
            Console.WriteLine("What is the player's name? (No spaces)");
            Console.WriteLine("(type quit to quit)");

            name = Console.ReadLine();

            if (name != "quit")
            {
                bool playerExists = false;

                foreach (GoalManager player in players)
                {
                    if (player.GetName() == name)
                    {
                        currentPlayer = player;
                        playerExists = true;
                        currentPlayer.Start();
                    }
                }
        
                if (playerExists == false)
                {
                    currentPlayer = new GoalManager(name);
                    players.Add(currentPlayer);
                    currentPlayer.Start();
                }
            }
        }while(name != "quit");
    
        //calculate the "winner"
        int highscore = -1;
        string winningPlayer = "No one";
        foreach (GoalManager player in players)
        {
            Console.WriteLine($"{player.GetName()}: {player.GetScore()}");
            if (player.GetScore() > highscore)
            {
                highscore = player.GetScore();
                winningPlayer = player.GetName();
            }
        }
        Console.WriteLine($"\n{winningPlayer} currently has the highest score! ({highscore})");
    }
}