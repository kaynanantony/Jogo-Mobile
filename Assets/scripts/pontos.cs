using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontos : MonoBehaviour
{
    public bolinha bolinha;
   

   public Text valordeponto;



    void Start()
    {
        
    }

     
    void Update()
    {

        valordeponto.text = bolinha.quantia.ToString();
    }
}
