#include<iostream>
#include<string.h>
#include<cstring>
#include<stdlib.h>

using namespace std;

class Student
{
public:
    int m_stdNum;
    char m_FirstName[20];
    char m_LastName[20];
    int m_CoursesPassed;
    int m_Credits[40];
    double m_Grades[40];
    char* m_CourseNames[40];

    Student(int stdnum, const char* fname, const char* lname)
    {
        m_stdNum = stdnum;
        strncpy(m_FirstName, fname, 19);
        m_FirstName[19] = '\0';
        strncpy(m_LastName, lname, 19);
        m_LastName[19] = '\0';
        m_CoursesPassed = 0;
        
    }
    ~Student()
    {
        for (int i = 0; i < 40; i++)
        {
            if (m_CourseNames[i] != NULL)
            {
                delete[] m_CourseNames[i];
            }
            
        }
    }

    double GetGPA()
    {
        double sumGrade = 0;
        int sumCredit = 0;
        for(int i=0; i<m_CoursesPassed; i++) 
        {
            sumGrade += m_Credits[i] * m_Grades[i];
            sumCredit += m_Credits[i];
        }
        return sumGrade/sumCredit;
    }

    void list_courses()
    {
        for(int i=0; i<m_CoursesPassed; i++) 
        {
            cout << "Course Name: " << m_CourseNames[i] << " , " << "Course Grade: " << m_Grades[i] << " , " << "Course Credits: " << m_Credits[i] << endl;        
        }
    }

    void register_course(int credits, const char* name, double grade)
    {
        m_Credits[m_CoursesPassed] = credits;
        m_Grades[m_CoursesPassed] = grade;
        char* namecopy = new char[strlen(name) + 1];
            //  (char*) malloc(strlen(name) + 1);
        strcpy(namecopy, name);
        m_CourseNames[m_CoursesPassed] = namecopy;
        m_CoursesPassed++;
    }

    void display_student_info()
    {
        cout << "Student First Name: " << m_FirstName <<endl;
        cout << "Student Last Name: " << m_LastName <<endl;
        cout << "Student Number: " << m_stdNum <<endl;
        cout << "Courses Passed: " << m_CoursesPassed <<endl;
        cout << "GPA: " << GetGPA() <<endl;
        cout << "Courses Details:" <<endl;
        list_courses();
    }
};



int main()
{
    char firstname[20]; 
    char lastname[20];
    int stdNum;

    cout << "Enter student's first name: ";
    cin >> firstname;
    cout << "Enter student's last name: ";
    cin >> lastname;
    cout << "Enter student's number: ";
    cin >> stdNum;

    Student s(stdNum, firstname, lastname);

    char bufc[20];
    double grade;
    int credits;
    while(true)
    {
        cout << "Enter course name (enter 'A' to stop): ";
        cin >> bufc;
        if (strcmp(bufc, "A") == 0)
            break;
        cout << "Enter course credits: ";
        cin >> credits;
        cout << "Enter course grade: ";
        cin >> grade;
        s.register_course(credits, bufc, grade);
    }
    s.display_student_info();
    return 0;
}