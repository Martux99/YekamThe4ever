using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renderizado : MonoBehaviour {
    public GameObject yemka;
    public GameObject area1;
    public GameObject area2;
    public GameObject area3;
    
    void Update ()
    {
        if (yemka.transform.position.y < 50 )
        {
            area1.SetActive(true);
        }
        if(yemka.transform.position.y > 50)
        {
            area1.SetActive(false);
        }
        if (yemka.transform.position.y > 35 || yemka.transform.position.y < 140)
        {
            area2.SetActive(true);
        }
        if (yemka.transform.position.y < 35 || yemka.transform.position.y > 140)
        {
            area2.SetActive(false);
        }
        if (yemka.transform.position.y > 130 )
        {
            area3.SetActive(true);
        }
        if (yemka.transform.position.y < 130 )
        {
            area3.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Activation1")
        {
            area1.SetActive(false);
        }
    }
}
