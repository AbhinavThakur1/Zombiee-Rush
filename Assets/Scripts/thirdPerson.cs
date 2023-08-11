using UnityEngine;

public class thirdPerson : MonoBehaviour
{
    [Header("Reference")]
    public Transform orientation;
    public Transform playerObj;
    public Transform cameraPos;
    public Transform player;

    void Update()
    {
        orientation.forward = player.position - new Vector3(cameraPos.position.x, player.position.y, cameraPos.position.z);
        float inputx = Input.GetAxis("Horizontal");
        float inputy = Input.GetAxis("Vertical");
        Vector3 inputDir = orientation.forward * inputy + orientation.right * inputx;
        if (inputDir != Vector3.zero)
        {
            playerObj.forward = Vector3.Slerp(playerObj.forward, inputDir.normalized, 6f * Time.deltaTime);
        }
    }

}
