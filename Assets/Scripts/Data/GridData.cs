using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "GridData", menuName = "Pacman/Data/Grid", order = 102)]
public class GridData : ScriptableObject {
    [Header("Grid Settings")]
    public Vector2 gridSize;
    public int cellSize;

    [Header("Grid Source Data")]
    public List<CellData> cellSourceData;
    public bool IsLoaded => gridStates != null && gridStates.Count > 0;

    //Private attributes
    [NonSerialized] private List<CellData> gridStates;
    
    public void Load() {
        gridStates = new List<CellData>(cellSourceData);
    }

    
    public CellData GetCell(int x, int y) {
        return gridStates.Find(cell =>
            cell.logicalPosition.x == x && cell.logicalPosition.y == y);
    }

    public void UpdateCellState(CellData currentData, CellData newData) {
        currentData.oldData = currentData;
        
        //Update Data on List
        var idx = gridStates.FindIndex(cell => cell.GetInstanceID() == newData.GetInstanceID());
        newData.oldData.logicalPosition = newData.logicalPosition;
        gridStates[idx] = newData.oldData;
        
        idx = gridStates.FindIndex(cell => cell.GetInstanceID() == currentData.GetInstanceID());
        gridStates[idx] = newData;

    }
}
