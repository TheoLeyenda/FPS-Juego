using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generadorRandomNivel : MonoBehaviour
{

    // Use this for initialization
    private float timer = 10;
    private float randomX;
    private float randomZ;
    private int frame;
    private int random;
    private int cantInstanciar;
    private int variableRandom;

    public GameObject nivel0;
    public GameObject nivel1;
    public GameObject nivel2;
    public GameObject nivel3;
    public GameObject nivel4;
    public GameObject nivel5;
    public GameObject nivel6;
    public GameObject nivel7;
    public GameObject nivel8;
    public GameObject Jugador;

    public GameObject trampa1;
    public GameObject trampa2;
    public GameObject trampa3;

    public GameObject SpawnerFantasma; 

    private GameObject[] niveles = new GameObject[9];
    private int[] registro = new int[10];
    public static int contador = 0;
    //public int maximoTrampas;
    bool entre1;
    bool entre2;
    bool entre3;
    bool entre4;
    bool entre5;
    bool entre6;
    bool entre7;
    bool entre8;
    bool entre9;

    //HACER LAS 9 POCIBLES CONVINACIONES DE CORDENADAS DE LOS NIVELES  (LLUVIA DE ifs INMINENTE ACERCANDOSE)
    void Start()
    {
        entre1 = false;
        entre2 = false;
        entre3 = false;
        entre4 = false;
        entre5 = false;
        entre6 = false;
        entre7 = false;
        entre8 = false;
        entre9 = false;
        niveles[0] = nivel0;
        niveles[1] = nivel1;
        niveles[2] = nivel2;
        niveles[3] = nivel3;
        niveles[4] = nivel4;
        niveles[5] = nivel5;
        niveles[6] = nivel6;
        niveles[7] = nivel7;
        niveles[8] = nivel8;
        variableRandom = 9;
        cantInstanciar = 0;

        Jugador = Instantiate(Jugador, new Vector3(-0.67f, 0.92f, -8.5f), Quaternion.identity);
        randomX = Random.Range(-26, 25);
        randomZ = Random.Range(-35, 18);
        Instantiate(SpawnerFantasma, new Vector3(randomX, 2.319f, randomZ), Quaternion.identity);
        
        while (cantInstanciar <=9)
         {
           
            random = Random.Range(0, variableRandom);
            //Debug.Log("cant Instanciados:"+cantInstanciar);
           // Debug.Log("random:"+random);
            if (niveles[random] != null && cantInstanciar == 0)
            {
               // Debug.Log("entre 1");
                Instantiate(niveles[random], new Vector3(-0.67f, 0.92f, -8.5f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 1;
                entre1 = true;
            }
            if (niveles[random] != null && cantInstanciar == 1 )
            {
               // Debug.Log("entre 2");
                Instantiate(niveles[random], new Vector3(19.23f, 0.92f, -8.73f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 2;
                entre2 = true;
            }
            if (niveles[random] != null && cantInstanciar == 2)
            {
               // Debug.Log("entre 3");
                Instantiate(niveles[random], new Vector3(19.23f, 0.92f, -28.04f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 3;
                entre3 = true;
            }
            if (niveles[random] != null && cantInstanciar == 3)
            {
               // Debug.Log("entre 4");
                Instantiate(niveles[random], new Vector3(-0.67f, 0.92f, -28.23f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 4;
                entre4 = true;
            }
            if (niveles[random] != null && cantInstanciar == 4)
            {
               // Debug.Log("entre 5");
                Instantiate(niveles[random], new Vector3(-20.18f, 0.92f, -28.17f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 5;
                entre5 = true;
            }
            if (niveles[random] != null && cantInstanciar == 5)
            {
               // Debug.Log("entre 6");
                Instantiate(niveles[random], new Vector3(-20.18f, 0.92f, -8.67f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 6;
                entre6 = true;
            }
            if (niveles[random] != null && cantInstanciar == 6)
            {
               // Debug.Log("entre 7");
                Instantiate(niveles[random], new Vector3(-20.18f, 0.92f, 11.21f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 7;
                entre7 = true;
            }
            if (niveles[random] != null && cantInstanciar == 7)
            {
               // Debug.Log("entre 8");
                Instantiate(niveles[random], new Vector3(-0.7f, 0.92f, 11.21f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 8;
                entre8 = true;
            }
            if (niveles[random] != null && cantInstanciar == 8)
            {
               // Debug.Log("entre 9");
                Instantiate(niveles[random], new Vector3(19.23f, 0.92f, 11.21f), Quaternion.identity);
                niveles[random] = null;
                cantInstanciar = 9;
                entre9 = true;
            }
            if (entre9)
            {

                cantInstanciar = 10;
            }

        }
    }
    // Update is called once per frame
    void Update()
    {
       // if (contador < maximoTrampas)
       // {
            timer = timer + Time.deltaTime;
            
            if (timer >= 10 && timer < 10 + Time.deltaTime)
            {
                //TRAMPAS ARRIBA DEERECHA

                randomZ = Random.Range(-35, 18);
                randomX = Random.Range(25, -26);
                Instantiate(trampa1, new Vector3(randomX, 1, randomZ), Quaternion.identity);
                Debug.Log("Trampa "+(contador+1)+": X=" + randomX + " Z=" + randomZ);
                contador++;
            }
            if (timer >= 20 && timer < 20 + Time.deltaTime)
            {
                randomZ = Random.Range(-35, 18);
                randomX = Random.Range(25, -26);
                Instantiate(trampa2, new Vector3(randomX, 1, randomZ), Quaternion.identity);
                Debug.Log("Trampa " + (contador + 1) + ": X=" + randomX + " Z=" + randomZ);
                contador++;
            }
            //TRAMPAS ARRIBA IZQUIERDA
            if (timer >= 30 && timer < 30 + Time.deltaTime)
            {
                randomZ = Random.Range(-35, 18);
                randomX = Random.Range(25, -26);
                Instantiate(trampa3, new Vector3(randomX, 6.5f, randomZ), Quaternion.identity);
                Debug.Log("Trampa " + (contador + 1) + ": X=" + randomX + " Z=" + randomZ);
                timer = 0;
                contador++;
            }
      //  } 
    }
}
