using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform TruckPos;
    public Transform MapPos;
    [Space(10)]
    public Vector3 aimedPos;
    public float speed = 3f;

    [Button]
    private void Awake()
    {
        aimedPos = TruckPos.position - (Vector3.forward * 10f);
        transform.position = aimedPos;
    }

    public void GoToTruck() 
    {
        aimedPos = TruckPos.position - (Vector3.forward * 10f);
    }
    public void GoToMap()
    {
        aimedPos = MapPos.position - (Vector3.forward * 10f);
    }

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, aimedPos, Time.deltaTime * speed);
    }
}
