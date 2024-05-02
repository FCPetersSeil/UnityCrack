using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class target : MonoBehaviour
{
    public GameObject targetPrefab;
    
    void Start()
    {
        //Destroy(gameObject, 8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {

        if (collision2D.gameObject.tag == "Projectile")
        {
            float x = 15.6f * Random.value - 7.8f;
            float y = 8f* Random.value - 4f;
            Instantiate(targetPrefab, new Vector3(x,y, 0f), Quaternion.identity);
            Destroy(gameObject);
            HUD.score += 1;
        }
    }
}
