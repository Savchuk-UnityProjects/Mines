using UnityEngine;
using UnityEngine.UI;

public class LockingUnavailibleLevels : MonoBehaviour
{
    [SerializeField] private CatalogOfThePlayerPrefsKeys PlayerPrefsKeys;
    [SerializeField] private Button[] ButtonsWhichOpenTheLevels;

    private void Start()
    {
        int TheLastAvailibleLevel = PlayerPrefs.GetInt(PlayerPrefsKeys.KeyForNumberOfTheLastAvailibleLevel);
        for (int i = ButtonsWhichOpenTheLevels.Length - 1; i > TheLastAvailibleLevel - 1; i--)
        {
            ButtonsWhichOpenTheLevels[i].interactable = false;
        }
    }
}