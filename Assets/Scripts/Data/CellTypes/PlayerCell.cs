using System;
using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

public class PlayerCell : CellData, ITriggerable, IWarpable {
    [SerializeField] private ScoreData _scoreData;
    [NonSerialized] private int _health = 3;

    
    public void UpdateScore(int multiplier) {
        _scoreData.UpdateScore(multiplier);
    }

    public void WarpTo(Vector3 destination) {
        
    }

    public void Trigger<T>(T param) {
        if (!(param is GhostCell)) {
            return;
        }

        var ghost = param as GhostCell;

        if (ghost.isBlue) {
            UpdateScore(ghost.scoreMultiplier);
        } else {
            if (_health <= 0) return;
            
            _health--;
                
            if (_health == 0) {
                //GameOver
            } else {
                //Respawn
            }
        }
    }
}
