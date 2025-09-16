namespace Uno;

public class Program
{
    public static void Main(string[] args)
    {
        Card card = new Card();
        card.Type = CardType.Number;
        card.Color = Color.Red;
        card.Number = 3;

        Console.WriteLine(card.ToString());

        Player player = new Player();
        System.Console.WriteLine(player.Hand);

        // player.Hand.Add(new Card() { Type = CardType.Number, Number = 2, Color = Color.Green });
        player.Hand = new List<Card>();
        player.Hand.Add(card);
        System.Console.WriteLine(player.Hand[0]);
    }
}
