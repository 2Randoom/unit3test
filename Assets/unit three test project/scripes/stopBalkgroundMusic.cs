using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopBalkgroundMusic : MonoBehaviour
{
    public AudioSource AS;
    private playercontroler playercontrolerscript;
    // Start is called before the first frame update
    void Start()
    {
        playercontrolerscript = GameObject.Find("Player").GetComponent<playercontroler>();
    }

    // Update is called once per frame
    void Update()
    {
        //stop playing balkground music if the game ends 
        if (playercontrolerscript.gameover == true)
        {
            AS.Stop();
        }
    }
}
