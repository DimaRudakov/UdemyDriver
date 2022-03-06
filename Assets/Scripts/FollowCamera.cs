using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followObject;
    [SerializeField] int cameraDistance;

    void LateUpdate()
    {
        transform.position = followObject.transform.position + new Vector3 (0, 0, -cameraDistance);
    }
}
