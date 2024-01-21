using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalPlayers = 6;
    public int targetMoney = 100;
    public int policeFine = 2;

    public List<Player> players;

    void Start()
    {
        InitializePlayers();
        DistributeCards();
        PrepareMoneyPiles();
    }

    void InitializePlayers()
    {
        players = new List<Player>();
        for (int i = 1; i <= totalPlayers; i++)
        {
            Player player = new Player("Player " + i);
            players.Add(player);
        }
    }

    void DistributeCards()
    {
        // การจัดแจกการ์ดตามจำนวนกอง
        foreach (Player player in players)
        {
            // สร้างรูปภาพที่สุ่มมา
            int randomImageIndex = Random.Range(0, 8);
            player.imageIndex = randomImageIndex;
        }
    }

    void PrepareMoneyPiles()
    {
        // การเตรียมกองเงิน
        foreach (Player player in players)
        {
            player.moneyPile = Random.Range(0, 2); // สุ่มเงินจากกระเป๋าตัง
        }

        // วางเงินรางวัลนำจับที่กองตำรวจ
        int policeReward = 5;
        players[0].policeReward = policeReward; // สมมติว่าผู้เล่นที่ 1 เป็นตำรวจ
    }

    void Update()
    {
        // ตรวจสอบเงื่อนไขชนะในช่วงที่ 2
        if (IsGameFinished())
        {
            Debug.Log("Game Over! Winner: " + GetWinner().name);
            // ทำสิ่งที่ต้องการเมื่อมีผู้ชนะ
        }
    }

    bool IsGameFinished()
    {
        foreach (Player player in players)
        {
            if (player.money >= targetMoney)
            {
                return true;
            }
        }
        return false;
    }

    Player GetWinner()
    {
        Player winner = players[0];
        foreach (Player player in players)
        {
            if (player.money > winner.money)
            {
                winner = player;
            }
        }
        return winner;
    }
}

public class Player
{
    public string name;
    public int money;
    public int imageIndex;
    public int moneyPile;
    public int policeReward;

    public Player(string playerName)
    {
        name = playerName;
        money = 0;
        imageIndex = -1;
        moneyPile = 0;
        policeReward = 0;
    }
}
