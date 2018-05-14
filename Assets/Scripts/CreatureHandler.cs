using UnityEngine;

public class CreatureHandler : MonoBehaviour
{
    public GameObject TargetCreature;

    private BoardManager _boardManager;

    void Awake()
    {
        _boardManager = FindObjectOfType<BoardManager>();
    }

    void FixedUpdate()
    {
        TargetCreature.transform.localPosition = new Vector3(gameObject.transform.parent.position.x * _boardManager.BoardMultiplier.x, TargetCreature.transform.localPosition.y * _boardManager.BoardMultiplier.y, gameObject.transform.parent.position.z * _boardManager.BoardMultiplier.z);
    }

    void OnEnable()
    {
        TargetCreature.SetActive(true);
    }

    void OnDisable()
    {
        TargetCreature.SetActive(false);
    }
}
