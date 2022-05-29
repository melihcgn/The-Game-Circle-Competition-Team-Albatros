using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public enum LevelStates{
       NotStarted,
       Started,
       Finished 
    }
    public static GameState gameStateInstance;
    public LevelStates levelStates=LevelStates.NotStarted;
    private void Awake() {
        if(gameStateInstance!=null){
            Destroy(this);
        }
        else{
            gameStateInstance=this;
            DontDestroyOnLoad(this);
        
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
