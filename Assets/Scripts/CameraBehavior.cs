using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraBehavior : MonoBehaviour
{
    // 1
    public Vector3 CamOffset = new Vector3(0f, 1.2f, -2.6f);
    // 2
    private Transform _target;
    void Start()
    {
        // 3
        _target = GameObject.Find("Player").transform;
    }
    // 4
    void LateUpdate()
    {
        // 5
        this.transform.position = _target.TransformPoint(CamOffset);
        // 6
        this.transform.LookAt(_target);
    }
}
