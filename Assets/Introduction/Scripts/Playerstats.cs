using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Playerstats
{
    public float movementspeed = 2.0f;
    public float fireRate = 1.5f;

    public int MaxHealth = 100;
    public float MaxMana = 100f;
    public int health = 100;
    public float mana = 100f; 
    public float healthRegen = Time.deltaTime * 0.1f;
    public float manaRegen = Time.deltaTime * 0.3f;
    public float fireballDamage = 10f;

    public int targetDestroyed = 0;

    public int erfahrungspunkt = 0;
    public int level = 1;

    public void LevelUp()
    {
        level++;
        fireRate -= 0.05f;
        MaxHealth += 10;
        MaxMana += 10f;
    }    
    
    public void GainXP(int xp)
    {
        targetDestroyed += xp;
        erfahrungspunkt++;
        if (targetDestroyed == 10){
            LevelUp();
            targetDestroyed = 0;            
        }
    } 

    
}
