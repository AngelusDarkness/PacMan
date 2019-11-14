using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GridData : ScriptableObject {
    [Header("Grid Settings")]
    public Vector2 gridSize;
    public int cellSize;

    [Header("Grid Source Data")]
    public List<CellData> cellSourceData;

    //Private attributes
    private List<CellData> gridStates { get;  set; }
    
    public void Load() {
        gridStates = new List<CellData>(cellSourceData);
    }

    
    public CellData GetCell(int x, int y) {
        return gridStates.Find(cell =>
            cell.logicalPosition.x == x && cell.logicalPosition.y == y);
    }

    public void UpdateCellState(CellData currentData, CellData newData) {
        currentData.oldData = currentData;
        currentData = newData;
        
        //Update Data on List
        var idx = gridStates.FindIndex(cell => cell.GetInstanceID() == currentData.GetInstanceID());
        gridStates[idx] = currentData;
    }
}
