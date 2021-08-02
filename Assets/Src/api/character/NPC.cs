using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface NPC : Character
{
    List<Character> GetTargets();

    void SetTargets(List<Character> targets);
}
