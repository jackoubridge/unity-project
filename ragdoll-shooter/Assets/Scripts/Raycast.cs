using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    public Camera fpsCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit)){
            Vector3 attack = Vector3.Normalize(fpsCam.transform.forward);
            hit.transform.gameObject.GetComponent<Rigidbody>().AddForce((attack * 20), ForceMode.Impulse);
            
        }

    }
}
