using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;

public class Scrap : MonoBehaviour {

    [SerializeField]
    Blueprint blueprintPrefab;

    private void Start() {
        Player.PlayerConvert player = FindObjectOfType<Player.PlayerConvert>();
        PlayerFireball playerFireball = new PlayerFireball();
        playerFireball.playerEntity = player.entity;
        playerFireball.entityManager = player.manager;
        World.Active.GetOrCreateSystem<Player.PlayerAbilitySystem>().Abilities[0] = playerFireball;
        PlayerBlueprint playerBlueprint = new PlayerBlueprint();
        playerBlueprint.prefab = blueprintPrefab;
        World.Active.GetOrCreateSystem<Player.PlayerAbilitySystem>().Abilities[1] = playerBlueprint;
    }
}
