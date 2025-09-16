namespace Uno;

public class Player
{
    public string Name { get; set; }

    // public List<Card> Hand { get; set; }
    public List<Card> Hand { get; set; } = new List<Card>();


    public bool HasPlayableCard(Card card)
    {
        foreach (var iterate_card in Hand)
        {
            if (Card.PlaysOn(iterate_card, card))
            {
                return true;
            }
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        return null;
    }


    public Color MostCommonColor()
    {
        return Color.Red;
    }

}