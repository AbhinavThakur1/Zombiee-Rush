using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Reference")]
    public TextMeshProUGUI Ammocount;
    public Transform orientation;
    public Transform playerObj;
    public Transform cameraPos;
    public Transform cm;
    public Transform player;
    public float health;
    public float ammo;
    public GameObject HitEffect;
    public GameObject muzzleFire;
    public Canvas menu;
    public Canvas playagain;
    public Canvas crosshair;
    AudioSource AS;
    bool attackcontinue;
    AudioSource heartbeat;
    AudioSource gunFire;
    [SerializeField] UnityEngine.UI.Image image;



    [Header("Movement")]
    public float speed;
    public float groundDrag;
    public float bulletMaxDistance;
    public LayerMask layerMask;
    Rigidbody rb;
    Vector3 inputDir;

    [Header("SFX")]
    [SerializeField]AudioClip shot;

    private void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        heartbeat = GetComponent<AudioSource>();
        AS = GameObject.FindGameObjectWithTag("gun").GetComponent<AudioSource>();
        gunFire = GameObject.FindGameObjectWithTag("fireSound").GetComponent<AudioSource>();


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        image.fillAmount = 0.005f * health;
        Ammocount.text = "Ammo:- "+ ((int)ammo).ToString();
        float inputx = Input.GetAxisRaw("Horizontal");
        float inputy = Input.GetAxisRaw("Vertical");
        inputDir = cm.forward * inputy + cm.right * inputx;
        if (inputDir != Vector3.zero && health > 0)
        {
            AS.enabled = true;
            rb.AddForce(inputDir.normalized * speed * 10f, ForceMode.Force);
            rb.drag = groundDrag;
        }
        else
        {
            AS.enabled = false;
        }
        if (Input.GetMouseButtonDown(1))
        {
            attackcontinue = true;
        }else if (Input.GetMouseButtonUp(1))
        {
            attackcontinue = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape) && health > 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            menu.enabled = true;
            crosshair.enabled = false;
        }
        if (attackcontinue == true && ammo != 0)
        {
            attack();
            muzzleFire.SetActive(true);
            if (!gunFire.isPlaying)
            {
                gunFire.PlayOneShot(shot);
                gunFire.loop = true;
            }
        }
        else
        {
            muzzleFire.SetActive(false);
            gunFire.Stop();
        }
        if(health <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            playagain.enabled = true;
            crosshair.enabled = false;
        }
    }

    public void attack()
    {
        if (ammo > 0)
        {
            ammo -= 1;
            RaycastHit Hit;
            if (Physics.Raycast(cm.position, cm.forward, out Hit, bulletMaxDistance))
            {
                ZombieMovement target = Hit.transform.GetComponent<ZombieMovement>();
                if (target == null) return;
                target.gotHit();
                CreateHitEffect(Hit);
            }
            else
            {
                return;
            }
        }
    }

    private void CreateHitEffect(RaycastHit hit)
    {
        GameObject impact = Instantiate(HitEffect, hit.point, Quaternion.LookRotation(hit.normal));
        if (impact != null)
        {
            Destroy(impact, 1f);
        }
    }
}