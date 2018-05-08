using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    public GameObject bala;
    public GameObject armaEnUso;
    public static string TipoArma;
    public static int BalasMataTrampas;
    public static int ClipsMataTrampas;
    public static int BalasArmaFlores;
    public static int ClipsArmaFlores;
    public Camera camara;
    public static Vector3 VistaCamara;

    // Use this for initialization
    void Start()
    {
       
        TipoArma = "Mata Trampas";
        ClipsMataTrampas = 96;
        BalasMataTrampas = 12;
        BalasArmaFlores = 20;
        ClipsArmaFlores = 120;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(TipoArma);
        Shoot();
        Reload();
        ChangeWeapon();
    }
    //DISPARA EL ARMA QUE ESTEMOS USANDO
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
                        if (Physics.Raycast(camara.transform.position, camara.transform.forward, out hit, 5) && hit.transform.gameObject.CompareTag("Trampa"))
                        {
                            Destroy(hit.transform.gameObject);
                        }
                    }
                    break;
                case "Flowerator":
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
    }
    //----------------------------------------

    //RECARGA EL ARMA QUE ESTEMOS USANDO
    void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            switch (TipoArma)
            {
                case "Mata Trampas":
                    if (ClipsMataTrampas > 0)
                    {
                        BalasMataTrampas = 12;
                        ClipsMataTrampas = ClipsMataTrampas -12;
                    }
                    else
                    {
                        ClipsMataTrampas = 0;
                    }
                    break;
                case "Flowerator":
                    if (ClipsArmaFlores > 0)
                    {
                        BalasArmaFlores = 20;
                        ClipsArmaFlores = ClipsArmaFlores - 20;
                    }
                    else
                    {
                        ClipsArmaFlores = 120;
                        
                    }
                    break;
                default:
                    break;
            }
        }
    }
    //----------------------------------------

     //CAMBIA EL ARMA
    void ChangeWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            TipoArma = "Mata Trampas";
            rayCast.enMatatrampas = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TipoArma = "Flowerator";
            rayCast.enMatatrampas = false;
        }
    }
    //-----------------------------------
}
