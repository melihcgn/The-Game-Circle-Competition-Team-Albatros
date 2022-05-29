using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float verticalSpeed=3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameState.gameStateInstance.levelStates == GameState.LevelStates.Started)
        {
            transform.position+=verticalSpeed*Time.deltaTime*Vector3.forward;

        }
    }
}
