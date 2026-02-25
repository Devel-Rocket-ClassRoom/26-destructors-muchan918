using System;

Test();

void Test()
{
    Seat student1 = new Seat("김민수");
    Seat student2 = new Seat("이지영");
    Seat student3 = new Seat("박서준");

    student1.Study();
    student2.Study();
    student3.Study();

    Seat.ShowStatus();
}

GC.Collect();
GC.WaitForPendingFinalizers();
Seat.ShowStatus();