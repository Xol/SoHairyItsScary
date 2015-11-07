using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {
    public Transform CubeForFloor;
	public Transform CubeForStoneFloor;
	public Transform CubeForWater;

	GameManager GM;
	GameLevel currentArea;

    void Start()
    {
		GM = GameManager.Instance;
		currentArea = GM.getCurrentGameLevel();
		for (int rowIndex=0; rowIndex<GameLevel.EDGE_SIZE_X; rowIndex++) {
			for (int colIndex=0; colIndex<GameLevel.EDGE_SIZE_Z; colIndex++) {
				GameField field = currentArea.getField(rowIndex, colIndex);

				// Transform prefab = field.getPrefab();
				string className = field.GetType().Name;

				switch (className)
				{
					case "GrassGameField":
						Instantiate(CubeForFloor, new Vector3(rowIndex, -0.5f, colIndex), Quaternion.identity);
						//Instantiate(CubeForFloor, new Vector3(colIndex, -0.5f, rowIndex), Quaternion.identity);
						break;
					case "StoneGameField":
						Instantiate(CubeForStoneFloor, new Vector3(rowIndex, -0.5f, colIndex), Quaternion.identity);
						//Instantiate(CubeForStoneFloor, new Vector3(colIndex, -0.5f, rowIndex), Quaternion.identity);
						break;
					case "WaterGameField":
						Instantiate(CubeForWater, new Vector3(rowIndex, -0.5f, colIndex), Quaternion.identity);
					    //Instantiate(CubeForWater, new Vector3(colIndex, -0.5f, rowIndex), Quaternion.identity);
						break;
					default:
						Debug.LogError("Cannot instantiate field for type " + className);
						break;
				}
			}
		}
    }
}
