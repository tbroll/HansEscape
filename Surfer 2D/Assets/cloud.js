﻿// Scroll main texture based on time

public var scrollSpeed : float = 0.5;
var rend: Renderer;


function Start() {
	rend = GetComponent.<Renderer>();
}


function Update () {
	var offset : float = Time.time * scrollSpeed;
	rend.material.SetTextureOffset("_MainTex", Vector2(offset,0));
}
