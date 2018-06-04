using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Photosphere : MonoBehaviour {
    bool inSphere;
    GameObject sphereObj;
    Vector3 initPos;
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (inSphere && Input.GetMouseButton(0))
        {
            ExitSphere();
        }
	}
    public void EnterSphere(GameObject sphere)
    {
        initPos = sphere.transform.position;
        sphereObj = sphere;
        sphere.GetComponent<AudioSource>().Play();
        inSphere = true;
        iTween.ScaleTo(sphere, new Vector3(3, 3, 3), 2);
        sphere.transform.position = player.transform.position;
        sphere.GetComponent<Float>().enabled = false;
    }
    public void ExitSphere()
    {
        inSphere = false;
        iTween.ScaleTo(sphereObj, new Vector3(0.75f, 0.75f, 0.75f), 1);
        sphereObj.transform.position = initPos;
        sphereObj.GetComponent<Float>().enabled = true;
    }
}
