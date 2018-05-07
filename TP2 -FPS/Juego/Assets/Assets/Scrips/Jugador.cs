using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public GameObject shot;
    public Transform shotSpawn;

    int delay = 10;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(delay);
        if (delay <= 10)
        {
            delay++;
        }
        if (Input.GetButton("Fire1"))
        {

            if (delay >= 10)
            {
                delay = 0;
                Instantiate(shot, shotSpawn.position, shotSpawn.rotation);

            }
        }
    }
    public Transform devolverTranform()
    {
        return shotSpawn;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        //if(collision.gameObject.name)
    }
}
