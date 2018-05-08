using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCast : MonoBehaviour {
    //PENDIENTE HACER EL RAY CAST PARA EL MATA TRAMPA
    public float danio;
    public float rango;
    public Camera fpsCamara;
    public static int puntaje = 0;
    public static int trampasDestruidas = 0;
    private bool entrar = true;
    public static bool enMatatrampas = true;
    // Use this for initializatio

    // Update is called once per frame
    void Update () {
        if(Input.GetButton("Fire1"))
        {
            Disparo();
        }
	}
    void Disparo()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCamara.transform.position, fpsCamara.transform.forward, out hit, rango))
        {
            if (arma.BalasMataTrampas >= 1 && enMatatrampas)
            {
                if (hit.transform.gameObject.tag == "Trampa")
                {

                    puntaje = puntaje + 100;
                    Destroy(hit.transform.gameObject);

                    trampasDestruidas = trampasDestruidas + 1;

                }
            }
        }

    }
}
