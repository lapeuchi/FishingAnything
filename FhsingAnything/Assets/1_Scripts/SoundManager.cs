using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    
    AudioSource _audio;

    public AudioClip Click;
    public AudioClip FishMove;
    public AudioClip Catch;
    public AudioClip Sharf; //게임 1 단계에서 낚았을 때 효과음
    public AudioClip BGM;

    public AudioClip StarWars;
    public AudioClip TTS;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
        PlayIntro();
    }

    private void FixedUpdate()
    {   
        PlayBGM();
    }

    public void PlayClickSound()
    {
        _audio.PlayOneShot(Click);
        
    }
    public void PlayFishMoveSound()
    {
        _audio.PlayOneShot(FishMove);
    }
    public void PlayCatchSound()
    {
        _audio.PlayOneShot(Catch);
    }
    public void PlaySharfSound()
    {
        _audio.PlayOneShot(Sharf);
    }

    public void PlayBGM()
    {
        if (_audio.isPlaying) return;
        _audio.PlayOneShot(BGM);
    }

    public void StopBGM()
    {
        _audio.Stop();
    }

    public void PlayIntro()
    {
        _audio.PlayOneShot(StarWars);
        _audio.PlayOneShot(TTS);
    }

    public void StopIntro()
    {
        _audio.Stop();
    }
}
