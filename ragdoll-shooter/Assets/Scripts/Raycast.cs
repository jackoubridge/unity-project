using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public Camera fpsCam;

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)){
            if(hit.rigidbody != null){
                Vector3 attack = Vector3.Normalize(fpsCam.transform.forward);
                hit.rigidbody.AddForce((attack * 10), ForceMode.Impulse);       
            }
        }
    }
}
