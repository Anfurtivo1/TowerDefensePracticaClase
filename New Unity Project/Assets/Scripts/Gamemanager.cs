using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public List <GameObject> objetos;
    public GameObject objeto;
    public int dinero;
    private int dineroAGastar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Cast a ray straight down.
            RaycastHit2D hit = Physics2D.Raycast(rayo.origin,rayo.direction);

            // If it hits something...
                if (hit.collider != null && hit.collider.tag.Equals("Cuadricula") && dinero>=dineroAGastar && objeto !=null)
                {
                //Para que se ponga en el centro de la cuadricula
                    Transform cuadricula = hit.collider.transform;
                    if (cuadricula.childCount==0)
                    {
                        GameObject pokemon=Instantiate(objeto, hit.collider.transform.position, objeto.transform.rotation);
                        dinero = dinero - dineroAGastar;
                        pokemon.transform.SetParent(cuadricula);
                    }
                
                }

            if (hit.collider!=null && hit.collider.tag.Equals("FlareonCard"))
            {
                dineroAGastar = 100;
                objeto = objetos[0];
            }

            if (hit.collider != null && hit.collider.tag.Equals("BlastoiseCard"))
            {
                dineroAGastar = 50;
                objeto = objetos[1];
            }

        }
    }
}
