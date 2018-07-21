using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PlaayItUp : MonoBehaviour {

    public GameObject Panel;
    public AudioSource ausi;

    public void SelectItUp()
    {
        Panel.SetActive(true);
        ausi.Play();
    }

}
