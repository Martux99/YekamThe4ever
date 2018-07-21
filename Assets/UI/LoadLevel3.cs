using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LoadLevel3 : MonoBehaviour {

    public AudioSource ausi;

    public void ClickIt()
    {
        SceneManager.LoadScene("Level3");
        ausi.Play();
    }
}
