using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InputData", menuName = "Pacman/Data/Input", order = 102)]
public class InputData : ScriptableObject {
    public KeyCode upKeyCode;
    public KeyCode downKeyCode;
    public KeyCode leftKeyCode;
    public KeyCode rightKeyCode;
}
