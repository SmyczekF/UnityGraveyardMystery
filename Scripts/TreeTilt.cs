using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeTilt : MonoBehaviour
{
    private Vector3 vec = new Vector3 (0,0,330);

    private void OnMouseDown() {
        if (this.transform.rotation.eulerAngles == vec){
            transform.Rotate(0,0,30);
        }
        else{
            transform.Rotate(0,0,-30);
        }
    }
}
