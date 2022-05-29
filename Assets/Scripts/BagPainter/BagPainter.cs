using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class BagPainter : MonoBehaviour
{
    Color selectedColor;
    [SerializeField] ParticleSystem pparticleSystem;

    private void Awake() {
        selectedColor= new Color(
       Random.Range(0f, 1f),
       Random.Range(0f, 1f),
       Random.Range(0f, 1f)
   );
        var main = pparticleSystem.main;
        main.startColor = new ParticleSystem. MinMaxGradient( selectedColor );
    }
   private void OnTriggerEnter(Collider other) {
       if(other.CompareTag("Collector")){
           Debug.Log("BagPainter Çarpıştı");
       MeshRenderer currentBagColor =other.GetComponent<MeshRenderer>();
       currentBagColor.material.DOColor(selectedColor,.5f);
       
    //    var psMain= particleSystem.main;
    //    psMain.startColor=new ParticleSystem.MinMaxGradient( selectedColor );
        // var main = particleSystem.main;
        // main.startColor = Color.black;
           
       }
       
   }
}
