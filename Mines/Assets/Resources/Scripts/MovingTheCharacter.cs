using UnityEngine;

public class MovingTheCharacter : MonoBehaviour
{
    [SerializeField] private DataForMovingTheCharacter AssetWithDataForMoving;
    [SerializeField] private float Speed;

    private Vector3 m_LeftDirection;
    private Vector3 m_RightDirection;
    private Vector3 m_UpDirection;
    private Vector3 m_DownDirection;

    private void InitializeVectorsOfMoving()
    {
        m_LeftDirection = Speed * Vector3.left;
        m_RightDirection = Speed * Vector3.right;
        m_UpDirection = Speed * Vector3.up;
        m_DownDirection = Speed * Vector3.down;
    }

    private void Start()
    {
        Time.timeScale = 1;
        InitializeVectorsOfMoving();
    }

    private void MoveTheCharacterOnVirtualButton(string ButtonName, Vector3 Direction)
    {
        if (Input.GetButton(ButtonName))
        {
            transform.position += Direction;
        }
    }

    private void FixedUpdate()
    {
        MoveTheCharacterOnVirtualButton(AssetWithDataForMoving.LeftKey, m_LeftDirection);
        MoveTheCharacterOnVirtualButton(AssetWithDataForMoving.RightKey, m_RightDirection);
        MoveTheCharacterOnVirtualButton(AssetWithDataForMoving.UpKey, m_UpDirection);
        MoveTheCharacterOnVirtualButton(AssetWithDataForMoving.DownKey, m_DownDirection);
    }
}