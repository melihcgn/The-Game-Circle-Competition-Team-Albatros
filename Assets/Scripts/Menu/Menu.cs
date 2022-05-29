using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moneyText.text = GameState.gameStateInstance.gameMoney.ToString();
    }
    public void ButtonRestartLevel()
    {
        SceneManager.LoadScene(GameState.gameStateInstance.currentLevel);
    }
    public void ButtonNextLevel()
    {
        GameState.gameStateInstance.currentLevel++;
        if (GameState.gameStateInstance.maxLevel > GameState.gameStateInstance.currentLevel)
        {
            SceneManager.LoadScene(GameState.gameStateInstance.currentLevel);
        }
        else
        {
            GameState.gameStateInstance.currentLevel = 0;
            SceneManager.LoadScene(GameState.gameStateInstance.currentLevel);
        }
        
    }
}
