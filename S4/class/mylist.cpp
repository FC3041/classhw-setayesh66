#include<iostream>
#include<string.h>
#include<cstring>
#include<stdlib.h>

using namespace std;

class mylist
{
    public:
        int m_sized;
        int* m_pnums;

    mylist(int* nums, int size)
    {
        m_sized = size;
        int i =0;
        int* m_pnums = new int[sizeof(int) * size];
        
        
    }

    void resize(int newsize)
    {
        
    }
    
    void append(int* nums, int size)
    {
        m_sized = size;
        for (int i = 0; i < size; i++)
        {
            /* code */
        }
        

    }

};