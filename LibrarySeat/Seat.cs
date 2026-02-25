using System;

class Seat
{
    private static int _currentNum = 0;
    private static int _totalCount = 0;

    private int _id;
    private string _name;

    public Seat(string name)
    {
        _name = name;
        _id = ++_currentNum;
        _totalCount++;
        Console.WriteLine($"좌석 {_id}번 착석: {_name}");
    }

    ~Seat()
    {
        _currentNum--;
        Console.WriteLine($"좌석 {_id}번 반납: {_name}");
    }

    public void Study()
    {
        Console.WriteLine($"{_name}이(가) 좌석 {_id}번에서 공부 중...");
    }

    public static void ShowStatus()
    {
        Console.WriteLine($"총 이용: {_totalCount}명, 현재 착석: {_currentNum}명");
    }
}