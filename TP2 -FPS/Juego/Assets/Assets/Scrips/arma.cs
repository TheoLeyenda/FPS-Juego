using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{

    public static int _puntaje;
    public static int _enemigosDestruidos;
    public GameObject _bullet;
    public GameObject _weaponPos;
    private string _weaponType;
    private int _mtBullets;
    private int _mtClips;
    private int _fBullets;
    private int _fClips;
    public Camera _camera;
    public static Vector3 _cameraLookingAt;

    // Use this for initialization
    void Start()
    {
        _puntaje = 0;
        _enemigosDestruidos = 0;
        _weaponType = "Mata Trampas";
        _mtClips = 8;
        _mtBullets = 7;
        _fBullets = 24;
        _fClips = 16;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(_weaponType);
        Shoot();
        Reload();
        ChangeWeapon();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            switch (_weaponType)
            {
                case "Mata Trampas":
                    RaycastHit hit;
                    if (_mtBullets >= 1)
                    {
                        _mtBullets--;
                        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, 5)
                        &&
                        hit.transform.gameObject.CompareTag("Trampa"))
                        {
                            Destroy(hit.transform.gameObject);
                            //_enemigosDestruidos++;
                            //_puntaje += 100;
                        }
                    }
                    break;
                case "Flowerator":
                    if (_fBullets >= 1)
                    {
                        _bullet = Instantiate(_bullet, gameObject.transform.position + _camera.transform.forward, Quaternion.identity);
                        _cameraLookingAt = _camera.transform.forward;
                        _fBullets--;
                    }

                    break;
                default:
                    break;
            }
        }
    }//Dispara el arma equipada
    void Reload()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            switch (_weaponType)
            {
                case "Mata Trampas":
                    if (_mtClips >= 1)
                    {
                        _mtBullets = 7;
                        _mtClips--;
                    }
                    break;
                case "Flowerator":
                    if (_fClips >= 1)
                    {
                        _fBullets = 24;
                        _fClips--;
                    }
                    break;
                default:
                    break;
            }
        }
    }//Recarga el arma equipada
    void ChangeWeapon()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _weaponType = "Mata Trampas";
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _weaponType = "Flowerator";
        }
    }//Cambia las armas con los botones 1 y 2
}
