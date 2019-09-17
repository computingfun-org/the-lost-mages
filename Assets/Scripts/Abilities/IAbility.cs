public interface IAbility {

    /// <summary>
    /// Called when ability is selected.
    /// </summary>
    void Select(Input.AbilitiesUseActions actions);

    /// <summary>
    /// Called when ability is deselected.
    /// </summary>
    void Deselect(Input.AbilitiesUseActions actions);
}
