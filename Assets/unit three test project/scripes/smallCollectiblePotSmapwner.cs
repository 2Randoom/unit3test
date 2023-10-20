using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallPotSpawner : MonoBehaviour
{

    public int smallPotCount;

    public GameObject smallPotSpawnPos;
    public GameObject smallPot;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && smallPotCount > 0)
        {
            Instantiate(smallPot, smallPotSpawnPos.transform.position, smallPotSpawnPos.transform.rotation);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
  
}