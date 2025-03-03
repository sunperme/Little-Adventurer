using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float Speed = 80f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, Speed * Time.deltaTime, 0), Space.World);
    }
}
