using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject Enemigo;
    public Transform portal;
    private GameObject go;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            go = Instantiate(Enemigo, portal.position, portal.rotation) as GameObject;
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

