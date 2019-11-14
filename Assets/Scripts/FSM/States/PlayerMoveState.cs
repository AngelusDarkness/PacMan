using System;
using System.Collections;
using System.Collections.Generic;
using Data;
using UnityEngine;

public class PlayerMoveState : State {

    private PlayerController _playerController;
    private Directions _direction;
    private bool _canMove = true;
    private bool _isMoving = false;

    private int _currentLogicalX = -1;
    private int _currentLogicalY = -1;

    public override void InitState<T>(T param) {
        _playerController = param as PlayerController;

        if (_playerController == null) {
            return;
        }

        _currentLogicalX = _playerController.cellData.logicalPosition.x;
        _currentLogicalY = _playerController.cellData.logicalPosition.y;
    }

    public override void UpdateState(float delta) {
        
    }

    public override void ExitState() {
        
    }
    
    
    
    void Step(Directions direction) {
        var xPos = _currentLogicalX;
        var yPos = _currentLogicalY;

        //Check for direction and limits
        switch (direction) {
            case Directions.kUp:
                var cell = _playerController.gridData.GetCell(xPos, yPos - 1);

                if (cell.isWalkable) {

                    _playerController.gridData.UpdateCellState(cell, _playerController.cellData);
                    //Trigger cell if you have to.
                    //var trigger = cell as ITriggerable;
                    //trigger?.Trigger(_playerController.cellData);
                }

                break;
            case Directions.kDown:
               
                break;
            case Directions.kLeft:
               
                break;
            case Directions.kRight:
                 
               
                break;
        }
        
    }
}
