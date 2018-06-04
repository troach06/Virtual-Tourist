using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public AudioClip[] narrationSounds;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Teleport(GameObject pad)
    {
        Camera.main.gameObject.GetComponent<AudioSource>().Stop();
        player.GetComponent<AudioSource>().Play();
        PlayAudioClip(pad.tag);
        player.transform.position = new Vector3(pad.transform.position.x, Camera.main.transform.position.y, pad.transform.position.z);
    }
    public void PlayAudioClip(string clipToPlay)
    {
        foreach (AudioClip clip in narrationSounds)
        {
            if (clip.name == clipToPlay)
                GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
