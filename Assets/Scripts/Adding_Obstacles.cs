using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adding_Obstacles : MonoBehaviour {
    public GameObject brick;
    public GameObject parent_za_prepreke;
    public float nivo_postavljanja_prepreka;
    public Camera cam;
    GameObject prepreka1;
    // Use this for initialization
    void Start () {
        PlayerPrefs.SetFloat("brzina", 3.0f);
        Example();
        nivo_postavljanja_prepreka = 2f;
    }
	
	// Update is called once per frame
	void Update () {
        if (prepreka1.transform.localPosition.y < 0)
        {
            if (Detect_Collision_With_Obstacle.provera_udara_st == false)
            {
                if (nivo_postavljanja_prepreka > 1.5f)
                {
                    nivo_postavljanja_prepreka -= 0.02f;
                    this.gameObject.GetComponent<Ball_Moving>().brzina_pomeranja_loptice += 0.1f;
                }
                Example();
                
            }
        }
    }

    void Example()
    {
        
            prepreka1 = Instantiate(brick, new Vector3(0, 0, 0), Quaternion.identity);
            var prepreka2 = Instantiate(brick, new Vector3(0, 0, 0), Quaternion.identity);
        
            prepreka1.transform.parent = parent_za_prepreke.transform;
            prepreka2.transform.parent = parent_za_prepreke.transform;

            prepreka1.transform.localPosition = new Vector3(-cam.rect.width / 4f, cam.rect.height/2, 2);
            prepreka2.transform.localPosition = new Vector3(cam.rect.width / 4f, cam.rect.height/2, 2);


            prepreka1.transform.localScale = new Vector3(cam.rect.width / 8f, cam.rect.width / 8f, cam.rect.width / 8f);
            prepreka2.transform.localScale = new Vector3(cam.rect.width / 8f, cam.rect.width / 8f, cam.rect.width / 8f);

        
        
        PlayerPrefs.SetFloat("brzina", PlayerPrefs.GetFloat("brzina")+0.2f);
        
        


    }
}
