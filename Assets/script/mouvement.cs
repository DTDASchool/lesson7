using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
	public float mouvSpeed;
	public float force;
	public Rigidbody rb;
	public Animator animation;
	public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
		animation.SetBool("Grounded", true);
    }
	

    // Update is called once per frame
    void Update()
    {
        float tempV = Input.GetAxis ("Vertical");
		float tempH = Input.GetAxis ("Horizontal");
		//Debug.Log(transform.position);
		if(Input.GetKeyDown("space"))
			{
				rb.AddForce(transform.up*force);
			}
		if(new Vector3(tempH, 0f, tempV) != Vector3.zero){
			transform.position = new Vector3 (transform.position.x + tempH * Time.deltaTime * mouvSpeed, transform.position.y, transform.position.z + tempV * Time.deltaTime * mouvSpeed);
			transform.rotation = Quaternion.LookRotation (new Vector3 (tempH, 0f, tempV));
			  
			   
			
			if(tempV<0)
				tempV *= -1;
			if( tempH<0)
				tempH *= -1;
			animation.SetFloat("MoveSpeed", (tempH + tempV));
		
		}
    }
}
