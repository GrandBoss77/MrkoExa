using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class AudioManager
{
    public static void PlaySound(AudioClip clip, Vector3 position, float volume = 1f)
    {
        if(clip == null){ return; }
        
        Vector3 pos = position;
        if (Camera.main != null)
        {
            pos = Camera.main.transform.position;
        }
        
        AudioSource.PlayClipAtPoint(clip, pos,volume);
    }
}
