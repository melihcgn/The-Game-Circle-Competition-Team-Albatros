using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log("FinalPoint Çalıştı");
        GameState.gameStateInstance.levelStates=GameState.LevelStates.Finished;
    }
}
