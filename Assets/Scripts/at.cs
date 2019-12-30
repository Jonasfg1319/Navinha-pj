using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class at : MonoBehaviour
{
    float speed = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("inve", 2f,5f);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed * Time.deltaTime, 0);
    }
    public void inve()
    {

        speed *= -1;

    }

   

}
