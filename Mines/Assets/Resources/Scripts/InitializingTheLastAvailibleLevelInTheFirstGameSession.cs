using UnityEngine;

public class InitializingTheLastAvailibleLevelInTheFirstGameSession : MonoBehaviour
{
    [SerializeField] private CatalogOfThePlayerPrefsKeys PlayerPrefsKeys;

    private void Start()
    {
        if(PlayerPrefs.HasKey(PlayerPrefsKeys.KeyForNumberOfTheLastAvailibleLevel) == false)
        {
            PlayerPrefs.SetInt(PlayerPrefsKeys.KeyForNumberOfTheLastAvailibleLevel, 1);
        }
    }
}