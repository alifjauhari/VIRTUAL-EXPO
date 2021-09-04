using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OnlineVideoLoader : MonoBehaviour
{
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField, Tooltip("Video Link")] string url;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.url = url;
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
    }
}
