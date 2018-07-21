using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject Panel;

    public void pauseItUp()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
    }

}
