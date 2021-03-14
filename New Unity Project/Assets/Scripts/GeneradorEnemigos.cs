using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneradorEnemigos : MonoBehaviour
{
    public List <GameObject> Enemigo;
    public List <Transform> portal;
    private GameObject go;
    private int[] listaenemigos = new int[] { 0, 0, 0, 0, 1, 0, 0, 2, 1, 0, 0, 1, 0, 2, 2, 0, 1, 1, 2, 1 };
    private int[] listaportales = new int[] { 0, 2, 3, 1, 2, 4, 4, 0, 2, 3, 1, 1, 0, 0, 3, 4, 3, 4, 2, 0 };
    private int i = 0;
    private int j = 10;
    private bool ultimo = true;
    private bool ganado=true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (ganado)
        {
            if (i < 18)
            {
                yield return new WaitForSeconds(j);
                go = Instantiate(Enemigo[listaenemigos[i]], portal[listaportales[i]].position, portal[listaportales[i]].rotation) as GameObject;
                i++;
                j--;
            }
            else if (i >= 19 && ultimo)
            {
                yield return new WaitForSeconds(j);
                go = Instantiate(Enemigo[listaenemigos[i]], portal[listaportales[i]].position, portal[listaportales[i]].rotation) as GameObject;
                i++;
                j--;
                ultimo = false;
            }
            yield return new WaitForSeconds(j);
        }
            
        }

    }

