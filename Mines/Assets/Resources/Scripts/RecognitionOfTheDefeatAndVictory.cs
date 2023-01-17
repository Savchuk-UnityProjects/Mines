using UnityEngine;
using System;

public class RecognitionOfTheDefeatAndVictory : MonoBehaviour
{
    [SerializeField] private CatalogOfTheNumbersOfTheLayers Layers;
    [SerializeField] private CatalogOfThePlayerPrefsKeys PlayerPrefsKeys;
    [SerializeField] private GameObject VictoryCanvas;
    [SerializeField] private GameObject DefeatCanvas;
    [SerializeField] private int NumberOfThisLevel;

    private event Action m_OnFail;
    private event Action m_OnWin;

    private void StopTheGame()
    {
        Time.timeScale = 0;
    }

    private void ActivateDefeatCanvas()
    {
        DefeatCanvas.SetActive(true);
    }

    private void ActivateVictoryCanvas()
    {
        VictoryCanvas.SetActive(true);
    }

    private void SaveInformationAboutVictory()
    {
        int LastAvailibleLevel = PlayerPrefs.GetInt(PlayerPrefsKeys.KeyForNumberOfTheLastAvailibleLevel);
        if(NumberOfThisLevel == LastAvailibleLevel)
        {
            PlayerPrefs.SetInt(PlayerPrefsKeys.KeyForNumberOfTheLastAvailibleLevel, LastAvailibleLevel + 1);
            PlayerPrefs.Save();
        }
    }

    private void Start()
    {
        m_OnFail += ActivateDefeatCanvas;
        m_OnFail += StopTheGame;
        m_OnWin += SaveInformationAboutVictory;
        m_OnWin += ActivateVictoryCanvas;
        m_OnWin += StopTheGame;
    }

    private void OnDestroy()
    {
        m_OnFail = null;
        m_OnWin = null;
    }

    private void OnCollisionEnter2D(Collision2D AnyCollision)
    {
        int LayerOfCollidedObject = AnyCollision.collider.gameObject.layer;

        if(LayerOfCollidedObject == Layers.LayerWithMine)
        {
            m_OnFail?.Invoke();
        }
        else if (LayerOfCollidedObject == Layers.LayerWithObjectsWhichFinishTheLevel)
        {
            m_OnWin?.Invoke();
        }
    }
}