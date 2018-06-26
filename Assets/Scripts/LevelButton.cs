using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LevelButton : MonoBehaviour {

	public Button btn;
	public List<Image> fires;
	//this levelnumber is not array safe
	public int levelNumber;
	public Sprite fireTexture;
	public Sprite fireTextureBlue;
	public Text levelText;
	public bool unlocked;
	public GameObject lockedImage;

	
	

}
