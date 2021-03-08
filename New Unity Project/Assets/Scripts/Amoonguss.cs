using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amoonguss : MonoBehaviour
{
    public int vida;
    public float frecuencia;
    public GameObject Pokeball;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(frecuencia);

            GameObject go = Instantiate(Pokeball, transform.position + Vector3.up * Random.Range(0, 1) + Vector3.left * Random.value, Pokeball.transform.rotation);
            Destroy(go, 10);
        }
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
