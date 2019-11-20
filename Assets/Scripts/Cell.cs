using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {
    [SerializeField] private CellData _data;
    // Start is called before the first frame update
    private void Start() {
        if (_data is WallCell) {
            _data.Load();    
        }
        else {
            _data.Load(gameObject);
        }

    }

}
