using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElegirNiveles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nivel1()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void nivel2()
    {
        SceneManager.LoadScene("Nivel_2");
    }

    public void nivel3()
    {
        SceneManager.LoadScene("Nivel_3");
    }

}
