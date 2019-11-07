using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpCell  : CellData {
    public Vector3 destination;
    public WarpCell destinationCell;


    public void Warp(IWarpable agent) {
        agent.WarpTo(destination);
    }
}
