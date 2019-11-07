using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

public class PelletCell : CellData, ITriggerable {

    [SerializeField] private bool _isBig;
    [SerializeField] private int _scoreMultiplier = 1;

    public void Trigger<T>(T param) {
        var player = param as PlayerCell;
        
        if (_isBig) {
            //Player do something (probably start eating ghosts)
            //Ghost enter in escape mode and become vulnerable
        } else {
            //Player add scores
            player.UpdateScore(_scoreMultiplier);
        }
    }
}
