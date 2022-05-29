using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    [SerializeField] float nodeSpeed=20f;
    
    void Update()
    {
        NodeEffect();
    }

    private void NodeEffect()
    {
        //Debug.Log("connectedNode.pos "+connectedNode.position);
        transform.position = new Vector3(
                    Mathf.Lerp(transform.position.x, connectedNode.position.x, Time.deltaTime * nodeSpeed),
                    transform.position.y,
                    connectedNode.position.z+2f
                );
    }
}
