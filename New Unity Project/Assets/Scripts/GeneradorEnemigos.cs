using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public List <GameObject> Enemigo;
    public List <Transform> portal;
    private GameObject go;
    private int[] listaenemigos = new int[] { 0, 0, 0, 0, 1, 0, 0, 2, 1, 0, 0, 1, 0, 2, 2, 0, 1, 1, 2, 1 };
    private int[] listaportales = new int[] { 0, 2, 3, 1, 2, 4, 4, 0, 2, 3, 1, 1, 0, 0, 3, 4, 3, 4, 2, 0 };
    private int i = 0;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            go = Instantiate(Enemigo[listaenemigos[i]], portal[listaportales[i]].position, portal[listaportales[i]].rotation) as GameObject;
            if (i<20)
            {
                i++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Destroy(go);
        }
    }
}

