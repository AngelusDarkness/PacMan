using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    [SerializeField] private GridData _gridData;
    
    // Start is called before the first frame update
    void Start() {
        _gridData.Load();
    }
    

   
}
