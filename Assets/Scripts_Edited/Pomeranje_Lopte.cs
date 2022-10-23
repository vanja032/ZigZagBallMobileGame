using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pomeranje_Lopte : MonoBehaviour {
    public Camera camera;
	// Use this for initialization
	void Start () {
        camera.rect = new Rect(0, 0, Screen.width, Screen.height);
        this.gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(camera.rect.width/8, camera.rect.width/8);
        this.gameObject.transform.localPosition= new Vector3(0,233);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
