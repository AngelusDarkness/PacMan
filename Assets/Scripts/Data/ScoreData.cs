using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreData : ScriptableObject {
    //Source static data
    [SerializeField] private int baseScore = 100;
    
    //Dynamic data
    [NonSerialized] private int score;



    public void UpdateScore(int multiplier) {
        score += baseScore * multiplier;
    }

}

[Serializable]
public class SerializableScoreData {
    private int score;
}
