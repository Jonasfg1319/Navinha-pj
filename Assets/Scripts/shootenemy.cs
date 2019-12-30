using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootenemy : MonoBehaviour
{
    public Transform st;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void shoot()
    {
        StartCoroutine(sp());
    }

    IEnumerator sp()
    {
        yield return new WaitForSeconds(Random.Range(2, 6));
        Instantiate(st, transform.position, Quaternion.identity);
    }
}
