using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLineDrawer : MonoBehaviour
{
    public LineRenderer lr;
    public Camera cam;
    public LayerMask mask;


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
            GetInputPosition();
        else
            ResetPositions();
	}

    void GetInputPosition()
    {
        Ray r = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(r, out hit, 10, mask))
        {
            lr.positionCount ++;
            lr.SetPosition(lr.positionCount - 1, hit.point);
        }

    }

    void ResetPositions()
    {
        lr.positionCount = 0;
    }
}
