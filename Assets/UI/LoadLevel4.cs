using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LoadLevel4 : MonoBehaviour {

    public AudioSource ausi;

    public void ClickIt()
    {
        SceneManager.LoadScene("Level4");
        ausi.Play();
    }
}
