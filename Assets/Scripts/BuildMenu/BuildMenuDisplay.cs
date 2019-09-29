using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

public class BuildMenuDisplay:MonoBehaviour {

	[SerializeField]
	RawImage image = null;

	public bool Display {
		set => image.enabled = value;
		get => image.enabled;
	}

	public static void DisplayAll(BuildMenuDisplay[] buildMenuDisplays, bool value) {
		for (int i = 0, len = buildMenuDisplays.Length; i < len; i++) {
			buildMenuDisplays[i].Display = value;
		}
	}

	public static void DisplayAll(EntityQuery entityQuery, bool value) =>
		DisplayAll(entityQuery.ToComponentArray<BuildMenuDisplay>(), value);
}
