using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject proyectil;
    public Transform boca;
    public LayerMask enemigo;
    private GameObject p;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);

            RaycastHit2D hit = Physics2D.Raycast(boca.position, Vector3.right,9,enemigo);
            if (hit.collider !=null)
            {
                p = Instantiate(proyectil, boca.position, boca.rotation);
                Destroy(p, 2);
            }
           
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
