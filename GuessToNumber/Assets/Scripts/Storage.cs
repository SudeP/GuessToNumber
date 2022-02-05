using UnityEngine;

public static class Storage
{
    private const string keyAudioSourceEnabled = "audioSourceEnabled";
    public static bool GetAudioSourceEnabled()
    {
        return PlayerPrefs.GetInt(keyAudioSourceEnabled, 1) == 1;
    }
    public static void SetAudioSourceEnabled(bool enabled)
    {
        PlayerPrefs.SetInt(keyAudioSourceEnabled, enabled ? 1 : 0);
        PlayerPrefs.Save();
    }
}