using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MoveSO", menuName = "Scriptable Objects/MoveSO")]
public class MoveSO : ScriptableObject
{
    [SerializeField] private int Id;
    [SerializeField] private string DisplayName; 
    [SerializeField] private float Accuracy;
    [SerializeField] private CharacterType AttackType;
    [SerializeField] private int Power;
    [SerializeField] private List<EffectType> Effects;
    [SerializeField] private float EffectsChance;
}
