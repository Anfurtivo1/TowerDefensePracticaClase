using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blastoise : MonoBehaviour
{
    public int vida;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void recibirAtaque()
    {
        vida = vida - 1;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
