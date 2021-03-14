using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneradorEnemigos_3 : MonoBehaviour
{
    public List<GameObject> Enemigo;
    public List<Transform> portal;
    private GameObject go;
    private int[] listaenemigos3 = new int[] { 4, 0, 1, 2, 1, 3, 4, 4, 0, 0, 2, 2, 2, 1, 1, 3, 0, 4, 0, 3 };
    private int[] listaportales3 = new int[] { 1, 0, 4, 2, 3, 3, 1, 0, 2, 3, 4, 1, 0, 2, 3, 1, 0, 2, 1, 0 };
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
                go = Instantiate(Enemigo[listaenemigos3[i]], portal[listaportales3[i]].position, portal[listaportales3[i]].rotation) as GameObject;
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