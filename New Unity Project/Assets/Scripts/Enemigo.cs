using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad;
    public int vida;
    public LayerMask pokemon;
    private float aux=0;
    private int recibirDano;
    public float velocidadAtaque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector3.left,.2f,pokemon);
        if (hit.collider!=null)
        {
            aux = aux + Time.deltaTime;
            if (aux >= velocidadAtaque)
            {
                aux = 0;
                hit.collider.SendMessage("recibirAtaque");
            }
        }
        else
        {
            transform.position += Vector3.left * velocidad * Time.deltaTime;
        }
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.tag == "Proyectil")
        {
            //Debug.Log(vida);
            vida = vida - 1;
            Destroy(col.gameObject);
            //Debug.Log(vida);

            if (vida <= 0)
            {

                Destroy(gameObject);
            }
        }
            
    }


}
