#pragma strict
var wave: Transform;

function Start () {
           Instantiate(wave, Vector3 (30, -3.12, 7.48), Quaternion.identity);                
}
function Update () {
		 
}
function OnTriggerEnter (other : Collider) {
		Destroy(other.gameObject);
		Instantiate(wave, Vector3 (30, -3.12, 7.48), Quaternion.identity); 
	}
