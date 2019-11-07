using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridData : ScriptableObject {
    [Header("Grid Settings")]
    public Vector2 gridSize;
    public int cellSize;

    [Header("Grid Source Data")]
    public List<CellData> cellSourceData;

    //Private attributes
    private List<CellData> cellState;
    
    
    public void BuildGrid() {
        //Generate rows of columns
        for (var i = 0; i < gridSize.x; i++) {
            for (var  j = 0; j < gridSize.y; j++) {
                
            }
        }


    }
}
