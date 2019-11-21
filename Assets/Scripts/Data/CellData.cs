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
    public Vector2Int srcLogicalPosition;
    public CellTypes srcCellType;
    public bool isWalkable = true;

    [NonSerialized] public Vector2Int logicalPosition;
    [NonSerialized] public CellData oldData;
    [NonSerialized] private GameObject _owner;
    [NonSerialized] private CellTypes _cellType;

    public virtual void Load() {
        oldData = this;
        logicalPosition = srcLogicalPosition;
    }

    public virtual void Load(GameObject owner ) {
        Load();
        _owner = owner;
        
    }

    public Vector3 GetPosition() {
        return _owner.transform.position;
    }
}
