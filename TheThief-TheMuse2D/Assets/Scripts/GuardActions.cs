using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardActions : MonoBehaviour
{
    private bool isPlayerInGuardView;
    public Transform GuardView;
    public float GuardViewRadius = 8f;
    public LayerMask WhatIsPlayerLayer;

    PlayerSpawn playerSpawn;
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("PlayerInputManager");
        playerSpawn = go.GetComponent<PlayerSpawn>();
        
    }

    private void Update()
    {
        IsPlayerInGaurdView();
    }

    public void IsPlayerInGaurdView( )
    {
        bool isPlayerInGuardView = Physics2D.OverlapCircle(GuardView.position, GuardViewRadius, WhatIsPlayerLayer);
        if (isPlayerInGuardView)
        {
            playerSpawn.PlayerInGaurdView();
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(GuardView.position, GuardViewRadius);
    }



}
