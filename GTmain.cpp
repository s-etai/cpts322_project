#include "GTheader.hpp"



int main(void){

    int menuSelection = -1;

    do
    {
        printMainMenu();
        do
        {
            cin>>menuSelection;
        } while (menuSelection < 0 || menuSelection > 5);

        switch (menuSelection)
        {
            case 1:
                cout << "not implemented yet, (print list of courses)\n";
                break;
            case 2:
                cout << "not implemented yet, (Add course)\n";
                break;
            case 3:
                cout << "not implemented yet, (display calender)\n";
                break;
            case 4:
                cout << "not implemented yet, (show notifications)\n";
                break;
        }


    } while (menuSelection != 5);



}