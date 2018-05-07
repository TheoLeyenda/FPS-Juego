using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptControl : MonoBehaviour {

    // Use this for initialization

    private int puntaje = 0;
    private int puntajeFantasma;
    private int puntajeTrampa;
    private int TrampasDestruidas = 0;
    private int TrampasCreadas = 0;
    private int FantasmasCreados = 0;
    private int FantasmasEliminados = 0;
    public Text textPuntaje;
    public Text textTrampasDestruidas;
    public Text textTrampasCreadas;
    public Text textFantasmasCreados;
    public Text textFantasmasEliminados;
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        puntajeTrampa = rayCast.puntaje;
        TrampasDestruidas = rayCast.trampasDestruidas;
        TrampasCreadas = generadorRandomNivel.contador;
        FantasmasCreados = spawnerFantasma.CantCreados;
        FantasmasEliminados = Fantasma.fantasmasEliminados;
        Debug.Log("Trampas Destruidas: " + TrampasDestruidas);
        Debug.Log("Fantasmas Eliminados: " + FantasmasEliminados);
        puntajeFantasma = Fantasma.puntosPorFantasma;
        puntaje = puntajeFantasma + puntajeTrampa;
        Debug.Log("Puntaje: " + puntaje);
        if (JugadorColicion.gameOver == true)
        {
            Debug.Log(JugadorColicion.gameOver);
            textPuntaje.text = "Puntaje: "+puntaje;
            textTrampasDestruidas.text = "Trampas Destruidas:" + TrampasDestruidas;
            textTrampasCreadas.text = "Trampas Creadas:" + TrampasCreadas;
            textFantasmasCreados.text = "Fantasmas Creados:" + FantasmasCreados;
            textFantasmasEliminados.text = "Fantasmas Eliminados:" + FantasmasEliminados;
        }
    }
    
}
