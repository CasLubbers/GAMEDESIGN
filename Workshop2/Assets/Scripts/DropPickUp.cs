using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPickUp : MonoBehaviour
{
    public Material playerMaterial;
    public GameObject box;
    public GameObject cylinder;
    public GameObject sphere;
    public GameObject ground;


    private int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(count == 0)
            {
                ground.gameObject.GetComponent<Renderer>().material.SetColor("_Color", other.gameObject.GetComponent<Renderer>().material.color);
            }
            if (count == 1)
            {
                box.gameObject.GetComponent<Renderer>().material.SetColor("_Color", other.gameObject.GetComponent<Renderer>().material.color);
            }
            if (count == 2)
            {
                cylinder.gameObject.GetComponent<Renderer>().material.SetColor("_Color", other.gameObject.GetComponent<Renderer>().material.color);
            }
            if (count == 3)
            {
                sphere.gameObject.GetComponent<Renderer>().material.SetColor("_Color", other.gameObject.GetComponent<Renderer>().material.color);
            }
            other.gameObject.GetComponent<Renderer>().material.SetColor("_Color", playerMaterial.color);
            count++;
        }
    }
}
