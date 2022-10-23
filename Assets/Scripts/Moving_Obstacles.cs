using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Obstacles : MonoBehaviour {
    public float brzina_pomeranja_prepreka = 0f;
	// Use this for initialization
	void Start () {
		brzina_pomeranja_prepreka= PlayerPrefs.GetFloat("brzina");
    }
	
	// Update is called once per frame
	void Update () {
        if (Detect_Collision_With_Obstacle.provera_udara_st == true)
        {
            return;
        }
        brzina_pomeranja_prepreka = PlayerPrefs.GetFloat("brzina");
        //this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y - 1, this.gameObject.transform.position.z);
        this.gameObject.GetComponent<CharacterController>().Move(Vector3.down * 0.01f);
	}
}
