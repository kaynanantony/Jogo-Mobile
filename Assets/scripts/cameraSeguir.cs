using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSeguir : MonoBehaviour
{
    public GameObject player;
    private Vector3 posicaoI;
    private Vector3 posicaoA;
    

    void Start()
    {
        posicaoI = player.transform.position;
    }

   
    void Update()
    {
        posicaoA = player.transform.position;
        transform.position += (posicaoA - posicaoI);
        posicaoI = player.transform.position;
    }
}
