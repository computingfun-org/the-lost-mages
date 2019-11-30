using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Triggers2D:MonoBehaviour {

	/// <summary> GameObjects in trigger area. </summary>
	public GameObject this[int i] => gameObjects[i];

	/// <summary> Amount of GameObjects in trigger area. </summary>
	public int Length => gameObjects.Count;

	/// <summary> Collection of GameObjects in trigger area. </summary>
	public ReadOnlyCollection<GameObject> Collection => gameObjects.AsReadOnly();

	/// <summary> Is GameObject being triggered by at least one other GameObject. </summary>
	public bool IsTriggered => gameObjects.Count != 0;

	readonly List<GameObject> gameObjects = new List<GameObject>();

	void OnTriggerEnter2D(Collider2D collision)
		=> gameObjects.Add(collision.gameObject);

	void OnTriggerExit2D(Collider2D collision)
		=> gameObjects.Remove(collision.gameObject);
}
