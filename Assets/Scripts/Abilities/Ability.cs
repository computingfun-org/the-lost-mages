using System.Runtime.CompilerServices;

public abstract class Ability:UnityEngine.MonoBehaviour {

    /// <summary>
    /// How much mana this ability cost.
    /// </summary>
    public int ManaCost;

    /// <summary>
    /// Cool down lenght of this ability.
    /// Time delay between when this ability is used and can be used again.
    /// </summary>
    public float CoolDown;

    /// <summary>
    /// Time that this ability was last used.
    /// </summary>
    public float LastUsed = float.MinValue;

    /// <summary>
    /// Time this ability will be off cool down.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float WhenCooled() => LastUsed + CoolDown;

    /// <summary>
    /// How long until this ability will be off cool down.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public float UntilCooled( float time) {
        float until = WhenCooled() - time;
        return until > 0 ? until : 0;
    }

    /// <summary>
    /// Is the ability off cool down.
    /// </summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsCooled(float time) => time >= WhenCooled();

    public abstract void Select(Input.AbilitiesUseActions actions);

    public abstract void Deselect(Input.AbilitiesUseActions actions);
}
