using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect_Collision_With_Obstacle : MonoBehaviour {
    public bool provera_udara;
    public static bool provera_udara_st;
    // Use this for initialization
    void Start () {
        provera_udara = false;
        provera_udara_st = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            provera_udara = true;
            provera_udara_st = true;
        }
    }
}
