using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateInstructions : MonoBehaviour {
    public GameObject instructions, intro, player;
    public AudioClip instructionsSound, selectSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Activate()
    {
        player.GetComponent<AudioSource>().PlayOneShot(selectSound);
        intro.SetActive(false);
        instructions.SetActive(true);
        iTween.ScaleTo(instructions, new Vector3(0.0036f, 0.002f, 0.003f), 1);
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().PlayOneShot(instructionsSound);
    }
}
