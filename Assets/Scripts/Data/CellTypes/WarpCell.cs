using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

[CreateAssetMenu(fileName = "WarpCellData", menuName = "Pacman/Data/WarpCell", order = 104)]
public class WarpCell  : CellData, ITriggerable {
    [SerializeField] private Transform _destination;
    public WarpCell destinationCell;
    
    
    public void Trigger<T>(T param) {
        var agent = param as IWarpable;
        agent?.WarpTo(_destination.position);
    }
}
