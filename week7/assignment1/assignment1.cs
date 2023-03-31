using System;

public class Program {
    static void Main() {
        Player player = new Player("Alice");
        int randomScore = new Random().Next(0, 101);
        player.SetScore(randomScore);
        Console.WriteLine($"Player with nickname {player.Nickname} and ID {player.Id} has score {player.Score}");
    }
}
public class Player {
    private static int nextId = 1;

    public int Id { get; private set; }
    public string Nickname { get; private set; }
    public int Score { get; private set; }

    public Player(string nickname) {
        Id = nextId++;
        Nickname = nickname;
        Score = 0;
    }

    public void SetScore(int score) {
        Score = score;
    }
}