using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolinha : MonoBehaviour
{
    Rigidbody rb;

    public float speed = 5;
    public float buffdespeed = 4f;
    public float timer = 8;
    public float vida = 3;
    public Vector3 posicaoPlayer;
    public GameObject posicaodePartida;
    private bool checktimer = false;

    public float quantia;
    public GameObject moeda;


 


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
        posicaoPlayer = transform.position;
        if (posicaoPlayer.y < -0.2) 
        {
            transform.position = posicaodePartida.transform.position;
            vida--;
            if (vida <= 0) 
            {


            }
        }
        if (checktimer)
        {
            timer -= Time.deltaTime;


            if (timer<=0)
            {
                speed = speed / buffdespeed;
                timer = 8;
                checktimer = false;
                
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin") 
        {
            quantia++;
            Destroy(other.gameObject);
        }
        if (other.tag == "buff") 
        {
            speed = speed * buffdespeed;
            Destroy(other.gameObject);
            checktimer = true;
            

        }
    }


}
