using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goose : MonoBehaviour {

    public GameObject Hans;
    public GameObject Hansd;
    public GameObject Hanss;

    // Hans is the Jumping, Hansd is the ducking, Hanss is the Static.

    // Use this for initialization
    void Start () {
        Hans.SetActive(false);
        Hansd.SetActive(false);
        Hanss.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("down"))
        {
            Hans.SetActive(false);
            Hansd.SetActive(true);
            Hanss.SetActive(false);
        }
        else if (Input.GetKey("up"))
        {
            Hans.SetActive(true);
            Hansd.SetActive(false);
            Hanss.SetActive(false);
        }
        else
        {
            Hans.SetActive(false);
            Hansd.SetActive(false);
            Hanss.SetActive(true);
        }

    }
}
