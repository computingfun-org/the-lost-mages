using UnityEngine;
using Unity.Entities;

[RequiresEntityConversion]
[DisallowMultipleComponent]
public class GOEntity:MonoBehaviour, IConvertGameObjectToEntity {

	public Entity entity { get; private set; }
	public EntityManager manager { get; private set; }

	public T GetComponentData<T>() where T : struct, IComponentData => manager.GetComponentData<T>(entity);
	public void SetComponentData<T>(T componentData) where T : struct, IComponentData => manager.SetComponentData(entity, componentData);
	public void AddComponentData<T>(T componentData) where T : struct, IComponentData => manager.AddComponentData(entity, componentData);
	public void RemoveComponentData<T>() where T : struct, IComponentData => manager.RemoveComponent<T>(entity);

	public virtual void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
		this.entity = entity;
		manager = dstManager;
	}
}
