using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DollarLine : MonoBehaviour
{

    [SerializeField] GameObject hand;
    public int dollarValue=10;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Collector")){
            GameState.gameStateInstance.gameMoney+= dollarValue;
            Destroy(gameObject.GetComponent<BoxCollider>());
            other.transform.DOShakeScale(0.3f,.01f);
            other.transform.DOShakeRotation(0.3f, .01f);
            hand.transform.DOMoveX(10,1);
            Destroy(other.gameObject,.2f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
