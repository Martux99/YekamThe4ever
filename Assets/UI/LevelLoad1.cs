using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LevelLoad1 : MonoBehaviour {

    public AudioSource ausi;

    public void ClickIt()
    {
        SceneManager.LoadScene("Level1");
        ausi.Play();
    }
}
