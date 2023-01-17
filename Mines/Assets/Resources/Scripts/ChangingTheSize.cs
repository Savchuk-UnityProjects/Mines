using UnityEngine;

public class ChangingTheSize : MonoBehaviour
{
    [SerializeField] private float MinimalSize;
    [SerializeField] private float MaximalSize;
    [SerializeField] private float SpeedOfChangingScalePerTimeFixedDeltaTime;

    private int m_ValueWhichShowsDirectionOfTheChanging = 1;

    private bool IsCurrentScaleInRangeBetweenMinimumAndMaximum()
    {
        return transform.localScale.x <= MaximalSize &&
            transform.localScale.x >= MinimalSize;
    }

    private void SetLocalScale(float NewScale)
    {
        transform.localScale = NewScale * Vector3.one;
    }
    
    private void IncreaseLocalScale(float Difference)
    {
        transform.localScale += Difference * Vector3.one;
    }

    private void Start()
    {
        if(IsCurrentScaleInRangeBetweenMinimumAndMaximum() == false)
        {
            SetLocalScale(MinimalSize);
        }
    }

    private void ChangeSizeInFixedUpdate()
    {
        if (IsCurrentScaleInRangeBetweenMinimumAndMaximum() == false)
        {
            m_ValueWhichShowsDirectionOfTheChanging *= -1;
        }
        IncreaseLocalScale(SpeedOfChangingScalePerTimeFixedDeltaTime * m_ValueWhichShowsDirectionOfTheChanging);
    }

    private void FixedUpdate()
    {
        ChangeSizeInFixedUpdate();
    }
}