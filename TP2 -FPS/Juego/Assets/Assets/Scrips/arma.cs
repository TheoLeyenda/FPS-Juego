using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    public GameObject bala;
    public GameObject armaEnUso;
    private string TipoArma;
    private int BalasMataTrampas;
    private int ClipsMataTrampas;
    private int BalasArmaFlores;
    private int ClipsArmaFlores;
    public Camera camara;
    public static Vector3 VistaCamara;

    // Use this for initialization
    void Start()
    {
       
        TipoArma = "Mata Trampas";
        ClipsMataTrampas = 8;
        BalasMataTrampas = 7;
        BalasArmaFlores = 24;
        ClipsArmaFlores = 16;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TipoArma);
        Shoot();
        Reload();
        ChangeWeapon();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            switch (TipoArma)
            {
                case "Mata Trampas":
                    RaycastHit hit;
                    if (BalasMataTrampas >= 1)
                    {
                        BalasMataTrampas--;
                        if (Physics.Raycast(camara.transform.position, camara.transform.forward, out hit, 5)
                        &&
                        hit.transform.gameObject.CompareTag("Trampa"))
                        {
                            Destroy(hit.transform.gameObject);
                        }
                    }
                    break;
                case "Mata Fantasmas":
                    if (BalasArmaFlores >= 1)
                    {
                        bala = Instantiate(bala, gameObject.transform.position + camara.transform.forward, Quaternion.identity);
                        VistaCamara = camara.transform.forward;
                        BalasArmaFlores--;
                    }

                    break;
                default:
                    break;
            }
        }
    }//DISPARA EL ARMA QUE ESTEMOS USANDO
    void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            switch (TipoArma)
            {
                case "Mata Trampas":
                    if (ClipsMataTrampas >= 1)
                    {
                        BalasMataTrampas = 7;
                        ClipsMataTrampas--;
                    }
                    break;
                case "Mata Fantasmas":
                    if (ClipsArmaFlores >= 1)
                    {
                        BalasArmaFlores = 24;
                        ClipsArmaFlores--;
                    }
                    break;
                default:
                    break;
            }
        }
    }//RECARGA EL ARMA QUE ESTEMOS USANDO
    void ChangeWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TipoArma = "Mata Trampas";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TipoArma = "Mata Fantasmas";
        }
    }
}
