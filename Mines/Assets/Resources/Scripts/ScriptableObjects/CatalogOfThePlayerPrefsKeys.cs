using UnityEngine;

[CreateAssetMenu(fileName = "CatalogOfThePlayerPrefsKeys", menuName = "ScriptableObjects/CatalogOfThePlayerPrefsKeys")]
public class CatalogOfThePlayerPrefsKeys : ScriptableObject
{
    [SerializeField] private string m_KeyForNumberOfTheLastAvailibleLevel;
    public string KeyForNumberOfTheLastAvailibleLevel { get => m_KeyForNumberOfTheLastAvailibleLevel; }
}