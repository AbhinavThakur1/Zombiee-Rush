using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            GetComponent<MeshCollider>().isTrigger = false;
        }
        else
        {
            GetComponent<MeshCollider>().isTrigger = true;
        }
    }
}
