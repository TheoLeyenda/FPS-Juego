using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchBoton : MonoBehaviour {

    public Button boton;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void cargarJuego()
    {
        boton.gameObject.SetActive(false);
        SceneManager.LoadScene("Juego");
    }
    public void cargarMenu()
    {
        boton.gameObject.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
    public void cargarPantallaFinal()
    {
        boton.gameObject.SetActive(false);
        SceneManager.LoadScene("Pantalla Final");
    }
}
