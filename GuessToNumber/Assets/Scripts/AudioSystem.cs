using System.Linq;
using UnityEngine;

/// <summary>
/// Manage Audio Proccesses
/// </summary>
[RequireComponent(typeof(AudioSource))]
#pragma warning disable // for name rules
public class AudioSystem : CacheBehaviour<AudioSystem>
{
    private AudioSource audioSource;
    [SerializeField] private AudioClipData[] audioClips;
    private void Start()
    {
        #region Components
        //set audioSource in GameObject
        audioSource = GetComponent<AudioSource>();
        //disable loop
        audioSource.loop = false;
        #endregion
    }
    public void Play(AudioType audioType)
    {
        //client enabled audio System
        if (Storage.GetAudioSourceEnabled())
        {
            //get audio with audioType
            AudioClipData audioClipData = audioClips.FirstOrDefault(x => x.type == audioType);

            //if linq not find data, linq return AudioType.None
            if (audioClipData.type == AudioType.None)
                return;

            //set audioClip
            audioSource.clip = audioClipData.clip;

            //play audioClip
            audioSource.Play();
        }
    }
}
#pragma warning restore