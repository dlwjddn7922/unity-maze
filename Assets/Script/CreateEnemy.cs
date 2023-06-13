using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Transform parent;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //time의 기본구조
  
        timer += Time.deltaTime;
        if(timer > 2f)
        {
            timer = 0;
            GameObject obj = Instantiate(enemy,parent);
            obj.name = "Enemy";
            void OnTriggerEnter2D(Collider2D collision)
            {
                if (collision.name == "Player")
                {
                    Destroy(gameObject);
                }
            }
        }
    }
    
}
