using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += (new Vector3(x, y, 0f) * Time.deltaTime * 5);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Wall")
        {
            Destroy(gameObject);
        }
        if (collision.name == "Enemy")
        {
            Destroy(gameObject);
        }
       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTrigger[Stay]2D");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTrigger[Exit]2D");
    }
}