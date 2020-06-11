using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenager : MonoBehaviour
{
    public static AudioSource sound;
    public static AudioSource explosion;
    public static AudioSource metal;
    public static AudioSource teleport;
    public static AudioSource rune;
    public static AudioSource gameOver;
    public AudioSource soundBum;
    public AudioSource barrelExplosion;
    public AudioSource metalCrash;
    public AudioSource teleportSound;
    public AudioSource runehit;
    public AudioSource gameOverSound;

    private void Start()
    {
        sound = soundBum;
        explosion = barrelExplosion;
        metal = metalCrash;
        teleport = teleportSound;
        rune = runehit;
        gameOver = gameOverSound;
    }
}
