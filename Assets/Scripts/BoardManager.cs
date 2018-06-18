using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [HideInInspector] public const string ON_NEW_TURN = "OnNewTurn";
    public Vector3 BoardMultiplier;

    public Vector2 BoardSize;
    public uint CurrentTurn;

    public void BroadcastNewTurn()
    {
        EventParam eventParam = new EventParam();
        EventManager.TriggerEvent(ON_NEW_TURN, eventParam);
    }
}
