using System;
using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

public class PlayerCell : CellData, ITriggerable, IWarpable {
    [SerializeField] private ScoreData _scoreData;
    [NonSerialized] private int _life = 3;
    
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
            if (_life <= 0) return;
            
            _life--;
                
            if (_life == 0) {
                //GameOver
            } else {
                //Respawn
            }
        }
    }
}
