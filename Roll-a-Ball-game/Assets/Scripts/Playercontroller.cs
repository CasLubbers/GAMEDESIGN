using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    private int count;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject jumppad1;
    public GameObject wall3;
    public GameObject elephant;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveHorizontal, 0, -moveVertical);
        
        rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            Destroy(wall1);
        }
        else if (other.gameObject.CompareTag("Jumppad"))
        {
            gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
           
            rb.AddForce(0, 9, 0, ForceMode.Impulse);
            
        }
        else if (other.gameObject.CompareTag("Pick up 2"))
        {
            other.gameObject.SetActive(false);
            Destroy(wall2);
        }
        else if (other.gameObject.CompareTag("Pick up 3"))
        {
            other.gameObject.SetActive(false);
            jumppad1.SetActive(true);
        } 
        else if (other.gameObject.CompareTag("Pick up 4"))
        {
            other.gameObject.SetActive(false);
            Destroy(wall3);
        }
        else if (other.gameObject.CompareTag("Pick up 5"))
        {
            other.gameObject.SetActive(false);
            count++;
        }
        if (count == 5)
        {
            elephant.AddComponent<Rigidbody>();
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    
    }

    private void Update()
    {
        if (transform.position.y < -5)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
