using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneradorEnemigos_2 : MonoBehaviour
{
    public List<GameObject> Enemigo;
    public List<Transform> portal;
    private GameObject go;
    private int[] listaenemigos2 = new int[] { 3, 0, 3, 0, 1, 2, 3, 0, 1, 0, 1, 3, 0, 2, 1, 3, 2, 1, 2, 3 };
    private int[] listaportales2 = new int[] { 2, 1, 3, 0, 2, 0, 4, 4, 1, 3, 2, 1, 0, 4, 3, 1, 3, 2, 2, 0 };
    private int i = 0;
    public Text JefeAcercandose;
    public bool jefe = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            if (i < 19)
            {
                
                yield return new WaitForSeconds(1);
                go = Instantiate(Enemigo[listaenemigos2[i]], portal[listaportales2[i]].position, portal[listaportales2[i]].rotation) as GameObject;
                i++;
            }
            //if (i >= 19 && jefe)
            //{
            //    JefeAcercandose.text = "JEFE ACERCANDOSE";
            //    yield return new WaitForSeconds(3);
            //    JefeAcercandose.text = "";
            //    jefe = false;
            //}
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