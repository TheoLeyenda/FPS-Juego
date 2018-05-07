using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JugadorColicion : MonoBehaviour {

    // Use this for initialization
    public static int vida = 100;
    public static bool gameOver;
    public GameObject jugador;
    public Rigidbody rgJugador;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(posTrampa.getVectorTrampa());
        if (vida <= 0)
        {
            //DestroyImmediate(jugador, true);
            //pantalla de game over
            gameOver = true;
            SceneManager.LoadScene("Pantalla Final");

        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        //COLICION CON TRAMPAS COMUNES
        if(collision.gameObject.tag == "Trampa")
        {
            Debug.Log("entre");
            vida = vida - 50;
            TiraAtras();
        }
        //COLICION CON TRAMPA COMPUESTA
        if (collision.gameObject.tag == "PINCHOS TRASERA")
        {
            Vector3 posicion = transform.position;
            posicion.z = posicion.z - 2;
            vida = vida - 50;
            transform.position = posicion;
            Debug.Log("ENTRE TRASERA");
            //+z
        }
        if (collision.gameObject.tag == "PINCHOS DERECHA")
        {
            Vector3 posicion = transform.position;
            posicion.x = posicion.x - 2;
            vida = vida - 50;
            transform.position = posicion;
            Debug.Log("ENTRE DERECHA");
            //+x
        }
        if (collision.gameObject.tag == "PINCHOS IZQUIERDA")
        {
            Vector3 posicion = transform.position;
            posicion.x = posicion.x + 2;
            vida = vida - 50;
            transform.position = posicion;
            Debug.Log("ENTRE IZQUIERDA");
            //-x;
        }
        if (collision.gameObject.tag == "PINCHOS DELANTERA")
        {
            Vector3 posicion = transform.position;
            posicion.z = posicion.z + 2;
            vida = vida - 50; 
            transform.position = posicion;
            Debug.Log("ENTRE DELANTERA");
            //-z;
        }
    }
    public void TiraAtras()
    {
        Vector3 posicion = transform.position;
        posicion.y = posicion.y +8;
        //posicion.z = posicion.z + 2;

        transform.position = posicion;
        //Vector3 posicion = posTrampa.getVectorTrampa();
        
        //rgJugador.AddExplosionForce(10,)
       //HACER addForce
    }

}
