﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerPrefab1;
    [SerializeField]
    GameObject PlayerPrefab2;
    [SerializeField]
    GameObject PlayerPrefabGuard;

    int NumberOfPlayers = 1;
    int maxPlayers = 4;



    // Update is called once per frame
    void Update()
    {
        if(NumberOfPlayers > maxPlayers)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SpawnMuse();
        }
        if ( Input.GetKeyDown(KeyCode.P))
        {
            SpawnMuse();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBoth();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            SpawnGuard();
        }


    }

    void SpawnGuard()
    {
        var Guard = PlayerInput.Instantiate(PlayerPrefabGuard);
        NumberOfPlayers++;
    }


    void SpawnBoth()
    {
        var p1 = PlayerInput.Instantiate(PlayerPrefab1);
        var p2 = PlayerInput.Instantiate(PlayerPrefab2);
        NumberOfPlayers += 2;

    }


    void SpawnMuse()
    {
        var p1 = PlayerInput.Instantiate(PlayerPrefab1);
        NumberOfPlayers++;
    }
    void SpawnThief()
    {
        var p2 = PlayerInput.Instantiate(PlayerPrefab2);
        NumberOfPlayers++;
    }

    //    https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.PlayerInput.html
    //var p1 = PlayerInput.Instantiate(playerPrefab,
    //    controlScheme: "KeyboardLeft", device: Keyboard.current);
    //    var p2 = PlayerInput.Instantiate(playerPrefab,
    //        controlScheme: "KeyboardRight", device: Keyboard.current);




}
