using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speedy = -10f;
    float speedx = 20f;
    bool invers = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speedx * Time.deltaTime, speedy * Time.deltaTime);

        if (invers)
        {
            inve();
            invers = false;
        }

    }

    public void inve() {

        speedx *= -1;
        
    }


    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.CompareTag("bottom"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("lad"))
        {
            invers = true;
        }
        if (other.gameObject.CompareTag("shoot"))
        {
            GameMan.pontos += 10;
            Destroy(this.gameObject);
        }
    }

    

}
