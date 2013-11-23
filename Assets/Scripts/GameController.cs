using UnityEngine;
using System.Collections;
//TEAMWORK 2
//6.35
//3.75
//.5
public class GameController : MonoBehaviour {
	public GameObject aCube;
	private int gridWidth = 8;
	private int gridHeight = 5;
	private GameObject[,] cubes;
	public int numColors = 6;
	public Color [] cubeColor;




	// Use this for initialization



	void Start () {
		cubeColor = new Color[numColors];
		cubeColor[0] = Color.black;
		cubeColor[1] = Color.blue;
		cubeColor[2] = Color.green;
		cubeColor[3] = Color.red;
		cubeColor[4] = Color.yellow;
		cubeColor[5] = Color.white;



		//creates the array's width and height to be instantiated
		cubes = new GameObject [gridWidth,gridHeight];
		//make the 8 x 5 grid of white cubes
		for (int x = 0; x < gridWidth; x++) {
			for (int y = 0; y < gridHeight; y++){
				cubes[x,y] = (GameObject) Instantiate(aCube, new Vector3(0 + 2*x, y*2, -10), Quaternion.identity);
				cubes[x,y].renderer.material.color = changeColor();
			}
		}

		if(detectVertColorLine) {
			print("It was true");
		}

		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public Color changeColor(){
		return cubeColor[Random.Range(0,numColors)];
	}

	//search for three of the same colors in a row, or more and change them
	public bool detectVertColorLine (int x, int y){
		if (cubes [x,y].transform.renderer.material.color == cubes [x+1,y].transform.renderer.material.color&&
		    cubes [x,y].transform.renderer.material.color == cubes [x+2,y].transform.renderer.material.color)
		{
			return true;
		}

		else {
			return false;
		}
	}

	//public bool detectHorColorLine (int x, int y) {

	//}
}
