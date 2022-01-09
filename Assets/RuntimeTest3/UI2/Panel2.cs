using UnityEngine;
using UnityEngine.UIElements;

public class Panel2 : MonoBehaviour
{
    private VisualElement mImage;
    private Label mTitle;
    private Label mWater;
    private Label mDetail;
    private Button mSwitch;

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        mImage = root.Q<VisualElement>("Image");
        mTitle = root.Q<Label>("Title");
        mWater = root.Q<Label>("Number");
        mDetail = root.Q<Label>("Detail");
        mSwitch = root.Q<Button>("Switch");
        mSwitch.clicked += SwitchCard;
    }

    private void SwitchCard()
    {
        var card = CardMgr.Instance.NextCard();

        mImage.style.backgroundImage = new StyleBackground(card.Image);
        mTitle.text = card.Name;
        mWater.text = card.Water.ToString();
        mDetail.text = card.Detail;
    }
}
