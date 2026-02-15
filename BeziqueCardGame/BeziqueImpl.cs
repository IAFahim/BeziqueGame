namespace BeziqueCardGame;

public partial class Bezique
{
    internal IBeziqueAdapter _adapter;

    Bezique(IBeziqueAdapter adapter)
    {
        _adapter = adapter;
    }
}