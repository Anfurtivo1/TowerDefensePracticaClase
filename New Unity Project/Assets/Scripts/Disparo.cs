using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectil;
    public Transform boca;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            GameObject p = Instantiate(proyectil, boca.position, boca.rotation);
            Destroy(p, 2);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
