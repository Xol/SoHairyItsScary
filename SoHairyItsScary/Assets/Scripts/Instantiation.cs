using UnityEngine;
using System.Collections;

public class Instantiation : MonoBehaviour {
    public Transform CubeForFloor;
	GameManager GM;
	GameLevel currentArea;

    void Start()
    {
		GM = GameManager.Instance;
		currentArea = GM.getCurrentGameArea();
		for (int rowIndex=0; rowIndex<GameLevel.EDGE_SIZE; rowIndex++) {
			for (int colIndex=0; colIndex<GameLevel.EDGE_SIZE; colIndex++) {
				GameField field = currentArea.getField(rowIndex, colIndex);

				// Transform prefab = field.getPrefab();
				string className = field.GetType().Name;
				if (className.Equals("GrassGameField")) {
					Instantiate(CubeForFloor, new Vector3(rowIndex, -0.5f, colIndex), Quaternion.identity);
				} else {
					Debug.LogError("Cannot instantiate field for type " + className);
				}
			}
		}
    }
}
