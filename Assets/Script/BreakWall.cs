using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakWall : MonoBehaviour
{
    public Key k;
    public bool isbool = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(k != isbool)
        {
            //gameObject.SetActive(false);
            gameObject.GetComponent<Transform>().position -= (new Vector3(0, 2f, 0));

        }
    }
    
}
