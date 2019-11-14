using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCell : CellData {
    public override void Load() {
        isWalkable = false;
    }
}
