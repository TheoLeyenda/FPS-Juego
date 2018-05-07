using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fantasma : MonoBehaviour {
    public static int vidaFantasma = 30;
    public static int fantasmasEliminados = 0;
    private float tiempoMov = 0;
    private float tiempoMovMax = 4;
    private float randomX;
    private float randomZ;
    private float diley = 5;
    private float diley1 = 5;
    private float diley2 = 5;
    private float diley3 = 5;
    private float diley4 = 5;
    public static int puntosPorFantasma = 0;
    private int auxVidaFantasma = 30;
    private bool entroPared1 = false;
    private bool entroPared2 = false;
    private bool entroPared3 = false;
    private bool entroPared4 = false;
	// Use this for initialization
	void Start () {
        tiempoMov = 4;
        vidaFantasma = 30;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (diley1 <= 5)
        {
            diley1 = diley1 + Time.deltaTime;
        }
        if (diley2 <= 5)
        {
            diley2 = diley2 + Time.deltaTime;
        }
        if (diley3 <= 5)
        {
            diley3 = diley3 + Time.deltaTime;
        }
        if (diley4 <= 5)
        {
            diley4 = diley4 + Time.deltaTime;
        }
        if (tiempoMov <= 4)
        {
            tiempoMov = tiempoMov + Time.deltaTime;
        }
        
        if(tiempoMov >= tiempoMovMax)
        {
            randomX = Random.Range(-5, 5);
            randomZ = Random.Range(-5, 5);
            //gameObject.GetComponent<Rigidbody>().velocity = new Vector3(randomX, 0, randomZ);
            tiempoMov = 0;
        }
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(randomX, 0, randomZ);
        if (entroPared1 && diley1> 5)
        {
            randomZ = randomZ * -1;
            randomX = randomX * -1;
            diley1 = 0;
            
        }
        if (entroPared2 && diley2 > 5)
        {
            randomZ = randomZ * -1;
            randomX = randomX * -1;
            diley2 = 0;
        }
        if (entroPared3 && diley3 > 5)
        {
            randomZ = randomZ * -1;
            randomX = randomX * -1;
            diley3 = 0;
        }
        if (entroPared4 && diley4 > 5)
        {
            randomZ = randomZ * -1;
            randomX = randomX * -1;
            diley4 = 0;
        }
        if (auxVidaFantasma<= 0)
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
        if(other.gameObject.tag == "pared1")
        {
            
            entroPared1 = true;
            entroPared2 = false;
            entroPared3 = false;
            entroPared4 = false;
            
            
        }
        if (other.gameObject.tag == "pared2")
        {
            
            entroPared1 = false;
            entroPared2 = true;
            entroPared3 = false;
            entroPared4 = false;
            
            
        }
        if (other.gameObject.tag == "pared3")
        {
            entroPared1 = false;
            entroPared2 = false;
            entroPared3 = true;
            entroPared4 = false;
        }
        if (other.gameObject.tag == "pared4")
        {
            entroPared1 = false;
            entroPared2 = false;
            entroPared3 = false;
            entroPared4 = true;
            
        }
    }
}
