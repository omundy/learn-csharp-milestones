using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletBehavior : MonoBehaviour
{
    // 1
    public float OnscreenDelay = 3f;

    void Start()
    {
        // 2
        Destroy(this.gameObject, OnscreenDelay);
    }
}
