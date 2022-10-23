using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Shadow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Detect_Collision_With_Obstacle.provera_udara_st == true)
        {
            return;
        }
        this.gameObject.transform.localPosition = new Vector3(this.gameObject.transform.localPosition.x, this.gameObject.transform.localPosition.y - 2, this.gameObject.transform.localPosition.z);
    }
}
