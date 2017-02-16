using UnityEngine;
using System.Collections;

public class shooter : MonoBehaviour {

	public Transform[] balls;
	public Transform shootObj;
	public Transform head;
	public  float f=10.0f;
	int shootingBall=0;
	// Use this for initialization
	void Start () {
		
	}

	KeyCode shKeyCode =KeyCode.JoystickButton0;
	bool shootAble = true;
	void OnGUI(){
		if (Input.GetKeyDown (shKeyCode)) {
			if(shootAble){
				this.shoot ();
				Debug.LogError ("shoting");
			}
			shootAble = false;
		}
		if (Input.GetKeyUp (shKeyCode)) {
			shootAble =true;
		}
	}

	public void shoot(){
		this.balls [shootingBall].GetComponent<SphereCollider> ().enabled = false;
		this.balls [shootingBall].position = shootObj.position;
	//	Vector3 vtemp = new Vector3();
	//	vtemp.Set (shootObj.eulerAngles.x,shootObj.eulerAngles.y,shootObj.eulerAngles.z);
		this.balls [shootingBall].eulerAngles = new Vector3(shootObj.eulerAngles.x,shootObj.eulerAngles.y,shootObj.eulerAngles.z);
		Debug.LogError (this.balls [shootingBall].eulerAngles+"<-ball shooter->"+shootObj.eulerAngles);
		this.balls [shootingBall].GetComponent<SphereCollider> ().enabled = true;
		this.balls [shootingBall].GetComponent<Rigidbody> ().velocity = new Vector3(0.0f,0.0f,0.0f);
		this.balls [shootingBall].GetComponent<Rigidbody> ().AddRelativeForce (Vector3.forward*f);
		if (shootingBall < 8) {
			shootingBall++;
		} else {
			shootingBall = 0;
			Debug.LogError("====================0");
		}
	}
}
