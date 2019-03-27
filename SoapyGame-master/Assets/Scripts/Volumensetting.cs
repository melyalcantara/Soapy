using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumensetting : MonoBehaviour
{
    public Slider volume;
    public AudioSource mymusic;

    // Update is called once per frame
    void Update()
    {
        mymusic.volume = volume.value;

    }
}
