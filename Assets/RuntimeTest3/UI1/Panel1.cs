using UnityEngine;
using UnityEngine.UI;

public class Panel1 : MonoBehaviour
{
    [SerializeField] private Image mImage;
    [SerializeField] private Text mTitle;
    [SerializeField] private Text mWater;
    [SerializeField] private Text mDetail;
    [SerializeField] private Button mSwitch;

    private void Start()
    {
        mSwitch.onClick.AddListener(SwitchCard);
    }

    private void SwitchCard()
    {
        var card = CardMgr.Instance.NextCard();

        mImage.sprite = card.Image;
        mTitle.text = card.Name;
        mWater.text = card.Water.ToString();
        mDetail.text = card.Detail;
    }
}
