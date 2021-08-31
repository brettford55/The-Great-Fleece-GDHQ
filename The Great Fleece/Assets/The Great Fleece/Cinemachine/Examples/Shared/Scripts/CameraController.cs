using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform CameraOrigin;
    // Start is called before the first frame update
    void Start()
    {
        Camera.main.transform.position= CameraOrigin.position;
        Camera.main.transform.rotation = CameraOrigin.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
