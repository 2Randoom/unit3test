using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class obsticleMovment : MonoBehaviour
{
    private playercontroler playercontrolerscript;
    public float speed = 15f;
    public float lifetime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //it gets the playercontroler script
        playercontrolerscript = GameObject.Find("Player").GetComponent<playercontroler>();
        //after 10seconds inploy the barrelDie method
        Invoke("barrelDie", lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        //it moves untelthe game ends
        if(playercontrolerscript.gameover == false)
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
       
    }
    //destroy this gameObject
    void barrelDie()
    {
          Destroy(gameObject);
    }

}
