using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Shadow : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Example2());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Example2()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
