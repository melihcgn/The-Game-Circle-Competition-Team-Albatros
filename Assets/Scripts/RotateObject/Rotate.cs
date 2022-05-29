using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.GetComponentInChildren<MeshRenderer>().material.color =  new Color(
       Random.Range(0f, 1f),
       Random.Range(0f, 1f),
       Random.Range(0f, 1f)
   ); ;
    }
    void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collector"))
        {
            MeshRenderer currentBagColor = other.GetComponent<MeshRenderer>();
            currentBagColor.material.DOColor(gameObject.GetComponentInChildren<MeshRenderer>().material.color, .5f);
            Destroy(gameObject.GetComponent<BoxCollider>());
            transform.DOShakeScale(0.2f, 0.3f);
            transform.DOShakeRotation(0.2f, 0.3f);
            Destroy(gameObject, .2f);

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0, 1, 0);
    }
}
