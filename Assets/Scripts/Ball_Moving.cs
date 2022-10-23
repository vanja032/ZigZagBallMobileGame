using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_Moving : MonoBehaviour {
    public bool provera_smera;
    public bool provera_providnosti;
    public RectTransform ball;
    public GameObject sphere_collider;
    public float brzina_pomeranja_loptice; 
    // Use this for initialization
    void Start () {
        
        brzina_pomeranja_loptice = 3f;
        provera_smera = false;
        ball.sizeDelta = new Vector2(Screen.width / 8f, Screen.width / 8f);
        //sphere_collider.transform.localScale = new Vector3(cam.rect.width / 8f, cam.rect.width / 8f, 1);
        this.gameObject.GetComponent<SphereCollider>().radius = Screen.width / 16f;
        provera_providnosti = false;
        ball.transform.position = new Vector3(Screen.width/2, Screen.width/8f, 1);
        //Debug.Log(cam.rect.height);
    }
	
	// Update is called once per frame
	void Update () {
        if(provera_providnosti==false && Detect_Collision_With_Obstacle.provera_udara_st==true)
        {
            this.gameObject.GetComponent<Image>().CrossFadeAlpha(0f, 1f, true);
            provera_providnosti = true;
        }
        if (Detect_Collision_With_Obstacle.provera_udara_st == true)
        {
            
            this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
        }
        if (Detect_Collision_With_Obstacle.provera_udara_st==true)
        {
            return;
        }
        this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x, Screen.width/8f, 1);
        if (provera_smera == false)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + brzina_pomeranja_loptice, Screen.width / 8f,1);
            
        }
        if (provera_smera == true)
        {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - brzina_pomeranja_loptice, Screen.width / 8f, 1);
            
        }
        if(Input.GetMouseButtonDown(0))
        {
            provera_smera = !provera_smera;
        }
        if(this.gameObject.transform.localPosition.x> Screen.width/2 && provera_smera==false)
        {
            this.gameObject.transform.localPosition = new Vector3(-Screen.width / 2, Screen.width/8f, 1);
        }
        if (this.gameObject.transform.localPosition.x < -Screen.width / 2 && provera_smera == true)
        {
            this.gameObject.transform.localPosition = new Vector3(Screen.width / 2, Screen.width / 8f, 1);
        }
    }
}
