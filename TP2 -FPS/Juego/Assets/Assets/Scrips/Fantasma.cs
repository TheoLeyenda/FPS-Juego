using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour {
    public static int vidaFantasma = 30;
    public static int fantasmasEliminados = 0;
    private float tiempoMov = 0;
    public float tiempoMovMax = 3;
    private float randomX;
    private float randomZ;
    private float diley = 5;
    public static int puntosPorFantasma = 0;
    private int auxVidaFantasma = 30;
	// Use this for initialization
	void Start () {
        tiempoMov = 3;
        vidaFantasma = 30;
        
	}
	
	// Update is called once per frame
	void Update () {
        diley = diley + Time.deltaTime;
        tiempoMov = tiempoMov + Time.deltaTime;
        if(tiempoMov >= tiempoMovMax)
        {
            randomX = Random.Range(-10, 10);
            randomZ = Random.Range(-10, 10);
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(randomX, 0, randomZ), ForceMode.Acceleration);
        }
        if(auxVidaFantasma<= 0)
        {
            puntosPorFantasma = puntosPorFantasma + 200;
            fantasmasEliminados++;
            Destroy(gameObject);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ENTRE A TRIGGERED");
        if(other.gameObject.tag == "Player" && diley >= 5)
        {
            JugadorColicion.vida = JugadorColicion.vida - 10;
            Debug.Log(JugadorColicion.vida);
        }
        if(other.gameObject.tag == "bala")
        {
            vidaFantasma = vidaFantasma - 10;
            auxVidaFantasma = auxVidaFantasma - 10;
            Debug.Log("vida Fantasma:" + vidaFantasma);
        }
    }
}
