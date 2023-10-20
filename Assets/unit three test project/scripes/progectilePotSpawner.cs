using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.Arm;

public class progectilePotSpawner : MonoBehaviour
{

    public GameObject progectile;
    public GameObject progectileSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Instantiate the shovel


            Instantiate(progectile, progectileSpawn.transform.position, progectileSpawn.transform.rotation);
        }
    }
}
