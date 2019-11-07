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

public class CellData : ScriptableObject {
    public string cellID;
    public CellTypes cellType;


    public void Action() {
        //Do something...
    }
}
