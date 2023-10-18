using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    private playercontroler playercontrolerscript;
    private Rigidbody playerRB;
  private Animator playerAM;
    public bool gameover = false;

    //flap variables
    public float flapforce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAM = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)  && gameover == false)
        {
            playerRB.AddForce(Vector3.up * flapforce, ForceMode.Impulse);
           


        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("gameover");
            playerAM.SetBool("death", true);
            gameover = true;
            
        }
      
    }


}
