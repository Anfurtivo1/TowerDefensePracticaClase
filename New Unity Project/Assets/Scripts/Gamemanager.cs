using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    public List <GameObject> objetos;
    public GameObject objeto;
    public int dinero;
    private int dineroAGastar;
    public Text TxtDinero;


    // Start is called before the first frame update
    void Start()
    {
        ActualizarDinero(0);
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
                
                } else if (hit.collider.CompareTag("Pokeball"))
                    {
                        ActualizarDinero(50);
                        Destroy(hit.collider.gameObject);
                    }

            if (hit.collider!=null && hit.collider.tag.Equals("FlareonCard"))
            {
                dineroAGastar = 100;
                objeto = objetos[0];
            }

            if (hit.collider != null && hit.collider.tag.Equals("BlastoiseCard"))
            {
                dineroAGastar = 150;
                objeto = objetos[1];
            }

            if (hit.collider != null && hit.collider.tag.Equals("AmoongussCard"))
            {
                dineroAGastar = 50;
                objeto = objetos[2];
            }

            if (hit.collider != null && hit.collider.tag.Equals("AggronCard"))
            {
                dineroAGastar = 100;
                objeto = objetos[3];
            }

            if (hit.collider != null && hit.collider.tag.Equals("ShuckleCard"))
            {
                dineroAGastar = 50;
                objeto = objetos[4];
            }
            ActualizarDinero(0);
        }
    }

    public void ActualizarDinero(int Add)
    {
        dinero += Add;
        TxtDinero.text = dinero.ToString();

    }
}
