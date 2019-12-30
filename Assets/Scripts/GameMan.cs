using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameMan : MonoBehaviour
{
    public Text life;
    public Text pts;
    public static int vidas = 1;
    public static int pontos = 0;
    public static int recordes = 0;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        life.text = vidas.ToString();
        pts.text = pontos.ToString();
        score.text = recordes.ToString();
        if(Player.death == true)
        {
            SceneManager.LoadScene("Ending");
        }

        if(EndScreen.temp > recordes)
        {
            recordes = EndScreen.temp;
        }
    }
}
