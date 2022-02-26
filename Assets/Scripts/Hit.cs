﻿using UnityEngine;

public class Hit : MonoBehaviour
{
    public float Damage { get; private set; }
    
    private void Awake()
    {
        Damage = 10;
    }

    public void ToHit(Player player)
    {
        if (player.GetComponentInChildren<HealthBar>()._isCoroutineRunning == false)
        {
            player.TakeDamage(Damage);
        }
    }
}