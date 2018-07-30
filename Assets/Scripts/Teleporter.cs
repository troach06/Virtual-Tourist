using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player, user;
    public AudioClip[] narrationSounds;

    // Use this for initialization
    void Start()
    {
        user = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Teleport player to pad location
    public void Teleport(GameObject pad)
    {
        user.GetComponent<AudioSource>().Stop();
        player.GetComponent<AudioSource>().Play();
        PlayAudioClip(pad.tag);
        player.transform.position = new Vector3(pad.transform.position.x, Camera.main.transform.position.y, pad.transform.position.z);
    }

    // Play narration audio
    public void PlayAudioClip(string clipToPlay)
    {
        foreach (AudioClip clip in narrationSounds)
        {
            if (clip.name == clipToPlay)
                GetComponent<AudioSource>().PlayOneShot(clip);
        }
    }
}
