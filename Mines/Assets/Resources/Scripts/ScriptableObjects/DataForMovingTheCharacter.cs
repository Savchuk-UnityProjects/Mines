using UnityEngine;

[CreateAssetMenu(fileName = "DataForMovingTheCharacter", menuName = "ScriptableObjects/DataForMovingTheCharacter")]
public class DataForMovingTheCharacter : ScriptableObject
{
    [SerializeField] private string m_LeftKey;
    public string LeftKey { get => m_LeftKey; }

    [SerializeField] private string m_RightKey;
    public string RightKey { get => m_RightKey; }

    [SerializeField] private string m_UpKey;
    public string UpKey { get => m_UpKey; }

    [SerializeField] private string m_DownKey;
    public string DownKey { get => m_DownKey; }
}