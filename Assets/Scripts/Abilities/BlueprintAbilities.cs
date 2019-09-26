using UnityEngine;

public static class BlueprintAbilities {
	public static BlueprintAbility NewDebugCastle(Transform parent) => new BlueprintAbility("castle blueprint", parent);
	public static BlueprintAbility NewDebugCity(Transform parent) => new BlueprintAbility("city blueprint", parent);
}
