using Unity.Collections;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Jobs;

public class TranslationUpdateSystem:ComponentSystem {

    EntityQuery query;

    protected override void OnCreate() {
        base.OnCreate();
        query = GetEntityQuery(new ComponentType[]{
            ComponentType.ReadWrite<Translation>(),
            ComponentType.ReadOnly<Transform>(),
        });
    }

    protected override void OnUpdate() {
        using(NativeArray<Entity> entities = query.ToEntityArray(Allocator.TempJob)) {
            TransformAccessArray transforms = query.GetTransformAccessArray();
            for(int i = 0, len = entities.Length; i < len; i++) {
                EntityManager.SetComponentData(entities[i], new Translation { Value = transforms[i].position });
            }
        }
    }
}
