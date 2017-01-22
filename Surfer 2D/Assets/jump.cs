using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

	public int jumpSpeed = 100;
    public bool jumpk = true;
    public Rigidbody rb;

        // Use this for initialization
        void Start () {

        }
	
	// Update is called once per frame
	void Update () {
        if (jumpk == true && Input.GetKeyDown("up"))
        {
            jumpk = false;
            rb.AddForce(Vector3.up * jumpSpeed);
        }
 
        /*if (Input.GetKeyDown ("space")){
			transform.position += transform.up*jumpSpeed*Time.deltaTime;
		}
        */
    }
    void OnTriggerEnter(Collider other)
    {
        jumpk = true;
    }
    private void OnTriggerExit(Collider other)
    {
        jumpk = false;
    }
}
