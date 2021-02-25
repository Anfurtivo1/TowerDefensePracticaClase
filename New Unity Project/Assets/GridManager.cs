using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public Sprite sprite;
    public GameObject objeto;
    public int columnas=3;
    public int filas=3;
    int[,] grid;

    // Start is called before the first frame update
    void Start()
    {
       grid = new int[columnas, filas];
        for (int i = 0; i < columnas; i++)
        {
            for (int j = 0; j < filas; j++)
            {
                grid[i, j] = Random.Range(0, 10);
                spawnTile(i, j);
            }
        }
}

    private void spawnTile(int x, int y)
    {
        Instantiate(objeto, new Vector3(x, y, 0), Quaternion.identity);
        objeto.transform.position = new Vector3(x,y);
    }
}
