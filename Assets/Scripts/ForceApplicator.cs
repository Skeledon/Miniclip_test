using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceApplicator : MonoBehaviour
{
    public Rigidbody rigid;
    public float value;
	// Use this for initialization
	void Start ()
    {
        rigid.AddForce((transform.up * value), ForceMode.Acceleration);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void FixedUpdate()
    {

    }
}
