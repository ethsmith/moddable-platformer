public class CharacterMoveEvent : Event
{
    private readonly Character _character;

    private readonly Location _location;
    
    private bool _cancelled = false;

    public CharacterMoveEvent(Character character, Location location)
    {
        _character = character;
        _location = location;
    }

    public Character GetCharacter()
    {
        return _character;
    }

    public Location GetLocation()
    {
        return _location;
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
