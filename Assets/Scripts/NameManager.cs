﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NameManager : MonoBehaviour
{
      public void SetPlayerName(string playername)
    {
        if(string.IsNullOrEmpty(playername))
        {
            Debug.Log("Player name is empty");
            return;
        }
        PhotonNetwork.NickName = playername;

    }
}
