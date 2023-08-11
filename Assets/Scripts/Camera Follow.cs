using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Reference")]
    public Transform cameraPos;
    //camera pos y 5 rotation x 65
    void Update()
    {
        transform.position = cameraPos.position;
        transform.rotation = cameraPos.rotation;
    }

}
