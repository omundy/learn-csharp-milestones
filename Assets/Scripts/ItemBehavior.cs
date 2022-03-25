using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemBehavior : MonoBehaviour
{
    private GameBehavior GameManager;
    void Start()
    {
        GameManager = GameObject.Find("Game_Manager").GetComponent<GameBehavior>();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Item collected!");
            GameManager.Items += 1;
        }
    }
}

