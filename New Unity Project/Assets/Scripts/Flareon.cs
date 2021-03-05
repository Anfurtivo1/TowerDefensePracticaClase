using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flareon : MonoBehaviour
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

    void OnTriggerStay2D(Collider2D col)
    {
        
        if (col.tag == "Enemigo")
        {
            vida = vida - 10;
            Debug.Log("Pokemon: "+vida);

            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
        System.Threading.Thread.Sleep(2000);
    }
}
