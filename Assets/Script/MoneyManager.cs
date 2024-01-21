using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    public TextMeshPro moneyText1;
    public TextMeshPro moneyText2;
    public TextMeshPro moneyText3;
    public TextMeshPro moneyText4;
    public TextMeshPro moneyText5;
    public TextMeshPro moneyText6;

    private int money1 = 0;
    private int money2 = 0;
    private int money3 = 0;
    private int money4 = 0;
    private int money5 = 0;
    private int money6 = 0;

    void Start()
    {
        UpdateMoneyTexts();
    }

    void UpdateMoneyTexts()
    {
        moneyText1.text = money1.ToString();
        moneyText2.text = money2.ToString();
        moneyText3.text = money3.ToString();
        moneyText4.text = money4.ToString();
        moneyText5.text = money5.ToString();
        moneyText6.text = money6.ToString();
    }

    void AddRandomMoney()
    {
        // สุ่มเงินที่จะเพิ่ม (1, 2, 5)
        int[] possibleValues = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
            5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };


        int randomMoney1 = possibleValues[Random.Range(0, possibleValues.Length) % possibleValues.Length];
        int randomMoney2 = possibleValues[Random.Range(0, possibleValues.Length) % possibleValues.Length];
        int randomMoney3 = possibleValues[Random.Range(0, possibleValues.Length) % possibleValues.Length];
        int randomMoney4 = possibleValues[Random.Range(0, possibleValues.Length) % possibleValues.Length];
        int randomMoney5 = possibleValues[Random.Range(0, possibleValues.Length) % possibleValues.Length];
        int randomMoney6 = possibleValues[Random.Range(0, possibleValues.Length) % possibleValues.Length];

        // เพิ่มเงินที่สุ่มได้
        money1 += randomMoney1;
        money2 += randomMoney2;
        money3 += randomMoney3;
        money4 += randomMoney4;
        money5 += randomMoney5;
        money6 += randomMoney6;

        // อัปเดต TextMeshPro
        UpdateMoneyTexts();
    }

    void Update()
    {
        // เมื่อกดปุ่ม (ตั้งชื่อให้ตรงกับปุ่มที่ใช้)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddRandomMoney();
        }
    }
}
