using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public TMP_Text playername;
    public TMP_Text levelanzeige;
    public TMP_Text erfahrungspunkte;
    public TMP_Text skillPoint;
    public TMP_Text scoreText;
    public TMP_Text healthText;
    public TMP_Text manaText;
    public Image manaImage;
    public Image healthImage;
    public Image expImage;
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
        erfahrungspunkte.text = "Erfahrungspunkte:";
        playername.text = "Name: " + namePlayer;
        scoreText.text = "Score: " + score;
        healthText.text = "Health: " + Mathf.Round(Wizard.Instance.Stats.health) + "/" + MaxHealth;
        manaText.text = "Mana: " + Mathf.Round(Wizard.Instance.Stats.mana) + "/" + MaxMana;
        if(Wizard.Instance.Stats.skillPoints > 0){
            skillPoint.text = "Skill Punkte: " + Wizard.Instance.Stats.skillPoints;
        } else {
            skillPoint.text = "";
        }
        
        float manaPercantage = Wizard.Instance.Stats.mana / MaxMana;
        manaImage.transform.localScale = new Vector3(manaPercantage, 1,1 );

        float healthPercantage = Wizard.Instance.Stats.health / MaxHealth;
        healthImage.transform.localScale = new Vector3(healthPercantage, 1,1 );

        float expPercantage = Wizard.Instance.Stats.erfahrungspunkt / Wizard.Instance.Stats.needForLevel;
        expImage.transform.localScale = new Vector3(expPercantage, 1,1 );

    }
}
