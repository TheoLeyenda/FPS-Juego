using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour {

    public float rango;
    public float danio;
    public GameObject trampa1;

    public Camera fpsCam;
    // Update is called once per frame
    void Update () {
        
        // Trampas = GameObject.FindGameObjectsWithTag("Trampa");
        if (Input.GetButtonDown("Fire1"))
        {
            Disparo();
        }
	}
    void Disparo()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, rango))
        {
            string layerHitted = LayerMask.LayerToName(hit.transform.gameObject.layer);

            switch (layerHitted)
            {
                case "Trampa01":
                    trampa1.SetActive(false);
                    Debug.Log("Trampa1 fuera");
                    break;
            }
        }
    }
}
