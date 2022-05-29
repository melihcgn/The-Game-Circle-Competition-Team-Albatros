using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DollarValueUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int scoreValueOffset=100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        
        for (int index = 0; index < transform.childCount; index++)
        {
            TextMeshPro scoreText=transform.GetChild(index).GetComponentInChildren<TextMeshPro>();
            DollarLine dl=transform.GetChild(index).GetComponent<DollarLine>();
            dl.dollarValue=index*scoreValueOffset;
            
            scoreText.text=(index*scoreValueOffset).ToString()+"$";
        }
        
        //TextMeshPro scoreText=gameObject.GetComponentInChildren<TextMeshPro>();
        
    }
}
