using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupComponent : MonoBehaviour
{
    public Material playerMaterial;

    private void OnTriggerEnter(Collider other)
    {
        Material otherMaterial = other.gameObject.GetComponent<Renderer>().material;
        if (other.gameObject.CompareTag("Player") && (otherMaterial.color == playerMaterial.color))
        {
            gameObject.SetActive(false);
            otherMaterial.color = gameObject.GetComponent<Renderer>().material.color; //.SetColor("_Color", gameObject.GetComponent<Renderer>().material.color);
            //gameObject.transform.SetParent(other.gameObject.transform, false);
        }
    }
}
