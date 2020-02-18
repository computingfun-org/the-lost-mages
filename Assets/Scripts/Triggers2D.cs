using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers2D:MonoBehaviour, IReadOnlyCollection<GameObject> {

	/// <summary> Is GameObject being triggered by at least one other GameObject. </summary>
	public bool IsTriggered
		=> gameObjects.Count != 0;

	void OnTriggerEnter2D(Collider2D collision)
		=> gameObjects.Add(collision.gameObject);

	void OnTriggerExit2D(Collider2D collision)
		=> gameObjects.Remove(collision.gameObject);

	readonly List<GameObject> gameObjects = new List<GameObject>();

	/// <summary> GameObjects in trigger area. </summary>
	public GameObject this[int i]
		=> gameObjects[i];

	/// <summary> Amount of GameObjects in trigger area. </summary>
	public int Count
		=> gameObjects.Count;

	public IEnumerator<GameObject> GetEnumerator()
		=> ((IReadOnlyCollection<GameObject>)gameObjects).GetEnumerator();

	IEnumerator IEnumerable.GetEnumerator()
		=> ((IReadOnlyCollection<GameObject>)gameObjects).GetEnumerator();
}
