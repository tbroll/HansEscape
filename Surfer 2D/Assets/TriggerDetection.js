#pragma strict
var wave: Transform;
function Start () {
}

function Update () {
}
function OnTriggerEnter (other : Collider) {
		Destroy(other.gameObject);
		Instantiate(wave, Vector3 (115, 10.5, 100), Quaternion.identity); 
	}
