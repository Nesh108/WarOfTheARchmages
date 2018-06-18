using UnityEngine;

public class CreatureHandler : MonoBehaviour
{
    public GameObject TargetCreature;

    private BoardManager _boardManager;
    private Vector2 _currentBoardPosition;
    private uint _movesInCurrentTurn;

    void Awake()
    {
        _boardManager = FindObjectOfType<BoardManager>();
        _currentBoardPosition = new Vector2(-1f, -1f);
    }

    void FixedUpdate()
    {
        TargetCreature.transform.localPosition = new Vector3(gameObject.transform.parent.position.x * _boardManager.BoardMultiplier.x, TargetCreature.transform.localPosition.y * _boardManager.BoardMultiplier.y, gameObject.transform.parent.position.z * _boardManager.BoardMultiplier.z);
    }

    void OnEnable()
    {
        EventManager.StartListening(BoardManager.ON_NEW_TURN, OnNewTurn);
        TargetCreature.SetActive(true);
    }

    void OnDisable()
    {
        EventManager.StopListening(BoardManager.ON_NEW_TURN, OnNewTurn);
        TargetCreature.SetActive(false);
    }

    public void ConfirmMove(Vector2 v)
    {
        _currentBoardPosition = v;
        _movesInCurrentTurn++;
    }

    private void OnNewTurn(EventParam eventParam)
    {
        _movesInCurrentTurn = 0;
        Debug.Log("New Turn for: " + TargetCreature.name + " current position: " + _currentBoardPosition);
    }
}
