using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Int32 CalculateHealth(Player player)
    {
        // Formula: (resistente * 10) + (level * 4) + 10
        Int32 result = (player.entity.resistence * 10) + (player.entity.level * 4) + 10;
        return result;
    }
}
