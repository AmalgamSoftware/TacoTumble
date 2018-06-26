using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageGradientScroller : MonoBehaviour {


	public Image img;
	public Text txt;
    public Material mat;
    public string colorName;
    private int colorHash;
	private bool imgExists = false, txtExists = false, matExists = false;
	public float speed;
	public Gradient grad;
    [HideInInspector]
	public float counter = 0f;
	[HideInInspector]
	private Color currentColor;
	// Use this for initialization
	void Start () {
		
		if (img != null) {
			imgExists = true;
		}
		
		if (txt != null) {
			txtExists = true;
		}
        if(mat != null)
        {
            matExists = true;
            colorHash = Shader.PropertyToID(colorName);
        }
	}
	
	// Update is called once per frame
	void Update () {
		currentColor = grad.Evaluate(counter);
		if (imgExists) {
			img.color = currentColor;
		}
		if (txtExists) {
			txt.color = currentColor;
		}
        if (matExists)
        {
            mat.SetColor(colorHash, currentColor);
        }
		counter += Time.deltaTime * speed * 0.1f;
		//Debug.Log (counter);
		if (counter > 1f) {
			counter -= 1f;
		}
	}
}
