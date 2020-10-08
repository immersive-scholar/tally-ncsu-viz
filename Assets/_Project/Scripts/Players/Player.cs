﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public string username;
    public string avatarPath;


    private void Awake ()
    {
        StartCoroutine (StartChecks ());
    }

    public void Init (string username, string avatarPath)
    {
        Debug.Log ("Player.Init() username = " + username);

        this.username = username;
        this.avatarPath = avatarPath;
    }

    /**
     *  Hide if no username
     */
    IEnumerator StartChecks ()
    {
        yield return new WaitForSeconds (1f);

        // you left your toys out
        if (username == null || username == "")
            gameObject.SetActive (false);
    }



}
