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
    public TextMeshPro moneyText7;
    public TextMeshPro moneyText8;

    public TextMeshPro DayText1;

    public GameObject ObjectDay1;
    public GameObject ObjectDay2;
    public GameObject ObjectDay3;
    public GameObject ObjectDay4;
    public GameObject ObjectDay5;
    public GameObject ObjectDay6;
    public GameObject ObjectDay7;

    public GameObject ObjectEnd;

    private int money1 = 0;
    private int money2 = 0;
    private int money3 = 0;
    private int money4 = 0;
    private int money5 = 0;
    private int money6 = 0;
    private int money7 = 0;
    private int money8 = 0;

    private int Day1 = 0;

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
        moneyText7.text = money7.ToString();
        moneyText8.text = money8.ToString();
    }
    void UpdateDayTexts()
    { 
        DayText1.text = Day1.ToString();
    }
    void CheckSkillAll()
    {
        CheckSkill1();
        CheckSkill2();
        CheckSkill3();
        CheckSkill4();
        CheckSkill5();
        CheckSkill6();
    }

    void CheckSkill1()
    {
        // สุ่มตัวเลขในช่วง [0, 99]
        int randomValue = Random.Range(0, 600);

        // มีโอกาส 25% ที่จะเปลี่ยน Font เป็นสีเขียว
        if (randomValue < 25)
        {
            moneyText1.color = Color.green;
        }
    }
    void CheckSkill2()
    {
        // สุ่มตัวเลขในช่วง [0, 99]
        int randomValue = Random.Range(0, 100);

        // มีโอกาส 25% ที่จะเปลี่ยน Font เป็นสีเขียว
        if (randomValue < 25)
        {
            moneyText2.color = Color.green;
        }
    }
    void CheckSkill3()
    {
        // สุ่มตัวเลขในช่วง [0, 99]
        int randomValue = Random.Range(0, 100);

        // มีโอกาส 25% ที่จะเปลี่ยน Font เป็นสีเขียว
        if (randomValue < 25)
        {
            moneyText3.color = Color.green;
        }
    }
    void CheckSkill4()
    {
        // สุ่มตัวเลขในช่วง [0, 99]
        int randomValue = Random.Range(0, 100);

        // มีโอกาส 25% ที่จะเปลี่ยน Font เป็นสีเขียว
        if (randomValue < 25)
        {
            moneyText4.color = Color.green;
        }
    }
    void CheckSkill5()
    {
        // สุ่มตัวเลขในช่วง [0, 99]
        int randomValue = Random.Range(0, 100);

        // มีโอกาส 25% ที่จะเปลี่ยน Font เป็นสีเขียว
        if (randomValue < 25)
        {
            moneyText5.color = Color.green;
        }
    }
    void CheckSkill6()
    {
        // สุ่มตัวเลขในช่วง [0, 99]
        int randomValue = Random.Range(0, 100);

        // มีโอกาส 25% ที่จะเปลี่ยน Font เป็นสีเขียว
        if (randomValue < 25)
        {
            moneyText6.color = Color.green;
        }
    }
    

    void AddRandomMoney()
    {
        // สุ่มเงินที่จะเพิ่ม (1, 2, 5)
        int[] possibleValues = { 1, 2, 5 };


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
        money6 += randomMoney5;

        // อัปเดต TextMeshPro
        UpdateMoneyTexts();
    }
       // Reset money
    void ResetMoneyText1()
    {
        money1 = 0;
        UpdateMoneyTexts();
    }

    void ResetMoneyText2()
    {
        money2 = 0;
        UpdateMoneyTexts();
    }

    void ResetMoneyText3()
    {
        money3 = 0;
        UpdateMoneyTexts();
    }

    void ResetMoneyText4()
    {
        money4 = 0;
        UpdateMoneyTexts();
    }

    void ResetMoneyText5()
    {
        money5 = 0;
        UpdateMoneyTexts();
    }
    public void ResetMoneyText6()
    {
        money6 = 0;
        UpdateMoneyTexts();
    }

    public void ResetMoneyText8()
    {
        money8 = 0;
        UpdateMoneyTexts();
    }

    public void AddFiveMoneyText8()
    {
        money8 += 5;
        UpdateMoneyTexts();
    }

    public void AddTwoMoneyText8()
    {
        money8 += 2;
        UpdateMoneyTexts();     
    }
    public void RandomText7()
    {
        int randomValue = Random.Range(0, 2); // สุ่มค่าในช่วง [0, 1]

        if (randomValue == 0)
        {
            money7 = 5;
        }
        else
        {
            money7 = 10;
        }

        UpdateMoneyTexts();

        // เรียกใช้ฟังก์ชัน ResetMoney7 หลังจาก 1 วินาที
        Invoke("ResetMoney7", 1f);
    }

    public void DayUpdate()
    {
        Day1 += 1;
        UpdateDayTexts();
        // เปิดใช้งาน ObjectDay1 เมื่อ Day1 เป็น 1
        if (Day1 == 1)
        {
            ObjectDay1.SetActive(true);
        }
        // เปิดใช้งาน ObjectDay2 เมื่อ Day1 เป็น 2
        else if (Day1 == 2)
        {
            ObjectDay2.SetActive(true);
        }

        else if (Day1 == 3)
        {
            ObjectDay3.SetActive(true);
        }
        else if (Day1 == 4)
        {
            ObjectDay4.SetActive(true);
        }
        else if (Day1 == 5)
        {
            ObjectDay5.SetActive(true);
        }
        else if (Day1 == 6)
        {
            ObjectDay6.SetActive(true);
        }
        else if (Day1 == 7)
        {
            ObjectDay7.SetActive(true);
        }
        else if (Day1 == 8)
        {
            ObjectEnd.SetActive(true);
        }
    }

    // ฟังก์ชันที่ใช้ใน Invoke
    private void ResetMoney7()
    {
        money7 = 0;
        UpdateMoneyTexts();
    }

    void RestartGame()
    {
        // รีเซ็ตค่าตั้งต้น
        money1 = 0;
        moneyText1.color = Color.white;
        money2 = 0;
        moneyText2.color = Color.white;
        money3 = 0;
        moneyText3.color = Color.white;
        money4 = 0;
        moneyText4.color = Color.white;
        money5 = 0;
        moneyText5.color = Color.white;
        money6 = 0;
        moneyText6.color = Color.white;
        money7 = 0;
        money8 = 0;

        Day1 = 0;

        // ปิด ObjectDay1 - ObjectDay7 และ ObjectEnd
        ObjectDay1.SetActive(false);
        ObjectDay2.SetActive(false);
        ObjectDay3.SetActive(false);
        ObjectDay4.SetActive(false);
        ObjectDay5.SetActive(false);
        ObjectDay6.SetActive(false);
        ObjectDay7.SetActive(false);
        ObjectEnd.SetActive(false);

        // อัปเดต TextMeshPro
        UpdateMoneyTexts();
        UpdateDayTexts();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
        if (Input.GetButtonDown("Jump"))
        {
            AddRandomMoney();
            DayUpdate();
            CheckSkillAll();

        }

        // เมื่อกดเลข 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ResetMoneyText1();
            moneyText1.color = Color.white;
        }
        // เมื่อกดเลข 2
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ResetMoneyText2();
            moneyText2.color = Color.white;

        }
        // เมื่อกดเลข 3
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ResetMoneyText3();
            moneyText3.color = Color.white;

        }
        // เมื่อกดเลข 4
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ResetMoneyText4();
            moneyText4.color = Color.white;

        }
        // เมื่อกดเลข 5
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ResetMoneyText5();
            moneyText5.color = Color.white;

        }
        // เมื่อกดเลข 6
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ResetMoneyText6();
            moneyText6.color = Color.white;

        }
        // เมื่อกดเลข 6
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            ResetMoneyText8();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            AddFiveMoneyText8();
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddTwoMoneyText8();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            RandomText7();
        }
    }
}
