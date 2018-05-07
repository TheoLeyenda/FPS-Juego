using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase04
{
    public class raycastEjemplo : MonoBehaviour
    {
        public GameObject cubo;
        public GameObject cilindro;
        public GameObject esfera;

        public float rotationSpeed = 10;

        public float rayDistance = 10;

        public LayerMask rayCastLayer;

        // Update is called once per frame
        private void Update()
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

            RaycastHit hit;

            if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, rayCastLayer))
            {
                Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);

                string layerHitted = LayerMask.LayerToName(hit.transform.gameObject.layer);

                switch (layerHitted)
                {
                    case "Esferas01":
                        cubo.SetActive(true);
                        cilindro.SetActive(false);
                        esfera.SetActive(false);
                        break;
                    case "Esferas02":
                        cubo.SetActive(false);
                        cilindro.SetActive(true);
                        esfera.SetActive(false);
                        break;
                    case "Esferas03":
                        cubo.SetActive(false);
                        cilindro.SetActive(false);
                        esfera.SetActive(true);
                        break;
                }
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward * rayDistance, Color.white);
            }
        }
    }
}
