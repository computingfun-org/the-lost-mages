using Unity.Entities;

public class ManaCrystalEntity:GOEntity {

	public static bool IsManaCrystal(UnityEngine.GameObject gameObject) =>
		gameObject.GetComponent<ManaCrystalEntity>() != null;

	public override void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
		base.Convert(entity, dstManager, conversionSystem);
		AddComponentData(new ManaCrystal { });
	}
}
