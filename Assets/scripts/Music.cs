using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {

    public GameObject musicPlayer;

    void Awake()
    {
        musicPlayer = GameObject.Find("MUSIC");
        if (musicPlayer == null)
        {
            musicPlayer = this.gameObject;
            musicPlayer.name = "MUSIC";
            DontDestroyOnLoad(musicPlayer);
        }
        else
        {
            if (this.gameObject.name != "MUSIC")
            {
                Destroy(this.gameObject);
            }
        }
    }
}
