using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillItUp : MonoBehaviour {

    public Image Fill;
    public GameObject Player;
    public PlayerMovement Sauce;

    public void Awake()
    {
        Sauce=Player.GetComponent<PlayerMovement>();
    }

    public void FixedUpdate()
    {
        Fill.fillAmount = (10f-Sauce.tiempo)/10f;
    }

}
