using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    
    private Rigidbody playerRB;
    private Animator playerAM;
    public bool gameover = false;

    private AudioSource playerAudio;
    public AudioClip jump2;
    public AudioClip death;

    //flap variables
    public float flapforce = 10f;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        playerAM = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)  && gameover == false)
        {
            playerRB.AddForce(Vector3.up * flapforce, ForceMode.Impulse);

            playerAudio.PlayOneShot(jump2);
           


        }




    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            Debug.Log("gameover");
            playerAM.SetBool("death", true);
            gameover = true;

            playerAudio.PlayOneShot(death);
        }
      
    }


}
