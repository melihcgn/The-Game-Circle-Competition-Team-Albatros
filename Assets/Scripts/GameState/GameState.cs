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
    public int currentLevel=0;
    public int maxLevel= 0;

    public int gameMoney=0;
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
