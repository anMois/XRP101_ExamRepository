using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControll : MonoBehaviour
{
    [SerializeField] AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void PlayerDie()
    {
        _audio.Play();
    }
}
