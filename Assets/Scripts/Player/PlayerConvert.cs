using UnityEngine;
using Unity.Entities;

namespace Player {
    [RequiresEntityConversion]
    [DisallowMultipleComponent]
    public class PlayerConvert:MonoBehaviour, IConvertGameObjectToEntity {

        public Entity entity { get; private set; }
        public EntityManager manager { get; private set; }

        public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem) {
            this.entity = entity;
            manager = dstManager;
            dstManager.AddComponentData(entity, new Player { });
        }
    }
}
