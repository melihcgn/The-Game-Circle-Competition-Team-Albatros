using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BagDeleter : MonoBehaviour
{
    [SerializeField]Transform targetScore;
    [SerializeField]GameObject menuUI;
    [SerializeField] float durationTween=4f;
    private void OnTriggerEnter(Collider other)
    {
        other.transform.DOScale(new Vector3(.01f, .01f, .01f),3f);
        GameState.gameStateInstance.gameMoney += 100;
        if (other.CompareTag("Hand"))
        {
            GameState.gameStateInstance.levelStates = GameState.LevelStates.Finished;
            menuUI.SetActive(true);

        }
        if (other.CompareTag("Collector"))
        {
            menuUI.SetActive(true);
        }
        Destroy(other.gameObject, durationTween);
        

    }
}
