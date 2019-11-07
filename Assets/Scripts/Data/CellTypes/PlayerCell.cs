using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCell : CellData {
    [SerializeField] private ScoreData _scoreData;

    public void UpdateScore(int multiplier) {
        _scoreData.UpdateScore(multiplier);
    }
}
