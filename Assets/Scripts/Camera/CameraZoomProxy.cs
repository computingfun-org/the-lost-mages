using System;
using System.ComponentModel;
using Unity.Entities;
using UnityEngine;
using VisualScripting.Entities.Runtime;
using System.Collections.Generic;
[Serializable, ComponentEditor]
public struct CameraZoom : IComponentData
{
    public float Speed;
    public float Min;
    public float Max;
}

[AddComponentMenu("Visual Scripting Components/CameraZoom")]
class CameraZoomProxy : MonoBehaviour, IConvertGameObjectToEntity, IDeclareReferencedPrefabs
{
    public float Speed;
    public float Min;
    public float Max;

    public void Convert(Unity.Entities.Entity entity, Unity.Entities.EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddComponentData(entity, new CameraZoom { Speed = Speed, Min = Min, Max = Max });
    }

    public void DeclareReferencedPrefabs(List<UnityEngine.GameObject> referencedPrefabs)
    {
    }
}