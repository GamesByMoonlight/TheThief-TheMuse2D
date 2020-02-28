using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField]
    GameObject PlayerPrefab1;
    [SerializeField]
    GameObject PlayerPrefab2;

    int NumberOfPlayers = 1;
    int maxPlayers = 2;

    public Vector2 Player1Restart;
    public Vector2 Player2Restart;


    // Update is called once per frame
    void Update()
    {
        if(NumberOfPlayers > maxPlayers)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            SpawnMuse();
        }
        if ( Input.GetKeyDown(KeyCode.P))
        {
            SpawnThief();
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBoth();
        }
    }
    void SpawnBoth()
    {
        var p1 = PlayerInput.Instantiate(PlayerPrefab1);
        var p2 = PlayerInput.Instantiate(PlayerPrefab2);
        NumberOfPlayers += 2;

    }


    void SpawnMuse()
    {
        var p1 = PlayerInput.Instantiate(PlayerPrefab2);
        NumberOfPlayers++;
    }
    void SpawnThief()
    {
        var p2 = PlayerInput.Instantiate(PlayerPrefab1);
        NumberOfPlayers++;
    }

    //    https://docs.unity3d.com/Packages/com.unity.inputsystem@1.0/api/UnityEngine.InputSystem.PlayerInput.html
    //var p1 = PlayerInput.Instantiate(playerPrefab,
    //    controlScheme: "KeyboardLeft", device: Keyboard.current);
    //    var p2 = PlayerInput.Instantiate(playerPrefab,
    //        controlScheme: "KeyboardRight", device: Keyboard.current);


    public void PlayerInGaurdView()
    {

        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");
        if (allPlayers.Length > 1)
        {
            allPlayers[0].transform.position = new Vector3(Player1Restart.x, Player1Restart.y);
            allPlayers[1].transform.position = new Vector3(Player2Restart.x, Player2Restart.y);
        }
        else if (allPlayers.Length > 0)
        {
            allPlayers[0].transform.position = new Vector3(Player1Restart.x, Player1Restart.y);
        }
    }


}
