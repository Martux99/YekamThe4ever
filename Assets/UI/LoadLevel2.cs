using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LoadLevel2 : MonoBehaviour {

    public AudioSource ausi;

    public void ClickIt()
    {
        SceneManager.LoadScene("Level2");
        ausi.Play();
    }
}
