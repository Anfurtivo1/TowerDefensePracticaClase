using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad;
    public int vida;
    public bool andar = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (andar)
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
            if (col.tag == "Pokemon")
            {
                //yield return new WaitForSeconds(1f);
                andar = false;

            }
            if (col.tag == "Proyectil")
            {
                Debug.Log(vida);
                vida = vida - 10;
                Destroy(col.gameObject);
                Debug.Log(vida);

                if (vida <= 0)
                {

                    Destroy(gameObject);
                }
            }
    }


}
