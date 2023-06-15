using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Transform parent = transform.parent;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.localScale.y >= 1.91f && transform.localScale.y <= 4.11f)
        {
            transform.localScale += (new Vector3(0, 2f, 0) * Time.deltaTime * 2f);
            
        }
        if (transform.localScale.y >= 4.1f)
        {
            transform.localScale -= (new Vector3(0, 2f, 0) * Time.deltaTime * 2f);
        }



    }
}
