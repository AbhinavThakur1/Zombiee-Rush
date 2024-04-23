using UnityEngine;
using UnityEngine.UI;

public class firstPersonPc : MonoBehaviour
{
    [SerializeField] int sensitivity;
    [SerializeField] Transform player;
    [SerializeField] Transform orientation;
    [SerializeField] Transform gunObject;
    float rotationx;
    float rotationy;
    [SerializeField] Slider slider;

    private void Start()
    {
        if(PlayerPrefs.GetInt("sensitivity") == 0)
        {
            PlayerPrefs.SetInt("sensitivity", sensitivity);
            slider.value = sensitivity;
        }
        else
        {
            sensitivity = PlayerPrefs.GetInt("sensitivity");
            slider.value = PlayerPrefs.GetInt("sensitivity");
        }
        slider.onValueChanged.AddListener(SensitivityChange);
    }
    void Update()
    {
        float mousex = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity; 
        float mousey = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;

        rotationx -= mousey;
        rotationy += mousex;
        rotationx = Mathf.Clamp(rotationx, -90, 90);
        transform.rotation = Quaternion.Euler(new Vector3(rotationx, rotationy, 0f));
        player.rotation = Quaternion.Euler(new Vector3(0f, rotationy, 0f));
        orientation.rotation = Quaternion.Euler(new Vector3(0f, rotationy, 0f));
        gunObject.rotation = Quaternion.Euler(new Vector3(1.097f, rotationy + 83f, rotationx - 15f));
    }

    public void SensitivityChange(float i)
    {
        sensitivity = (int)i;
    }
}
