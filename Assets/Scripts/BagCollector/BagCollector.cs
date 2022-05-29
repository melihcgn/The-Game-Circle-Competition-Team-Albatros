using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BagCollector : MonoBehaviour
{
   static int currentBagLevel=0;
   bool x;
    static List<GameObject>collectedBags =new List<GameObject>();
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Bag")){
            collectedBags.Add(other.gameObject);          
            other.transform.position=collectedBags[currentBagLevel].transform.position+Vector3.forward;
            Destroy(gameObject.GetComponent<BagCollector>());//        
            other.gameObject.AddComponent<BagCollector>();
            other.tag="Collector";
            other.gameObject.GetComponent<BoxCollider>().isTrigger=false;
            NodeMovement nd =other.gameObject.AddComponent<NodeMovement>();
            nd.connectedNode=transform;//
            //nd.connectedNode=collectedBags[currentBagLevel].transform;
            currentBagLevel++;
            ApplyDoTweenForEach();

        }
    }

    private void ApplyDoTweenForEach()
    {
        foreach (var bagItem in collectedBags)
        {
            DoTweenShake(bagItem,.3f,.02f);
        }

    }

    private static void DoTweenShake(GameObject bagItem,float duration,float strength)
    {
        
        //bagItem.transform.DOShakePosition(duration,strength);
        bagItem.transform.DOShakeScale(duration, strength).SetLoops(1);
        bagItem.transform.DOShakeRotation(duration, strength).SetLoops(1);
    }

    private void Update() {
        
    }
}
