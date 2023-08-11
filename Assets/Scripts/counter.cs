using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class counter : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI count;
    public TextMeshProUGUI countt;
    public int deathcount = 0;

    public void countDeath()
    {
        deathcount += 1;
        text.text = "kills:- " + deathcount.ToString();
        count.text = "kills:- " + deathcount.ToString();
        countt.text = "kills:- " + deathcount.ToString();
    }
}
