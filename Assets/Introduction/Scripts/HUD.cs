using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public TMP_Text playername;
    public TMP_Text levelanzeige;
    public TMP_Text erfahrungspunkte;
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public static int score = 0;
    public string namePlayer = "";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Wizard w = Wizard.Instance;
        Playerstats s = w.Stats;
        float MaxMana = s.MaxMana;
        int MaxHealth = s.MaxHealth;

        levelanzeige.text = "Level: " + Wizard.Instance.Stats.level;
        erfahrungspunkte.text = "Erfahrungspunkte: \n" + Wizard.Instance.Stats.erfahrungspunkt;
        playername.text = "Name: " + namePlayer;
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + Mathf.Round(Wizard.Instance.Stats.health) + "/" + MaxHealth;
        manaText.text = "Mana: " + Mathf.Round(Wizard.Instance.Stats.mana) + "/" + MaxMana;
    }
}
