#include<iostream>
#include<string>
#include<string.h>

using namespace std;

class methods
{
    public:
    int* nums;
    int size;
    int capacity;

    methods(): nums(nullptr), size(0), capacity(0){}

    methods(int* m_nums, int m_size, int m_capacity)
    {
        size = m_size;
        capacity = m_capacity;
        nums = new int[capacity];
        for (int i = 0; i < size; i++)
        {
            nums[i] = m_nums[i];
        }

        // strcpy(nums, m_nums); //can't be used here since they're arrays of numbers and not strings of characters!
    }
    ~methods()
    {
        delete[] nums;
    }

    void resize(int newcapacity)
    {
        int* newnums = new int [newcapacity];
        for (int i = 0; i < size; i++)
        {
            newnums[i] = nums[i];
        }
        delete[] nums;
        nums = newnums;
        capacity = newcapacity;
    }


    void push_back(int value) 
    {
        if (size>=capacity)
        {
            int newcap = capacity*2;
            resize(newcap);
        }
        nums[size] = value;
        size++;
    }
    
    void print()
    {
        for (int i = 0; i < size; i++)
        {
            cout << nums[i];
            if (i < size - 1)
            {
                cout << ",";
            }
        }
        if (size==0)
        {
            cout<<"the list is empty";
        }
        cout<<endl;
        
    }

    void at(int index)
    {
        cout<<nums[index]<<endl;
    }

    void insert(int index, int value)
    {
        if (size>=capacity)
        {
            int newcap = capacity*2;
            resize(newcap);
        }
        
        for (int i = size; i > index; i--)
        {
            nums[i]=nums[i-1];
        }

        nums[index] = value;
        size++;
        
    }

    void erase(int index) //hamun pop
    {
        for (int i = index; i < size-1; i++)
        {
            nums[i]=nums[i+1];
        }
        size--;
    }

    void sizenum()
    {
        cout<<size<<endl;

    }

    void capacitynum()
    {
        cout<<capacity<<endl;
    }

    void clear() 
    {
        size = 0;
    }
};

int main()
{
    int nums[] = {1,2,3};
    int size = 3;
    int capacity=5;

    methods numsl(nums, size, capacity);
    

    numsl.push_back(5);
    numsl.push_back(7);
    numsl.print(); 
    numsl.at(3);
    numsl.insert(3,4);
    numsl.insert(5,6);
    numsl.insert(6,6);
    numsl.print();
    numsl.erase(6);
    numsl.print();
    numsl.sizenum();
    numsl.capacitynum();
    numsl.clear();
    numsl.print();

    return 0;

}
