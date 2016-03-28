using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSpawnerController : MonoBehaviour
{
	float LEVEL_SPACING = 3f;
	float HORIZONTAL_FACTOR = 5f;
	int PRESPAWN_COUNT = 3;

	int count;
	public GameObject levelprefab;
	public Transform player;
	float lastspawnheight;

	void Start ()
	{
		lastspawnheight = player.position.y - LEVEL_SPACING;
	}
	

	void Update ()
	{
		float playerheight = player.position.y;
		if (playerheight + PRESPAWN_COUNT * LEVEL_SPACING > lastspawnheight) {
			spawnnextlevel ();
		}
	}

	void spawnnextlevel ()
	{
		lastspawnheight += LEVEL_SPACING;
		GameObject level = Instantiate (levelprefab);
		level.transform.position = new Vector3 (lastspawnheight * HORIZONTAL_FACTOR, lastspawnheight, 0);
		level.GetComponentInChildren<TextMesh> ().text = "Level " + ++count;
	}
}
