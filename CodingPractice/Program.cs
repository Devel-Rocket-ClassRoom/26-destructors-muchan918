using System;
using System.Threading;

Test1();
Test2();
Test3();
Test4();
Test5();
Test6();

void Test1()
{
    TestObject obj1 = new TestObject(1);
    TestObject obj2 = new TestObject(2);

    obj1 = null;
    obj2 = null;

    Console.WriteLine("GC 실행 전");

    GC.Collect();
    GC.WaitForPendingFinalizers();

    Console.WriteLine("GC 실행 후");
}

void Test2()
{
    Console.WriteLine("프로그램 시작");

    Character hero = new Character("용사");
    hero.Attack();
    hero = null;

    Console.WriteLine("GC 실행");
    GC.Collect();
    GC.WaitForPendingFinalizers();

    Console.WriteLine("프로그램 종료");
}

void Test3()
{
    // 메인 코드
    Car car1 = new Car("검정");
    car1.Drive();

    Car car2 = new Car("하얀");
    car2.Drive();

    Car car3 = new Car("파랑");
    car3.Drive();

    // 참조 해제
    car1 = null;
    car2 = null;
    car3 = null;

    Console.WriteLine("=== GC 실행 ===");
    GC.Collect();
    GC.WaitForPendingFinalizers();
    Console.WriteLine("=== 정리 완료 ===");
}

void Test4()
{
    GameSession session = new GameSession("플레이어1");
    session.Play();
    session = null;

    GC.Collect();
    GC.WaitForPendingFinalizers();
}

void Test5()
{
    Monster m1 = new Monster("슬라임");
    Monster m2 = new Monster("고블린");
    Monster m3 = new Monster("오크");

    Console.WriteLine();
    Monster.ShowStats();
    Console.WriteLine();

    // 모든 몬스터 제거
    m1 = null;
    m2 = null;
    m3 = null;

    GC.Collect();
    GC.WaitForPendingFinalizers();

    Console.WriteLine();
    Monster.ShowStats();
}

void Test6()
{
    Console.WriteLine("=== 아이템 생성 ===");
    GameItem potion = new GameItem("체력 포션", 50);
    GameItem sword = new GameItem("강철 검", 200);
    GameItem shield = new GameItem("나무 방패", 100);

    Console.WriteLine();
    Console.WriteLine("=== 아이템 사용 ===");
    potion.Use();
    sword.Use();

    Console.WriteLine();
    Console.WriteLine("=== 인벤토리 정리 ===");
    potion = null;
    sword = null;
    shield = null;

    GC.Collect();
    GC.WaitForPendingFinalizers();
    Console.WriteLine("=== 정리 완료 ===");
}

