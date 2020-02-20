using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    public int Luckies = 0 ;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Luckies++;
        collision.gameObject.SetActive(false);
    }


}
