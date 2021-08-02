using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Character
{
        double GetHealth();

        void SetHealth(double health);
    
        double GetAttack();

        void SetAttack(double attack);
        
        float GetSpeed();
        
        void SetSpeed(float speed);

        void Spawn(Location location);
}
