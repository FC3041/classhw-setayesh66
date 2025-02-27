#include<iostream>
#include<math.h>

using namespace std;

class point
{
    public:
        double x;
        double y;
        point(double x0, double y0)
        {
            x=x0;
            y=y0;
        }
        void printpoint()
        {
            cout <<"x:" << x << ",y:"<< y<< endl;
        }

        double distance(point w)
        {
            double xdiff = x - w.x;
            double ydiff = y - w.y;
            return sqrt(xdiff*xdiff + ydiff*ydiff);

        }
        // ~point();

};


void circumference(double radius)
{
    double pi = M_PI;
    double P= 2*radius*pi; 
    cout <<"circumference:" << P <<endl;

}


void area(double radius)
{
    double pi = M_PI;
    double S= radius*radius*pi; 
    cout <<"area:" << S <<endl;
}

void close_enough(point k, point j, double radius)
{
    double dis = k.distance(j);
    if (dis<radius)
    {
        cout <<"the random point is inside the circle"<<endl;
    }
    if (dis==radius)
    {
        cout <<"the random point is on the circle"<<endl;
    }
    if (dis>radius)
    {
        cout <<"the random point is outside the circle"<<endl;
    }
    
}

int main()
{
    double x=0;
    double y=0;
    double x2=3;
    double y2=3;
    double x3=-3;
    double y3=1;
    point center(x,y);
    point center2(x2,y2);
    point randompoint(x3,y3);
    center.printpoint();
    center2.printpoint();
    double radius = 5;
    cout <<"radius: "<< radius<<endl;
    circumference(radius);
    area(radius);
    double dis1 = center.distance(center2);
    cout <<"distance from another circle's center: "<<dis1<<endl;
    double dis2 = center.distance(randompoint);
    cout <<"distance from a random point: "<<dis2<<endl;
    close_enough(center, randompoint, radius);

}