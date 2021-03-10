﻿using UnityEngine;

public class SpeedPower : MonoBehaviour {
    public float increase = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            GameObject player = collision.gameObject;
            Player playerScript = player.GetComponent<Player>();
            Debug.Log("HIT!");

            if (playerScript)
            {
                playerScript.MovementSpeed += increase;
                Destroy(gameObject);

            }
        }
    }

}
