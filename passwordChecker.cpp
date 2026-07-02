#include<iostream>
using namespace std;
int main()
{
    string password;
    bool passwordNumber = false;
    bool PasswordSpecialChar = false;

    cout << "Be at least 8 characters long." << endl;
    cout << "Contain at least one number." << endl;
    cout << "Contain at least one special character (!, @, #, $, %, ^, &, *)." << endl;
    cout << "Enter your password: ";
    cin >> password;
    if(password.length() < 8)
    {
        cout << "Password is too short." << endl;
        return 0;
    }
    for(char ch : password)
    {
        if(isdigit(ch))
        {
            passwordNumber = true;
        }
        if(ch='!' || ch=='@' || ch=='#' || ch=='$' || ch=='%' || ch=='^' || ch=='&' || ch=='*')
        {
            PasswordSpecialChar = true;
        }
    }
    if(!passwordNumber)
    {
        cout << "Password must contain at least one number." << endl;
        return 0;
    }
    if(!PasswordSpecialChar)
    {
        cout << "Password must contain at least one special character." << endl;
        return 0;
    }
    cout << "Password is valid." << endl;
    return 0;
}
