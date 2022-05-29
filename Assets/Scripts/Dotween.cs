using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Dotween : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]Ease easeType=Ease.InSine;
    void Start()
    {
        DOTween.Init();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            transform.DOMoveY(1,1).SetEase(easeType).OnComplete(()=> BringOldPosition());
            transform.DOScale(3,1);
        }
    }

    private void BringOldPosition()
    {
        transform.DOMoveY(10, 1);
        transform.DOScale(1,1);
    }
}
