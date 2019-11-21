using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

[CreateAssetMenu(fileName = "GhostCellData", menuName = "Pacman/Data/GhostCell", order = 102)]
public class GhostCell : CellData, ITriggerable, IWarpable {
    public bool isBlue = false;
    public int scoreMultiplier = 2;
    
    public void WarpTo(Vector3 destination) {
        
    }

    public void Trigger<T>(T param) {
        if (!(param is PlayerCell)) {
            return;
        }
        
        if (isBlue) {
            //Respawn
        } 
    }
    
}
