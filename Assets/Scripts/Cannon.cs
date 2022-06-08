using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{

    public GameObject Crosshair;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Camera.current == null)
        {
            return;
        }
        Ray ray = Camera.current.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            transform.LookAt(hit.point);
            transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
            Crosshair.transform.position = hit.point;
        }
    }
}
