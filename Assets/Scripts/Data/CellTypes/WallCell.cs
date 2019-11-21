using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WallCellData", menuName = "Pacman/Data/WallCell", order = 100)]
public class WallCell : CellData {
    public override void Load() {
        base.Load();
        isWalkable = false;
    }
}
