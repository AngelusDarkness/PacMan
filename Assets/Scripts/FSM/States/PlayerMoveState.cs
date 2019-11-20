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
        
        if (Input.GetKeyDown(_playerController.inputData.upKeyCode)) {
            Step(Directions.kUp);
        }
        
        if (Input.GetKeyDown(_playerController.inputData.downKeyCode)) {
            Step(Directions.kDown);
        }
        
        if (Input.GetKeyDown(_playerController.inputData.leftKeyCode)) {
            Step(Directions.kLeft);
        }
        
        if (Input.GetKeyDown(_playerController.inputData.rightKeyCode)) {
            Step(Directions.kRight);
        }
    }

    public override void ExitState() {
        
    }
    
    
    
    void Step(Directions direction) {
        var xPos = _currentLogicalX;
        var yPos = _currentLogicalY;

        //Check for direction and limits
        switch (direction) {
            case Directions.kUp: 
                CheckStep(xPos, yPos - 1);
                break;
            case Directions.kDown:
                CheckStep(xPos, yPos + 1);
                break;
            case Directions.kLeft:
                CheckStep(xPos - 1, yPos);
                break;
            case Directions.kRight:
                CheckStep(xPos + 1, yPos);
                break;
        }
    }
    
    void CheckStep(int x, int y) {
        var cell = _playerController.gridData.GetCell(x, y);
        if (cell.isWalkable) {
            _playerController.MoveTo(cell);
                
            //Trigger cell if you have to.
            //var trigger = cell as ITriggerable;
            //trigger?.Trigger(_playerController.cellData);
        }
    }
}
