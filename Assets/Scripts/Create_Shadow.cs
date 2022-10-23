using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Create_Shadow : MonoBehaviour {
    public GameObject ball;
    public GameObject parent_za_ball;
    public Camera cam;
    public RectTransform kanvas;//kanvas-x => width     kanvas-y => height
    // Use this for initialization
    void Start () {
        StartCoroutine(Example1());
        ball.GetComponent<RectTransform>().sizeDelta =  new Vector2(kanvas.sizeDelta.x/8f, kanvas.sizeDelta.x / 8f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Example1()
    {
        
        var ball1 = Instantiate(ball, new Vector3(0, 0, 0), Quaternion.identity);
        ball1.transform.parent = parent_za_ball.transform;
        ball1.transform.localPosition = new Vector2(this.gameObject.transform.localPosition.x, this.gameObject.transform.localPosition.y);
        ball1.transform.localScale = new Vector3(1, 1, 1);

        ball1.GetComponent<Image>().CrossFadeAlpha(0f, 0.4f, true);
        ball1.AddComponent<Destroy_Shadow>();
        ball1.AddComponent<Moving_Shadow>();
        yield return new WaitForSeconds(0.17f);
        if (Detect_Collision_With_Obstacle.provera_udara_st == false)
        {
            StartCoroutine(Example1());
        }
        

    }
}
