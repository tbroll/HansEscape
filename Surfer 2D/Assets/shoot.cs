using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {

	public GameObject bulletPrefab;

	public Transform bulletSpawn;

	public float bulletSpeed;
	public int CDP = 5;

	//initialization
	void Awake() {
		StartCoroutine(work());
	}
	IEnumerator work() {
		while (true) {
			yield return new WaitForSeconds(5.0f);
			Fire ();
			Debug.Log ("Fire works");
		}
	}
	// Update is called once per frame
	/*void Update () {
		//Attack ();
		//Debug.Log("update function called");
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Fire ();
			Debug.Log ("Fire works");
		}
	}
*/
	void Fire () {
		//create the Bullet from the Bullet prefab
		var bullet = (GameObject)Instantiate (
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		//add velocity
		bullet.GetComponent<Rigidbody>().velocity = -bullet.transform.forward * bulletSpeed;

		//destroy it
		Destroy(bullet, 10f);
	}
	/*private void Attack()
	{
		var timeStamp = Time.time + CDP;
		if (timeStamp <= Time.time) {
			Fire ();
		}
	}*/
}