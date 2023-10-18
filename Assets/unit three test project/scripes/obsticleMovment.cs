using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class obsticleMovment : MonoBehaviour
{
    private playercontroler playercontrolerscript;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        playercontrolerscript = GameObject.Find("Player").GetComponent<playercontroler>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playercontrolerscript.gameover == false)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
       
    }
    
}
