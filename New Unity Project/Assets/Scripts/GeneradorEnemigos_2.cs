using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneradorEnemigos_2 : MonoBehaviour
{
    public List<GameObject> Enemigo;
    public List<Transform> portal;
    private GameObject go;
    private int[] listaenemigos = new int[] { 3, 0, 3, 0, 1, 2, 3, 0, 1, 0, 1, 3, 0, 2, 1, 3, 2, 1, 2, 3 };
    private int[] listaportales = new int[] { 2, 1, 3, 0, 2, 0, 4, 4, 1, 3, 2, 1, 0, 4, 3, 1, 3, 2, 2, 0 };
    private int i = 0;
    private bool ultimo = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            if (i < 18)
            {
                yield return new WaitForSeconds(1);
                go = Instantiate(Enemigo[listaenemigos[i]], portal[listaportales[i]].position, portal[listaportales[i]].rotation) as GameObject;
                i++;
            }
            else if (i >= 19 && ultimo)
            {
                go = Instantiate(Enemigo[listaenemigos[i]], portal[listaportales[i]].position, portal[listaportales[i]].rotation) as GameObject;
                ultimo = false;
            }
        }

        }

    }