#include<iostream>
#include<cstring>


using namespace std;

class stringg
{
public:
    char* str;
    int len;
public:
    stringg(): str(nullptr), len(0) {}
    stringg(const char* m_str, int m_len)
    {
        len = m_len;
        str = new char [len+1];
        strcpy(str, m_str);
        str[len] = '\0';
    }
    ~stringg()
    {
        delete[] str;
    };

    void assign(const char* newval)
    {
        delete[] str;
        char* str = new char[strlen(newval)+1];
        strcpy(str, newval);
        str[strlen(newval)] = '\0';
        len = strlen(newval);
    }

    void print()
    {
        for (int i = 0; i < len; i++)
        {
            cout<<str[i];
        }
        cout<<endl;
        
    }

    int lenn()
    {
        int size=0;
        char* temp = str; 
        while (*temp)
        {
            size++;
            temp++;
        }
        return size;
    }

    void add(const stringg& strr)
    {
        int len2=strlen(strr.str);
        char* strnew= new char[len+len2+1];
        for (int i = 0; i < len; i++)
        {
            strnew[i] = str[i];
        }

        for (int j = 0; j <len2; j++)
        {
            strnew[j+len]= strr.str[j];
             
        }
        strnew[len+len2] = '\0';
        len= len+len2;
        delete[] str;
        str=strnew;
    }


    // void add_withspace_betweenthem(const stringg& strr)
    // {
    //     int len2=strlen(strr.str);
    //     char* strnew= new char[len+len2+2];
    //     for (int i = 0; i < len; i++)
    //     {
    //         strnew[i] = str[i];
    //     }
    //     strnew[len] = ' ';

    //     for (int j = 0; j <len2; j++)
    //     {
    //         strnew[j+len+1]= strr.str[j];
             
    //     }
    //     strnew[len+len2+1] = '\0';
    //     len= len+len2+1;
    //     delete[] str;
    //     str=strnew;
    // }

    bool checkSubstr(const stringg& strr) const
    {
        for (int i = 0; i <= len - strr.len; i++)
        {
            bool flag=true;
            for (int j = 0; j < strr.len; j++)
            {
                if (str[i+j]!=strr.str[j])
                {
                    flag=false;
                    break;
                }               
            }
            if (flag==true)
            {
                return true;
            } 
        }
        return false;
    }
};




int main()
{
    const char* str= "hello";
    int len1= 5;
    stringg str1(str, len1);
    const char* strr= "hell";
    int len2= 4;
    stringg str2(strr, len2);
    const char* strrr= "yk";
    int len3= 2;
    stringg str3(strrr, len3);
    str1.print();
    str2.print();
    cout << str1.str << ":" << str1.lenn() << endl;
    cout << str2.str << ":" << str2.lenn() << endl;
    str1.add(str2);
    // str1.append_withspace_betweenthem(str2);
    str1.print();
    cout<<boolalpha <<str1.checkSubstr(str2)<<endl;
    cout<<boolalpha <<str1.checkSubstr(str3)<<endl;
    return 0;
}