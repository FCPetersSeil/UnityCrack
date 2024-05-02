using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Playerstats
{
    public float movementspeed = 2.0f;
    public float fireRate = 2.0f;

    public float MaxHealth = 100f;
    public float MaxMana = 100f;
    public float health = 100f;
    public float mana = 100f; 
    public float healthRegen = Time.deltaTime * 0.25f;
    public float manaRegen = Time.deltaTime * 0.75f;
    
}
