using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour {

    public GameObject Panel;

    public void ResumeItUp()
    {
        Panel.SetActive(false);
        Time.timeScale = 1f;        
    }
}
