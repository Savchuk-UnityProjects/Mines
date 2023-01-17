using UnityEngine;

[CreateAssetMenu(fileName = "CatalogOfTheNumbersOfTheLayers", menuName = "ScriptableObjects/CatalogOfTheNumbersOfTheLayers")]
public class CatalogOfTheNumbersOfTheLayers : ScriptableObject
{
    [SerializeField] private int m_LayerWithMine;
    public int LayerWithMine { get => m_LayerWithMine; }

    [SerializeField] private int m_LayerWithCharacter;
    public int LayerWithCharacter { get => m_LayerWithCharacter; }
    
    [SerializeField] private int m_LayerWithObjectsWhichFinishTheLevel;
    public int LayerWithObjectsWhichFinishTheLevel { get => m_LayerWithObjectsWhichFinishTheLevel; }
}