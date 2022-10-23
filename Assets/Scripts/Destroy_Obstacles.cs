using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy_Obstacles : MonoBehaviour {
    public Camera cam;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        cam = GameObject.FindObjectOfType<Camera>();
       /* if (this.gameObject.transform.localPosition.y < cam.rect.width / 8f)
        {
            this.gameObject.GetComponent<Image>().CrossFadeAlpha(0f, 0.5f, true);
        }*/
		if(this.gameObject.transform.localPosition.y < -cam.rect.height/1.5f)
        {
            Destroy(this.gameObject);
        }
	}
}
