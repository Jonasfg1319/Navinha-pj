using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float speed = 4f;
    Rigidbody2D rb;
    public static bool death = false;
    bool freeze = false;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(h * speed,0);

        if (death)
        {
            Destroy(this.gameObject);
            
        }

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("ball"))
        {
            
            death = true;
        }

       

    }
}
