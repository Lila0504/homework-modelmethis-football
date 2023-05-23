// See https://aka.ms/new-console-template for more information
using Homework_Model_me_this___Football;


IPlayer player1 = new Goalkeeper("John", 25, 1, 185);
IPlayer player2 = new Defender("Mike", 28, 4, 180);
IPlayer player3 = new Midfielder("David", 23, 7, 178);
IPlayer player4 = new Striker("Peter", 30, 9, 183);

//Create coach
IPerson coach1 = new Coach("Alex", 45);
IPerson coach2 = new Coach("Mark", 45);


//Create teams
List<IPlayer> team1Players = new List<IPlayer> { player1, player2, player3, player4 };
Team team1 = new Team ((Coach)coach1, team1Players);

List<IPlayer> team2Players = new List<IPlayer>
{
    new Goalkeeper ("Tom", 21, 4, 190),
    new Defender("James", 28, 4, 180),
    new Midfielder("Aron", 23, 7, 178),
    new Striker("Ricky", 30, 9, 183)
    
};
Team team2 = new Team((Coach)coach2, team2Players);

//Create referee &  assistant referees
IPerson referee = new Referee("Mark", 35);
List<IPerson> assistantReferees = new List<IPerson>
{
    new Person ("Alexa", 28),
    new Person("Bobi", 32)

};

//Create a game
Game game = new Game (team1, team2, (Referee)referee, assistantReferees);

//Simulate the game
game.SimulateGame();

//Print game result
Console.WriteLine("Game Result: " + game.Result);
if (game.Winner != null)
{
    Console.WriteLine("Winner: " + ((Coach)game.Winner.Coach).Name);
}
else
{
    Console.WriteLine("Match ended in a draw");
}