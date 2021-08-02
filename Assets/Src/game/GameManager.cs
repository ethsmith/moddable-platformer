using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static readonly List<object> Events = new List<object>();
    
    // Start is called before the first frame update
    void Start()
    {
        //RegisterEvents(new EnemyDeathListener());
        FireEvent(new CharacterDeathEvent(null, null));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public static void RegisterEvents(params object[] events)
    {
        foreach (var e in events)
        {
            Events.Add(e);
        }
    }

    public static void FireEvent(Event type)
    {
        handleCustomListeners(type);
        handleGameListeners(type);
    }

    private static void handleCustomListeners(Event type)
    {
        foreach (var e in Events)
        {
            var potentialListeners = e.GetType().GetMethods();
            foreach (var potentialListener in potentialListeners)
            {
                var paramLength = potentialListener.GetParameters().Length;
                if (paramLength > 1 || paramLength == 0)
                    continue;
                
                if (!potentialListener.GetCustomAttributes(typeof(EventHandler)).Any()) continue;
                if (!potentialListener.GetParameters()[0].ParameterType.IsInstanceOfType(type)) continue;

                object[] parameters = {type};
                potentialListener.Invoke(e, parameters);
            }
        }
    }

    private static void handleGameListeners(Event type)
    {
        if (type.IsCancelled()) return;
        switch (type.GetType().FullName)
        {
            case "CharacterDeathEvent":
                new EnemyDeathListener().OnEnemyDeath((CharacterDeathEvent) type);
                break;
            case "CharacterDamageEvent":
                break;
            case "CharacterMoveEvent":
                break;
            case "CharacterSpawnEvent":
                break;
        }
    }
}
