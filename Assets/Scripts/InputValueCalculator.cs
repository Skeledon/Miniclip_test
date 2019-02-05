using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputValueCalculator : MonoBehaviour
{
    public Camera cam;

    private Vector2 min;
    private float maxY;
    private float maxX;

    public Vector2 ResultVector { get; private set; }


	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            ResultVector = ValueConverter();
        }
        else
        {
            min = Vector2.zero;
            maxX = 0;
            maxY = 0;
        }
    }

    Vector2 ValueConverter()
    {
        Vector3 pos = Input.mousePosition;
        pos = cam.ScreenToViewportPoint(pos);
        if (min == Vector2.zero)
            min = pos;
        maxY = Mathf.Max(pos.y - min.y, maxY);
        if(Mathf.Abs(pos.x - min.x) > Mathf.Abs(maxX))
        {
            maxX = pos.x - min.x;
        }
        return new Vector2(maxX, maxY);
    }
}
