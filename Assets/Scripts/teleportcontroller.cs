using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportcontroller : MonoBehaviour
{
public Transform lobbyPosition;
public Transform arenaPosition;
public Transform battlegroundPosition;
public Transform studioPosition;

    
    public void teleportToLobby()
    {
        transform.position = lobbyPosition.position;

    }
     public void teleportToArena()
    {
        transform.position = arenaPosition.position;

    }
    public void teleportToBattleground()
    {
        transform.position = battlegroundPosition.position;
    }
     public void teleportToStudio()
    {
        transform.position = studioPosition.position;
    }
}