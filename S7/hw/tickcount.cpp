#include<iostream>
#include<string>
#include<windows.h>

using namespace std;

class KeepTime
{
private:
    string explanation;
    unsigned long long firsttick;


public:
    KeepTime(const string& expl): explanation(expl)
    {
        firsttick= GetTickCount64();
    }
    ~KeepTime()
    {
        unsigned long long lasttick;
        lasttick=GetTickCount64();
        unsigned long long takentime;
        takentime=lasttick-firsttick;
        cout<<explanation<<takentime<<endl;

    }
};

int main()
{
    KeepTime kt("the time taken for executing the (for loop 10000000 long double mul): ");
    long double d = 1.0000001;
    for (int i = 0; i < 10000000; i++)
    {
        d *= 1.0000001;
    }
    cout<<"d: "<<d<<endl;
    return 0;
//for smaller numbers of itterations the program is executed so fast that the time taken rounds down to 0
}

