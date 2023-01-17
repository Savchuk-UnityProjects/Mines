using UnityEngine;

[CreateAssetMenu(fileName = "DataForUnlockingLevels", menuName = "ScriptableObjects/DataForUnlockingLevels")]
public class DataForUnlockingLevels : ScriptableObject
{
    [SerializeField] private int m_QuantityOfLevels;
    public int QuantityOfLevels { get => m_QuantityOfLevels; }
}