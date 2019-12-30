using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject eny;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn",1f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn() {

        StartCoroutine(spawner());
        
    }

    IEnumerator spawner()
    {
        yield return new WaitForSeconds(Random.Range(2,6));
        Instantiate(eny, transform.position, Quaternion.identity);
    }
}
