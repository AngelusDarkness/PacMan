using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerCell : CellData {

    [SerializeField] private GameObject _agentToSpawn;
    [SerializeField] private Transform _spawnPosition;

    [NonSerialized] private GameObject _spawnedAgent; 
    
    public void Spawn() {
        if (_spawnedAgent == null) {
            _spawnedAgent = Instantiate(_agentToSpawn, _spawnPosition.position, _spawnPosition.rotation);    
        } else {
            _spawnedAgent.transform.position = _spawnPosition.position;
        }
    }

}
