using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasRegister : MonoBehaviour {
	void Start () {
		GameDataManger.manager.mainCanvas = transform;
	}
}
