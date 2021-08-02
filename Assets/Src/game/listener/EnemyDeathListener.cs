using UnityEngine;

public class EnemyDeathListener
{
    
    [EventHandler(Priority = EventPriority.HIGHEST)]
    public void OnEnemyDeath(CharacterDeathEvent e)
    {
        // Character killer = e.GetKiller();
        // killer.SetHealth(100);
        //
        // Character dead = e.GetCharacter();
        // dead.SetHealth(100);
        // dead.Spawn(new Location(0.0, 0.0 , 0.0));
        Debug.Log("Event Fired");
    }
}
