using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject == false)
        {

        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Player")
        {
            Destroy(gameObject);
            
        }

    }
}
