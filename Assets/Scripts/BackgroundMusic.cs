using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{

    AudioSource fxSound;
    // Start is called before the first frame update
    void Start()
    {
        fxSound = GetComponent<AudioSource>();
        fxSound.Play();
    }
}
