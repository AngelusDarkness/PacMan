using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : FSM {
    
    public PlayerCell cellData;
    public GridData  gridData;
    public InputData inputData;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MoveTo(CellData destinationCell) {
        StartCoroutine(Move(destinationCell));
    }

    private IEnumerator Move(CellData destinationCell) {
        var destination = destinationCell.GetPosition();
        var duration   = 1f;     
        var currentTime = 0f;
        var percentage  = 0f;

        while (percentage < 1) {
            currentTime += Time.deltaTime;
            
            percentage = currentTime / duration;
            
            if (currentTime >= duration) {
                percentage = 1;
            }
            
            transform.position = Vector3.Lerp(transform.position, destination, percentage);
            yield return null;
        }

        gridData.UpdateCellState(destinationCell, cellData);
    }


}
