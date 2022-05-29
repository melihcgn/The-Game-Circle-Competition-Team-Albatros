using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pcInputs : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float planeSize=1f;
    [SerializeField] float horizontalSpeed=3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)){
            // float posxif = Mathf.Lerp(transform.position.x, -planeSize, Time.deltaTime * 1f);
            // Debug.Log("posx"+posxif);
            // transform.position = new Vector3(posxif, transform.position.y, transform.position.z);
            // Debug.Log("solş");
             transform.position+=Vector3.left*horizontalSpeed*Time.deltaTime;
             float posx=Mathf.Clamp(transform.position.x,-planeSize,planeSize);
             transform.position=new Vector3(posx,transform.position.y,transform.position.z);
        }
        if(Input.GetKey(KeyCode.D)){
            
             transform.position+=Vector3.right*horizontalSpeed*Time.deltaTime;
             float posx=Mathf.Clamp(transform.position.x,-planeSize,planeSize);
             transform.position=new Vector3(posx,transform.position.y,transform.position.z);
        }
        
    }
}
