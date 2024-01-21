using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    public TextMeshPro PmoneyText1;
    public TextMeshPro PmoneyText2;
    public TextMeshPro PmoneyText3;
    public TextMeshPro PmoneyText4;
    public TextMeshPro PmoneyText5;

    private int Pmoney1 = 0;
    private int Pmoney2 = 0;
    private int Pmoney3 = 0;
    private int Pmoney4 = 0;
    private int Pmoney5 = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateMoneyTexts();
    }

    void UpdateMoneyTexts()
    {
        PmoneyText1.text = Pmoney1.ToString();
        PmoneyText2.text = Pmoney2.ToString();
        PmoneyText3.text = Pmoney3.ToString();
        PmoneyText4.text = Pmoney4.ToString();
        PmoneyText5.text = Pmoney5.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
