using System;
using System.Collections;
using System.Collections.Generic;
using Data;
using Events;
using UnityEngine;

[CreateAssetMenu(fileName = "PelletCellData", menuName = "Pacman/Data/PelletCell", order = 106)]
public class PelletCell : CellData, ITriggerable {

    [SerializeField] private bool _isBig;
    [SerializeField] private int _scoreMultiplier = 1;

    [NonSerialized] private BigPelletEvent _bigPelletEvent = new BigPelletEvent();
    
    public void Trigger<T>(T param) {

        if (!(param is PlayerCell)) {
            return;
        }

        var player = param as PlayerCell;
        
        if (_isBig) {
            //Player do something (probably start eating ghosts)
            //Ghost enter in escape mode and become vulnerable
            EventController.TriggerEvent(_bigPelletEvent);
        } else {
            //Player add scores
            player.UpdateScore(_scoreMultiplier);
        }
    }

    
}
