using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CardHolder : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private Transform _cardHolderPosition;
    [SerializeField] private GameObject _card;
    [SerializeField] private Card[] _cardSO;
    private int _cardsAmmount;
    private GameObject[] _plantedCards;

    private int _cost;
    private Sprite _icon;

    private void Start()
    {
        _cardsAmmount = _cardSO.Length;
        _plantedCards = new GameObject[_cardsAmmount];
        for (int i = 0; i < _cardsAmmount; i++)
        {
            CreateCard(i);
        }
    }

    private void CreateCard(int index)
    {
        var card = Instantiate(_card, _cardHolderPosition);

        CardManger cardManger = card.GetComponent<CardManger>();

        cardManger.CardSO = _cardSO[index];
        _plantedCards[index] = card;

        _icon = _cardSO[index].Icon;
        _cost = _cardSO[index].Cost;

        card.GetComponentInChildren<SpriteRenderer>().sprite = _icon;
        card.GetComponentInChildren<TMP_Text>().text = _cost.ToString();

    }
}
