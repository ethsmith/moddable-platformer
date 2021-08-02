public class CharacterDeathEvent : Event
{
    private readonly Character _character;

    private readonly Character _killer;

    private bool _cancelled = false;

    public CharacterDeathEvent(Character character, Character killer)
    {
        _character = character;
        _killer = killer;
    }

    public Character GetCharacter()
    {
        return _character;
    }

    public Character GetKiller()
    {
        return _killer;
    }

    public bool IsCancelled()
    {
        return _cancelled;
    }

    public void SetCancelled(bool cancelled)
    {
        _cancelled = cancelled;
    }
}
