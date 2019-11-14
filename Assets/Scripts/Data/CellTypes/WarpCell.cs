﻿using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

public class WarpCell  : CellData, ITriggerable {
    [SerializeField] private Transform _destination;
    public WarpCell destinationCell;
    
    public override void Load() {
        
    }
    
    public void Trigger<T>(T param) {
        var agent = param as IWarpable;
        agent?.WarpTo(_destination.position);
    }
}
