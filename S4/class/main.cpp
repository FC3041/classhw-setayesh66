#include<iostream>
#include<string.h>
#include<stdlib.h>


class Date
{
    int day;
    int month;
    int year;
};

class Person
{
    int m_NID;
    char m_fname[20];
    char m_lname[20];
    Date m_BD;
    Person(const char* fname, const char* lname, int id, Date bd)
    {
        m_BD = bd;
        m_NID = id;
        strncpy(m_fname, fname, 19);
    }


};