using UnityEngine;
using System.Collections;

public class cubered : MonoBehaviour {

	GameObject objCubegreen1;
	GameObject objCubeGreen2;
	bool flag = false;

	// Use this for initialization
	void Start () {
		objCubegreen1 = GameObject.Find("CubeGreen1");
		objCubeGreen2 = GameObject.Find("CubeGreen2");
		objCubegreen1.SetActive(false);
		objCubeGreen2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		// включить или отключить меню
		if (flag){
			if (aaa.cubechecked) {
				// включить детишек
				objCubegreen1.SetActive(true);
				objCubeGreen2.SetActive(true);
			}
			else {
				// отключить детишек
				objCubegreen1.SetActive(false);
				objCubeGreen2.SetActive(false);
			}
			flag = false;
		}
	}

	void OnMouseDown() {
		Debug.Log("cubered: mouse down");
		aaa.cubeclicked = true;
		flag = true;
	}

	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}

	void OnMouseExit(){  
		renderer.material.color = Color.red;  
	}  
}
