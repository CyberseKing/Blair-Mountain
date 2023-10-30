using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] GameObject tile;
    [SerializeField] int gridHeight = 10;
    [SerializeField] int gridWidth = 10;
    [SerializeField] float tileSize = 1f;
    void Start()
    {
        GeneratorGrid();   
    }
    private void GeneratorGrid()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int y = 0; y < gridHeight; y++)
            {
                GameObject newTile = Instantiate(tile, transform);

                float posX = (x * tileSize + y * tileSize) / 2f;
                float posY = (x * tileSize - y * tileSize) / 4f;

                newTile.transform.position = new Vector2(posX, posY);
                newTile.name = x + "," + y;

            }
        }

    }
    
}
