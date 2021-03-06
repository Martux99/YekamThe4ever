﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LPlasma : MonoBehaviour {
    public GameObject camaracarnal;
    public GameObject plasma;
    public Collider2D colli;
    public float time = 1f;
    public float timef = 3f;
    bool activo = false;
	void Start ()
    {
        camaracarnal = GameObject.Find("Main Camera");
        SetParent();
        colli.enabled = false;
        StartCoroutine(inicio());
        StartCoroutine(final());
    }
	IEnumerator inicio()
    {
        yield return new WaitForSeconds(time);
        activo = true;
    }
    void SetParent()
    {
        plasma.transform.parent = camaracarnal.transform;
    }
	void Update ()
    {
		if (activo == true)
        {
            colli.enabled = true;
        }
	}
    IEnumerator final()
    {
        yield return new WaitForSeconds(timef);
        Destroy(plasma);
    }
}
