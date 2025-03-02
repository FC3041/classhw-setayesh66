#include<iostream>
#include<math.h>

// int main()
// {
//     int a
//     std::cin>>a;
//     std::cout<<"a:" <<a<<std::endl;

// }

using namespace std;

// int main()
// {
//     int a;
//     cin>>a;
//     cout<<"a:" <<a<<std::endl;
// }

class Point
{
    public:
        double x;
        double y;
        //copy kardan ye noghte dige
        Point(const Point* w) //const bezarim dige maghadir ro nemish etaaghir dad
        {
            x=w->x; 
            //w.y+=1; //const gozashtim pas asary nadare
            y=w->y;
        }

        //constructor
        Point(double t, double r)
        {
            x=t;
            y=r;
        }
        Point(double w)
        {
            x=w;
            y=w;
        }

        double distance(Point w)
        {
            double xdiff = x - w.x;
            double ydiff = y - w.y;
            return sqrt(xdiff*xdiff + ydiff*ydiff);

        }
        void print_point()
        {
            cout <<"x:" << x << ",y:"<< y<< endl;
        }

        //destructor 
        ~Point()
        {
            cout << "x in d:"<< x <<", y in d:"<<y << endl;
            //destructor vaghti az barname miad birun va kare ye noghte tamum mishe kejra mishe va khod be khod amal mikone
        }


};

int Main()
{
    Point p1(1,1);
    int c = 5;
    if (c>3)
    {
        Point p2(2,2);
    }
    else{
        Point p3(3,3);
    }
}


void print_point(Point p)
{
    cout <<"x:" << p.x << ",y:"<< p.y<< endl;

}

// double distance(Point q, Point w)
// {
//     double xdiff = q.x - w.x;
//     double ydiff = q.y - w.y;
//     return sqrt(xdiff*xdiff + ydiff*ydiff);

// }



int main1()
{
    Point p0(9);
    p0.print_point();
    // Point p1;
    Point p1(4,5);
    // p1.x=4;
    // p1.y=5;
    // print_point(p1);
    p1.print_point();

    // Point p2;
    // p2.x=-5;
    // p2.y=10;
    Point p2(-5,10);
    cout << p2.x << endl;   //endl vase khat baad
    double dis = p1.distance(p2);
    cout << dis << endl;
//ye copy gereft az p2 shod p3
    Point p3(p2);
}