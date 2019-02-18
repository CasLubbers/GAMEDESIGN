using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : MonoBehaviour
{

    public Rigidbody Player;
    public int speed;
    public Material material;
    public GameObject healthbar;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }
    
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        transform.LookAt(Player.transform);
    }

    void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.name == "Mock player")
        {
            material.color = Color.red;
            Debug.Log("ATTACK");
            // healthbar - 1
        }
    }

    private void OnCollisionExit(Collision player)
    {
        material.color = Color.white;
    }

 
}
