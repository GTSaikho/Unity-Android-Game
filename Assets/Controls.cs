using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{

    private RaycastHit tocado;
    private GameObject toque;
    public GameObject Shield;
    public GameObject ShieldFront;
    public GameObject Slash;

    // Start is called before the first frame update
    void Start()
    {
        ShieldFront.SetActive(false);
        Slash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out tocado))
            {
                toque = tocado.collider.gameObject;
                                                              
                switch (toque.name)
                {
                    case "LeftT":
                        Shield.SetActive(true);
                        Shield.transform.position = new Vector3(-3.5f, 1, 0);
                        Shield.transform.rotation = Quaternion.Euler(0, 0, 180);
                        ShieldFront.SetActive(false);
                        break;

                    case "RightT":
                        Shield.SetActive(true);
                        Shield.transform.position = new Vector3(3.2f, 1, 0);
                        Shield.transform.rotation = Quaternion.Euler(0, 0, 0);
                        ShieldFront.SetActive(false);
                        break;

                    case "UpT":
                        Shield.SetActive(true);
                        Shield.transform.position = new Vector3(-0.1f, 4.5f, 0);
                        Shield.transform.rotation = Quaternion.Euler(0, 0, 90);
                        ShieldFront.SetActive(false);
                        break;

                    case "DownT":

                        Shield.SetActive(true);
                        Shield.transform.position = new Vector3(-0.1f, -2.5f, 0);
                        Shield.transform.rotation = Quaternion.Euler(0, 0, -90);
                        ShieldFront.SetActive(false);                        
                        break;

                    case "":
                        ShieldFront.SetActive(true);
                        Shield.SetActive(false);
                        break;


                }

            }
        }

    }
}
