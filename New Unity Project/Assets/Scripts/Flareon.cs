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

    IEnumerator OnTriggerStay2D(Collider2D col)
    {
        yield return new WaitForSeconds(1f);

        if (col.tag == "Enemigo")
            Debug.Log("POKEMON: "+vida);
            vida = vida - 10;

        if (vida <= 0)
        {
            Enemigo enemigo = FindObjectOfType<Enemigo>();
            enemigo.andar = true;
            Destroy(gameObject);
        }
    } 
    }
