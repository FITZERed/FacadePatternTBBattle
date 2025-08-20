using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterSO", menuName = "Scriptable Objects/CharacterSO")]
public class CharacterSO : ScriptableObject
{
    [SerializeField] private int Id;
    [SerializeField] private string DisplayName;
    [SerializeField] private CharacterType Type;
    [SerializeField] private int BaseMaxHP;
    [SerializeField] private int BaseAttack;
    [SerializeField] private int BaseDefense;
    [SerializeField] private Sprite Sprite;
    [SerializeField] List<MoveSO> Moves;
}
