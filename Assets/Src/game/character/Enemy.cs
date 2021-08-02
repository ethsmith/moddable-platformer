using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, NPC
{
    private double _health;

    private double _attack;

    private float _speed;

    private List<Character> _targets;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public double GetHealth()
    {
        return _health;
    }

    public void SetHealth(double health)
    {
        _health = health;
    }

    public double GetAttack()
    {
        return _attack;
    }

    public void SetAttack(double attack)
    {
        _attack = attack;
    }

    public float GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(float speed)
    {
        _speed = speed;
    }
    
    public void Spawn(Location location)
    {
        throw new System.NotImplementedException();
    }

    public List<Character> GetTargets()
    {
        return _targets;
    }

    public void SetTargets(List<Character> targets)
    {
        _targets = targets;
    }
}
