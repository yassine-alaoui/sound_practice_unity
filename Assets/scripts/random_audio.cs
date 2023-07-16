using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random_audio : MonoBehaviour
{
    private AudioSource this_audio;
    private void Start()
    {
        this_audio = GameObject.FindAnyObjectByType<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        this_audio.maxDistance = Random.Range(10, 100);
        if (Random.value > 0.8 && !this_audio.isPlaying)
            this_audio.Play();
    }
}
