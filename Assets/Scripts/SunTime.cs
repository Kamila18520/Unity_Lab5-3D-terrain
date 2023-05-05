using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunTime : MonoBehaviour
{
    [SerializeField] private float daySpeed = 0.005f;

    // Update is called once per frame
    void Update()
    {
        this.transform.RotateAround(Vector3.zero, Vector3.right , daySpeed);
    }
}
