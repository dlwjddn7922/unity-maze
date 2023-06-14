using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public Transform parent;
    float timer;
    public bool isPlay = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > 2f)
        {

            timer = 0;
            GameObject obj = Instantiate(enemy, parent);
            obj.name = "Enemy";

        }
    }

}