using UnityEngine;


public class PlayerMovement : MonoBehaviour {

public Rigidbody rb;
public float forwardForce = 2000f;
public float sideForce = 500f;
	void Update () {
		rb.AddForce(0,0,forwardForce*Time.deltaTime);	
	
		if(Input.GetKey("d")){
			rb.AddForce(sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);		
		}
		
		if(Input.GetKey("a")){
			rb.AddForce(-sideForce*Time.deltaTime,0,0,ForceMode.VelocityChange);		
		}
		
		if(rb.position.y <= -0.7f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
