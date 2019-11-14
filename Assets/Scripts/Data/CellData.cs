using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum  CellTypes{
    kEmpty,
    kWall,
    kPlayer,
    kGhost,
    kWarp,
    kSpawner,
    kPellet,
    KNone
}

public abstract class CellData : ScriptableObject {
    public Vector2Int logicalPosition;
    public CellTypes srcCellType;
    public bool isWalkable = true;
    
    [NonSerialized] public CellData oldData;
    
    
    [NonSerialized] private CellTypes _cellType;
    public abstract void Load();
}
