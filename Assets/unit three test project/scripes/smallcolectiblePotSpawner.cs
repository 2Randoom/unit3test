using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallcolectiblePotSpawner : MonoBehaviour
{
    public GameObject smallPot;
    private playercontroler playercontrolerscript;
    private Vector3 potspawn = new Vector3(0, 0, 0);

    public float ymax = 10f;
    public float ymin = -10f;

    public float startDelay;
    public float reapetrate = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnCollectiblePot", startDelay, reapetrate);
        playercontrolerscript = GameObject.Find("Player").GetComponent<playercontroler>();
        potspawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnCollectiblePot()
    {
        Vector3 potsoawn = new Vector3(
          transform.position.x,
          transform.position.y - Random.Range(ymin, ymax),
          transform.position.z
          );

        Instantiate(smallPot, potspawn, transform.rotation);
    }
}
