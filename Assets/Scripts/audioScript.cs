using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{

    AudioSource audioSource;
    public Sound[] clips;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in clips) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
