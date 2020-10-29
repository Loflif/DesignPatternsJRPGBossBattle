using UnityEngine;

[CreateAssetMenu(fileName = "newAbility", menuName = "ScriptableObject/Ability", order = 0)]
public class Ability : ScriptableObject
{
    public Vector3    AbilityOffset     = new Vector3(0, 0, 1);
    public Vector3    AbilityHitBox     = new Vector3(1, 1, 1);
    public float      Damage            = 1.0f;
    public GameObject AbilityVisualiser = null;
    //TODO: add ailment scriptableObjects? :)
}
