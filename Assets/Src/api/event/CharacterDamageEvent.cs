public class CharacterDamageEvent : Event
{
    private readonly Character _character;

    private readonly Character _damager;

    private bool _cancelled = false;

    public CharacterDamageEvent(Character character, Character damager)
    {
        _character = character;
        _damager = damager;
    }

    public Character GetCharacter()
    {
        return _character;
    }

    public Character GetDamager()
    {
        return _damager;
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
