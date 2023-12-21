using Nsu.ColiseumProblem.Contracts;
using Nsu.ColiseumProblem.Contracts.Cards;

namespace Nsu.Coliseum.Strategies;

public abstract class AlwaysColorStrategy : ICardPickStrategy
{
    private CardColor _color;

    protected AlwaysColorStrategy(CardColor color) => _color = color;

    public int Pick(Card[] cards)
    {
        for (int i = 0; i < cards.Length; ++i)
        {
            if (_color == cards[i].Color) return i;
        }

        return cards.Length - 1;
    }
}

public class AlwaysRedStrategy : AlwaysColorStrategy
{
    public AlwaysRedStrategy() : base(CardColor.Red)
    {
        
    }
}

public class AlwaysBlackStrategy : AlwaysColorStrategy
{
    public AlwaysBlackStrategy() : base(CardColor.Black)
    {
        
    }
}
