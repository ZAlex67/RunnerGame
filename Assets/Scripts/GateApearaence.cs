using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GateApearaence : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    [SerializeField] private Image _topTmage;
    [SerializeField] private Image _glassImage;

    [SerializeField] private Color _colorPositive;
    [SerializeField] private Color _colorNegative; 

    [SerializeField] private BricksEffect _expandLable;
    [SerializeField] private Transform _shrinkLable;
    [SerializeField] private Transform _upLable;
    [SerializeField] private Transform _downLable;

    public void UpdateVisual(DeformationType deformationType, int value)
    {
        string prefix = "";

        if (value > 0)
        {
            prefix = "+";
            SetColor(_colorPositive);
        }
        else if (value == 0)
        {
            SetColor(Color.grey);
        }
        else
        {
            SetColor(_colorNegative);
        }

        _text.text = prefix + value.ToString();

        _expandLable.gameObject.SetActive(false);
        _shrinkLable.gameObject.SetActive(false);
        _upLable.gameObject.SetActive(false);
        _downLable.gameObject.SetActive(false);

        if (deformationType == DeformationType.Width)
        {
            if (value > 0)
            {
                _expandLable.gameObject.SetActive(true);
            }
            else
            {
                _shrinkLable.gameObject.SetActive(true);
            }
        }
        else if (deformationType == DeformationType.Height)
        {
            if (value > 0)
            {
                _upLable.gameObject.SetActive(true);
            }
            else
            {
                _downLable.gameObject.SetActive(true);
            }
        }
    }

    private void SetColor(Color color)
    {
        _topTmage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}

public enum DeformationType
{
    Width,
    Height
}