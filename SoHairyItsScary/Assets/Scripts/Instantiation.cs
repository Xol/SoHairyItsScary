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

		for (int xIndex=0; xIndex<GameLevel.EDGE_SIZE_X; xIndex++) {
			for (int zIndex=0; zIndex<GameLevel.EDGE_SIZE_Z; zIndex++) {
				Vector3 targetPoint = new Vector3(xIndex, -0.5f, zIndex);
				GameField field = currentArea.getField(xIndex, zIndex);
				string className = field.GetType().Name;

				switch (className)
				{
					case "GrassGameField":
						Instantiate(CubeForFloor, targetPoint, Quaternion.identity);
						break;
					case "StoneGameField":
						Instantiate(CubeForStoneFloor, targetPoint, Quaternion.identity);
						break;
					case "WaterGameField":
						Instantiate(CubeForWater, targetPoint, Quaternion.identity);
						break;
					default:
						Debug.LogError("Cannot instantiate field for type " + className);
						break;
				}
			}
		}
    }
}
