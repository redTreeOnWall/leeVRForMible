using UnityEngine;
using System.Collections;

public class MoveCountroler : MonoBehaviour {

	public Transform text;
	public  Transform head;
	public  float speed;
	class Controller{
		public bool JoystickButton0=false;
		public bool JoystickButton1=false;
		public bool JoystickButton3=false;
	}
	Controller con = new Controller();
	// Use this for initialization
	void Start () {
	}

	// JoystickButton0 



	void OnGUI(){


		text.GetComponent<TextMesh> ().text = Input.GetAxis ("Horizontal").ToString()+"<-h::v->"+Input.GetAxis ("Vertical");


//		if (Input.anyKeyDown) {
//			Event e = Event.current;
//			KeyCode kc = e.keyCode;
//			text.GetComponent<TextMesh> ().text = kc.ToString();
//		}

		if (Input.GetKeyDown (KeyCode.JoystickButton0)) {
			con.JoystickButton0 = true;
		}
		if (Input.GetKeyUp (KeyCode.JoystickButton0)) {
			con.JoystickButton0 = false;
		}

		if (Input.GetKeyDown (KeyCode.JoystickButton1)) {
			con.JoystickButton1 = true;
		}
		if (Input.GetKeyUp (KeyCode.JoystickButton1)) {
			con.JoystickButton1 = false;
		}

		if (Input.GetKeyDown (KeyCode.JoystickButton3)) {
			con.JoystickButton3 = true;
		}
		if (Input.GetKeyUp (KeyCode.JoystickButton3)) {
			con.JoystickButton3 = false;
		}
	}

	Vector3 v = new Vector3 ();
	Vector3 mv = new Vector3 ();

	// Update is called once per frame
	void Update () {
		v.Set (transform.eulerAngles.x,head.eulerAngles.y,transform.eulerAngles.z);
		transform.eulerAngles = v;
	//	text.GetComponent<TextMesh> ().text = head.eulerAngles.ToString () + "::" + this.transform.eulerAngles.ToString();
		mv.Set(Input.GetAxis ("Horizontal"),0,Input.GetAxis ("Vertical"));
		transform.Translate (mv * speed *Time.deltaTime);

//		if(con.JoystickButton1){
//			transform.Translate (-Vector3.forward * speed *Time.deltaTime);
//		}
	//	text.GetComponent<TextMesh> ().text = con.JoystickButton3.ToString();
	}
}
