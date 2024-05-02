using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class HUD : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public static int score = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + Mathf.Round(Wizard.Instance.Stats.health) + "/" + Wizard.Instance.Stats.MaxHealth;
        manaText.text = "Mana: " + Mathf.Round(Wizard.Instance.Stats.mana) + "/" + Wizard.Instance.Stats.MaxMana;
    }
}
