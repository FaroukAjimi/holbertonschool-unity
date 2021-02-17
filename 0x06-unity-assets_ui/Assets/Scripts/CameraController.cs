using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float rs;
    public Transform pivot;
    public bool isInverted;
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        offset = target.position - transform.position;
        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float hrzntl = Input.GetAxis("Mouse X") * (rs);
        target.Rotate(0,hrzntl,0);
        float vrtcl = Input.GetAxis("Mouse Y") * (rs);
        pivot.Rotate(vrtcl, 0,0); 
        float day = target.eulerAngles.y;
        float dax = pivot.eulerAngles.x;
        if(!isInverted){
        rotation = Quaternion.Euler(dax ,day, 0);
        }else{
            rotation = Quaternion.Euler(-dax ,day, 0);
        }
        transform.position = target.position - (rotation * offset);
        transform.LookAt(target);
    }
}
