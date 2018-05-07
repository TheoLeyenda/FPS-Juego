using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerFantasma : MonoBehaviour {

    // Use this for initialization
    public GameObject fantasma;
    public static int CantCreados;
    private float tiempoGeneracion;
    public float radioDeGeneracion;
    private float randomX;
    private float randomZ;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        tiempoGeneracion = tiempoGeneracion + Time.deltaTime;
        if(tiempoGeneracion>=5)
        {
            randomX = Random.Range(-radioDeGeneracion, radioDeGeneracion);
            randomZ = Random.Range(-radioDeGeneracion, radioDeGeneracion);
            Instantiate(fantasma, new Vector3(transform.position.x + randomX, 2.5f, transform.position.z + randomZ), Quaternion.identity);
            CantCreados++;
            tiempoGeneracion = 0;
        }
	}
}
