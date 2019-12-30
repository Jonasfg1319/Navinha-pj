using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
     Text txt;
    public static int temp = 0;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = GameMan.pontos.ToString() + " Pontos";

        if (Input.GetKeyDown(KeyCode.X)) {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Player.death = false;
            if (GameMan.pontos > temp)
            {
                temp = GameMan.pontos;
            }
            GameMan.pontos = 0;
            SceneManager.LoadScene("Game");
            
        }
    }


}
