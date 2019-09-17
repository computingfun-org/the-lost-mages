using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugAbility:MonoBehaviour {

    public GameObject prefab;
    PlayerAbilities<ShootAbility, ShootAbility, ShootAbility, ShootAbility> abilities;

    // Start is called before the first frame update
    void Start()
    {
        ShootAbility ability = new ShootAbility {
            source = transform,
            projectile = prefab,
        };
        abilities = new PlayerAbilities<ShootAbility, ShootAbility, ShootAbility, ShootAbility>(ability, ability, ability, ability);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
