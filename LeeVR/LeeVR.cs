using UnityEngine;
using System.Collections;

public class LeeVR : MonoBehaviour {

	//bool gyroBool;  
	Gyroscope gyro; 
	void Awake()  
	{  
		//gyroBool = true;  
		//if (gyroBool) {  
		gyro = Input.gyro;  

		gyro.enabled = true;  

	}  
	void Update()  
	{  
		Vector3 gyroEl = gyro.attitude.eulerAngles;
		gyroEl.Set (-gyroEl.x,-gyroEl.y,gyroEl.z);
		this.transform.eulerAngles = gyroEl;
		transform.Rotate(Vector3.right * 90, Space.World);
	}  
}
