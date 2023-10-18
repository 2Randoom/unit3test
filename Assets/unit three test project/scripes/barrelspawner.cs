using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrelspawner : MonoBehaviour
{
    private playercontroler playercontrolerscript;
    public GameObject redBarrel;
    private Vector3 spawnpos = new Vector3(0, 0, 0);
   
    public float ymax = 10f;
    public float ymin= -10f;

    public float startDelay;
    public float reapetrate = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
       
        InvokeRepeating("spawnbarrels", startDelay, reapetrate);
        playercontrolerscript = GameObject.Find("Player").GetComponent<playercontroler>();
        spawnpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void spawnbarrels()
    {
        if (GameObject.Find("Player").GetComponent<playercontroler>().gameover)
        {
            CancelInvoke();
        }
        Vector3 spawnpos = new Vector3(
            transform.position.x,
            transform.position.y + Random.Range(ymin, ymax),
            transform.position.z 
            );
        
            Instantiate(redBarrel, spawnpos, transform.rotation);
         
    }
    
}



