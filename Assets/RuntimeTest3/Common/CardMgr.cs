using UnityEngine;

public class CardMgr : MonoBehaviour
{
    [SerializeField] private CardData[] mCards;

    private static CardMgr mInstance;

    public static CardMgr Instance => mInstance;

    private int mIndex = -1;

    private void Awake()
    {
        mInstance = this;
    }

    public CardData NextCard()
    {
        mIndex++;
        if (mIndex >= mCards.Length)
        {
            mIndex = 0;
        }
        return mCards[mIndex];
    }
}
