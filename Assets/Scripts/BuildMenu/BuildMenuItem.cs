using UnityEngine;
using UnityEngine.UI;

public class BuildMenuItem:MonoBehaviour {

	public IAbility Ability = new NullAbility();

	[SerializeField]
	string blueprintPath = "";

	[SerializeField]
	Texture selectedTexture = null;

	[SerializeField]
	Texture deselectedTexture = null;

	[SerializeField]
	RawImage image = null;

	void Awake() {
		Ability = new BlueprintAbility(blueprintPath, FindObjectOfType<PlayerEntity>().transform);
	}

	bool selected;
	public bool Selected {
		get => selected;
		set {
			if(selected = value) {
				image.texture = selectedTexture;
			}
			else {
				image.texture = deselectedTexture;
			}
		}
	}
}
