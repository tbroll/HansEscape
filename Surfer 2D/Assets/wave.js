#pragma strict

var deadHans = false;

function Start () {
}
function Update () {
if (deadHans == true) {
Application.LoadLevel(2);
}
}
function OnTriggerEnter (other:Collider){
 if (other.gameObject.tag == "Player")
    {
       Destroy(other.gameObject);
       deadHans = true;

       }
       }