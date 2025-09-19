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
        foreach (var iterate_card in Hand)
        {
            if (Card.PlaysOn(iterate_card, card))
            {
                return iterate_card;
            }
        }
        return null;
    }


    public Color MostCommonColor()
    {
        double red_count = 0;
        double blue_count = 0;
        double green_count = 0;
        double yellow_count = 0;
        double wild_count = 0;

        foreach (var card in Hand) //store the counts of the colors that appear
        {
            switch (card.Color)
            {
                case Color.Yellow:
                    yellow_count++;
                    break;
                case Color.Blue:
                    blue_count++;
                    break;
                case Color.Green:
                    green_count++;
                    break;
                case Color.Red:
                    red_count++;
                    break;
                case Color.Wild:
                    wild_count++;
                    break;
                default:
                    break;
            }
        }

        double[] sums = { red_count, yellow_count, blue_count, green_count, wild_count };
        double max_val = sums.Max();


        if (max_val == red_count) //elif order automatically accounts for ties
        {
            return Color.Red;
        }
        else if (max_val == yellow_count)
        {
            return Color.Yellow;
        }
        else if (max_val == blue_count)
        {
            return Color.Blue;
        }
        else if (max_val == green_count)
        {
            return Color.Green;
        }
        else if (max_val == wild_count)
        {
            return Color.Wild;
        }

        return Color.Red;
    }

}