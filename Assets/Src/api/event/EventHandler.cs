using System;

public class EventHandler : Attribute
{
    public EventPriority Priority = EventPriority.NORMAL;
}
