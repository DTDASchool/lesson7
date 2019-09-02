using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killzone : MonoBehaviour
{
	public float position;
	public GameObject spawnLocation;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
		other.gameObject.transform.localPosition = spawnLocation.transform.localPosition;   
    }

    // Update is called once per frame
    void Update()
    {
		
        
    }
}
