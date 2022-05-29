using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DollarValueUpdater : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float scoreValueOffset=100f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Awake()
    {
        
        for (int index = 0; index < transform.childCount; index++)
        {
            TextMeshPro scoreText=transform.GetChild(index).GetComponentInChildren<TextMeshPro>();
            
            scoreText.text=(index*scoreValueOffset).ToString()+"$";
        }
        
        //TextMeshPro scoreText=gameObject.GetComponentInChildren<TextMeshPro>();
        
    }
}
