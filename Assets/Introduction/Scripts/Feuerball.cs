using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Feuerball : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 direction = Vector3.up;
    void Start()
    {
        Destroy(gameObject, 3);
        float angle = Vector3.Angle(Vector3.right, direction);

        if(direction.y < 0){
            angle = angle*-1;

        }
        transform.Rotate(new Vector3(0, 0, angle));
        transform.position = transform.position + direction * 2;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direction * Time.deltaTime * 4;
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Player")
        {
            return;
        }
        Destroy(gameObject);
    }
}
