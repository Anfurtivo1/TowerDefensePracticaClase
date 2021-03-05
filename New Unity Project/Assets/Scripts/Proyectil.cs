using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public int velocidad = 3;
    public int ataque = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * velocidad * Time.deltaTime;
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Enemigo")
    //    {
    //        //Si el ataque colisiona contra un objeto con el tag 'Enemigo', se decrementan las vidas de dicho enemigo
    //        other.gameObject.GetComponent<ComportamientoEnemigo>().Vidas--;

    //        //Destruimos el objeto cuando colisione contra un enemigo
    //        Destroy(gameObject);
    //    }
    //}
}
