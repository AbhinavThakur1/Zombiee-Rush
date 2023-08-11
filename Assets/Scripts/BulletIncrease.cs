using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletIncrease : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        try
        {
            collision.collider.GetComponent<PlayerMovement>().ammo += 20;
        }
        catch
        {
            
        }
    }
}
